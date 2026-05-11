using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GymManagement
{
    public partial class renewEditPlanForm : Form
    {
        OleDbConnection con = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + @"\GymDB.accdb");

        public string LoggedInEmail { get; set; }

        private decimal currentCredit = 0;
        private decimal newPlanPrice = 0;
        private string currentPlanText = "";

        public renewEditPlanForm()
        {
            InitializeComponent();
        }

        public void LoadCurrentPlan()
        {
            if (string.IsNullOrEmpty(LoggedInEmail))
            {
                MessageBox.Show("No member email provided.", "Error");
                this.Close();
                return;
            }

            string sql = "SELECT Plan, Credit, StartDate FROM Members WHERE Email = @Email AND Active = True";

            try
            {
                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;

                    if (con.State == ConnectionState.Open) con.Close();
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentPlanText = reader["Plan"].ToString();          // e.g. "Monthly - ₱800"
                            currentCredit = Convert.ToDecimal(reader["Credit"]);
                            DateTime startDate;
                            if (!DateTime.TryParse(reader["StartDate"].ToString(), out startDate))
                                startDate = DateTime.Today;

                            //Parsing
                            string planNameLower = currentPlanText.ToLower();
                            int months = 1;
                            if (planNameLower.StartsWith("quarterly"))
                                months = 3;
                            else if (planNameLower.StartsWith("yearly"))
                                months = 12;

                            DateTime expiryDate = startDate.AddMonths(months);

                            string planDisplay = currentPlanText.Split('₱')[0].Trim('-', ' ').Trim();
                            lbl_Expiry.Text = string.Format(
                                "Your current plan ({0}) expires on {1:MMM dd, yyyy}.",
                                planDisplay,
                                expiryDate);
                        }
                        else
                        {
                            MessageBox.Show("Member not found or inactive.", "Error");
                            this.Close();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                this.Close();
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            // Validation plan
            string newPlanText = cmb_Plan.Text;
            if (string.IsNullOrEmpty(newPlanText) || !newPlanText.Contains("₱"))
            {
                MessageBox.Show("Please select a new plan.");
                return;
            }

            string[] parts = newPlanText.Split('₱');
            newPlanPrice = decimal.Parse(parts[1].Trim());

            // Re‑read the current credit from the database para safe
            string creditSql = "SELECT Credit FROM Members WHERE Email = @Email AND Active = True";
            try
            {
                using (var cmd = new OleDbCommand(creditSql, con))
                {
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;

                    if (con.State == ConnectionState.Open) con.Close();
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();

                    if (result != null && result != DBNull.Value)
                        currentCredit = Convert.ToDecimal(result);
                    else
                    {
                        MessageBox.Show("Account not found.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying credit: " + ex.Message);
                return;
            }

            if (currentCredit < newPlanPrice)
            {
                MessageBox.Show(string.Format("Insufficient credit. You need {0:C} but have {1:C}.", newPlanPrice, currentCredit),
                    "Cannot Renew", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the member's plan, reset start date to today, and deduct credit
            string updateSql = @"UPDATE Members 
                         SET Plan = @Plan, StartDate = @StartDate, Credit = Credit - @Price
                         WHERE Email = @Email AND Active = True";

            try
            {
                using (var cmd = new OleDbCommand(updateSql, con))
                {
                    // Correct order: @Plan, @StartDate, @Price, @Email (matching the SQL)
                    cmd.Parameters.Add("@Plan", OleDbType.VarWChar).Value = newPlanText;
                    cmd.Parameters.Add("@StartDate", OleDbType.Date).Value = DateTime.Today;
                    cmd.Parameters.Add("@Price", OleDbType.Currency).Value = newPlanPrice;
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;

                    if (con.State == ConnectionState.Open) con.Close();
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                    {
                        // Insert transaction record (deduction)
                        if (string.IsNullOrEmpty(MemberFullName))
                        {
                            MemberFullName = GetMemberFullName();
                        }

                        string txnSql = @"INSERT INTO Transactions 
                    (MemberName, Amount, Description, PaymentDate, PaymentMethod)
                    VALUES (@mname, @amt, @desc, @payDate, @method)";
                        using (var cmdTxn = new OleDbCommand(txnSql, con))
                        {
                            cmdTxn.Parameters.Add("@mname", OleDbType.VarWChar).Value = MemberFullName;
                            cmdTxn.Parameters.Add("@amt", OleDbType.Currency).Value = -newPlanPrice;
                            cmdTxn.Parameters.Add("@desc", OleDbType.VarWChar).Value = "Renewal / Plan change – " + newPlanText;
                            cmdTxn.Parameters.Add("@payDate", OleDbType.Date).Value = dtp_PaymentDate.Value;
                            cmdTxn.Parameters.Add("@method", OleDbType.VarWChar).Value = DBNull.Value;

                            if (con.State == ConnectionState.Open) con.Close();
                            con.Open();
                            cmdTxn.ExecuteNonQuery();
                            con.Close();
                        }

                        MessageBox.Show("Plan updated successfully! New plan: " + newPlanText, "Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Account may be inactive.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during renewal: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Use this to get the full name from DB if not set
        private string GetMemberFullName()
        {
            string sql = "SELECT FirstName, LastName FROM Members WHERE Email = @Email";
            using (var cmd = new OleDbCommand(sql, con))
            {
                cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;
                if (con.State == ConnectionState.Open) con.Close();
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return reader["FirstName"] + " " + reader["LastName"];
                }
                con.Close();
            }
            return "Unknown";
        }

        //get the fullname from dashboard
        public string MemberFullName { get; set; }
    }
}
