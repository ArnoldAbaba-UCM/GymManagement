using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

// Cyrus
namespace GymManagement
{
    public partial class Register : Form
    {
        OleDbConnection con = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + @"\GymDB.accdb");

        public Register()
        {
            InitializeComponent();
        }

        private void btn_Plan_Click(object sender, EventArgs e)
        {
            pl_Personal.Hide();
            pl_Plan.Show();
            pl_Payment.Hide();
        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {
            pl_Personal.Show();
            pl_Plan.Hide();
            pl_Payment.Hide();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            pl_Payment.Show();
            pl_Plan.Hide();
            pl_Personal.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (pl_Personal.Visible)
            {
                pl_Personal.Hide();
                pl_Plan.Show();
                pl_Payment.Hide();
            }
            else if (pl_Plan.Visible)
            {
                pl_Plan.Hide();
                pl_Payment.Show();
            }
        }

        private void btn_CompleteRegistration_Click(object sender, EventArgs e)
        {
            string firstName = txt_FirstName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();
            string email = txt_Email.Text.Trim();
            string password = txt_Password.Text;
            string phone = txt_PhoneNumber.Text.Trim();
            string planText = cmb_Plan.Text;
            string amountText = txt_Amount.Text.Trim();
            DateTime dob = dtp_DateOfBirth.Value.Date;
            DateTime startDate = dtp_StartDate.Value;

            //Validation Checking parttt
            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!email.Contains("@") || !email.Substring(email.IndexOf("@")).Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            if (!phone.StartsWith("09") || phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must start with '09' and be exactly 11 digits (e.g. 09123456789).");
                return;
            }

            if (dob > DateTime.Today)
            {
                MessageBox.Show("Date of birth cannot be in the future.");
                return;
            }

            if (string.IsNullOrEmpty(planText) || !planText.Contains("₱"))
            {
                MessageBox.Show("Please select a membership plan.");
                return;
            }

            decimal amount = 0;
            if (!string.IsNullOrEmpty(amountText))
            {
                if (!decimal.TryParse(amountText, out amount) || amount < 0)
                {
                    MessageBox.Show("Top-up amount must be a valid positive number (or leave blank).");
                    return;
                }
            }

            string[] planParts = planText.Split('₱');
            decimal planPrice = decimal.Parse(planParts[1].Trim());

            if (amount < planPrice)
            {
                MessageBox.Show("The initial top‑up must be at least the plan price.",
                                "Insufficient Top‑up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal remainingCredit = amount - planPrice;
            InsertMember(
                firstName, lastName, email, password,
                phone, dob, planText, startDate, remainingCredit.ToString()
            );

            //Transactions part
            string memberFullName = firstName + " " + lastName;
            string txnSql = @"INSERT INTO Transactions 
            (MemberName, Amount, Description, PaymentDate, PaymentMethod)
            VALUES (@mname, @amt, @desc, @payDate, @method)";

            try
            {
                //Top up recroding part
                using (var cmd = new OleDbCommand(txnSql, con))
                {
                    cmd.Parameters.Add("@mname", OleDbType.VarWChar).Value = memberFullName;
                    cmd.Parameters.Add("@amt", OleDbType.Currency).Value = amount;          // full top‑up
                    cmd.Parameters.Add("@desc", OleDbType.VarWChar).Value = "Initial top‑up";
                    cmd.Parameters.Add("@payDate", OleDbType.Date).Value = dtp_PaymentDate.Value;
                    cmd.Parameters.Add("@method", OleDbType.VarWChar).Value = cmb_Method.Text;

                    if (con.State == ConnectionState.Open) con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                //Plan fee deduction partt
                using (var cmd = new OleDbCommand(txnSql, con))
                {
                    cmd.Parameters.Add("@mname", OleDbType.VarWChar).Value = memberFullName;
                    cmd.Parameters.Add("@amt", OleDbType.Currency).Value = -planPrice;     // negative = fee
                    cmd.Parameters.Add("@desc", OleDbType.VarWChar).Value = "Plan fee – " + planText;
                    cmd.Parameters.Add("@payDate", OleDbType.Date).Value = startDate;      // or DateTime.Today
                    cmd.Parameters.Add("@method", OleDbType.VarWChar).Value = DBNull.Value; // no payment method for deduction

                    if (con.State == ConnectionState.Open) con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording transaction: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Dispose();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        public void InsertMember(string firstName, string lastName, string email, string password,
                          string phone, DateTime dateOfBirth, string planText, DateTime startDate, string creditText)
        {
            decimal credit = 0;
            decimal.TryParse(creditText, out credit);

            string sql = @"INSERT INTO Members 
        (FirstName, LastName, Email, [Password], Phone, DateOfBirth, StartDate, Plan, Credit, Active)
        VALUES (@FirstName, @LastName, @Email, @Password, @Phone, @DateOfBirth, @StartDate, @Plan, @Credit, True)";

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();

                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@Plan", planText);
                    cmd.Parameters.AddWithValue("@Credit", credit);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Member registered successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

    }
}
