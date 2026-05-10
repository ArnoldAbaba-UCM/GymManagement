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
    public partial class dashboardForm : Form
    {

        OleDbConnection con = new OleDbConnection(
        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        + Application.StartupPath + @"\GymDB.accdb");

        public string LoggedInEmail { get; set; }
        private string memberFullName = "";

        public dashboardForm()
        {
            InitializeComponent();
        }

        private void btn_RenewEditPlan_Click(object sender, EventArgs e)
        {
            this.Hide();                                    

            renewEditPlanForm renew = new renewEditPlanForm();
            renew.LoggedInEmail = LoggedInEmail;             //Pass the email
            renew.MemberFullName = memberFullName;           //and the full name
            renew.LoadCurrentPlan();                         //Fill expiry label and load credit

            renew.ShowDialog();                              //Wait for it to close

            //Reload dashboard data (plan, credit, transactions, etc.) and show again
            dashboardForm_LoadData();
            this.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        public void dashboardForm_LoadData()
        {
            if (string.IsNullOrEmpty(LoggedInEmail))
            {
                MessageBox.Show("No member email provided.", "Error");
                return;
            }

            string sql = @"SELECT FirstName, LastName, Plan, Credit, StartDate, Phone
                   FROM Members
                   WHERE Email = @Email AND Active = True";

            try
            {
                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //database datas
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            memberFullName = firstName + " " + lastName;
                            string planName = reader["Plan"].ToString();
                            decimal credit = Convert.ToDecimal(reader["Credit"]);
                            DateTime startDate;
                            if (!DateTime.TryParse(reader["StartDate"].ToString(), out startDate))
                                startDate = DateTime.Today;
                            string phone = reader["Phone"].ToString();

                            //assigment dawg
                            lbl_WelcomeName.Text = "Welcome, " + firstName + "!";
                            lbl_Member.Text = "Member: " + firstName + " " + lastName;
                            lbl_Credit.Text = "Credit: " + credit;
                            lbl_JoinedDate.Text = "Joined: " + startDate;
                            lbl_Status.Text = "Status: Active";

                        }
                        else
                        {
                            MessageBox.Show("Member not found or inactive.", "Error");
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading member data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            LoadRecentTransactions();
        }

        private void btn_EditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();

            editProfileForm edit = new editProfileForm();
            edit.LoggedInEmail = LoggedInEmail;
            edit.LoadProfile();

            edit.ShowDialog();                    // dashboard waits here, modal

            // When the edit form closes, check if the account was deleted
            if (edit.AccountDeleted)              //property sa editProfileForm
            {
                //ug na delete na ang account:
                this.Close();
                loginForm login = new loginForm();
                login.Show();
            }
            else
            {
                // cancelled or saved, pang refresh sa data
                dashboardForm_LoadData();
                this.Show();
            }
        }

        private void LoadRecentTransactions()
        {
            if (string.IsNullOrEmpty(memberFullName))
                return;

            string sql = @"SELECT Amount, Description, PaymentDate, PaymentMethod
                   FROM Transactions
                   WHERE MemberName = @Member
                   ORDER BY PaymentDate DESC";

            try
            {
                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.Add("@Member", OleDbType.VarWChar).Value = memberFullName;

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    con.Close();

                    dgv_RecentTransaction.DataSource = dt;
                    dgv_RecentTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //para chuy peso sign
                    dgv_RecentTransaction.Columns["Amount"].DefaultCellStyle.Format = "₱#,##0.00";
                    dgv_RecentTransaction.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btn_TopUp_Click(object sender, EventArgs e)
        {
            this.Hide();

            topUpForm topUp = new topUpForm();
            topUp.LoggedInEmail = LoggedInEmail;
            topUp.MemberFullName = memberFullName;

            topUp.ShowDialog();

            dashboardForm_LoadData();
            this.Show();
        }
    }
}
