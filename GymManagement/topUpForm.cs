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
    public partial class topUpForm : Form
    {

        OleDbConnection con = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + @"\GymDB.accdb");

        public string LoggedInEmail { get; set; }
        public string MemberFullName { get; set; }

        public topUpForm()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string amountText = txt_Amount.Text.Trim();
            decimal amount = 0;

            //Validate amount
            if (string.IsNullOrEmpty(amountText) || !decimal.TryParse(amountText, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Invalid Amount",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Update member's credit (add)
            string updateSql = "UPDATE Members SET Credit = Credit + @Amount WHERE Email = @Email AND Active = True";

            try
            {
                using (var cmd = new OleDbCommand(updateSql, con))
                {
                    cmd.Parameters.Add("@Amount", OleDbType.Currency).Value = amount;
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows == 0)
                    {
                        MessageBox.Show("Update failed. Account may not exist or is inactive.", "Error");
                        return;
                    }
                }

                //Insert transaction record (positive amount)
                string txnSql = @"INSERT INTO Transactions 
                    (MemberName, Amount, Description, PaymentDate, PaymentMethod)
                    VALUES (@mname, @amt, @desc, @payDate, @method)";

                using (var cmdTxn = new OleDbCommand(txnSql, con))
                {
                    cmdTxn.Parameters.Add("@mname", OleDbType.VarWChar).Value = MemberFullName;
                    cmdTxn.Parameters.Add("@amt", OleDbType.Currency).Value = amount;
                    cmdTxn.Parameters.Add("@desc", OleDbType.VarWChar).Value = "Top‑up";
                    cmdTxn.Parameters.Add("@payDate", OleDbType.Date).Value = dtp_PaymentDate.Value;
                    cmdTxn.Parameters.Add("@method", OleDbType.VarWChar).Value = cmb_Method.Text;

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();
                    cmdTxn.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Top‑up of " + amount.ToString("C") + " added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
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
            this.Hide();
        }
    }
}
