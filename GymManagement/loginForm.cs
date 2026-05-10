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
    public partial class loginForm : Form
    {
        OleDbConnection con = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + @"\GymDB.accdb");

        public loginForm()
        {
            InitializeComponent();
        }

        private void lbl_CreateAccount_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();
            string password = txt_Password.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"SELECT COUNT(*) 
                   FROM Members 
                   WHERE Email = @Email AND [Password] = @Password AND Active = True";

            try
            {
                using (var cmd = new OleDbCommand(sql, con))
                {
                    // Using explicit OleDbType to avoid data type mismatches
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = email;
                    cmd.Parameters.Add("@Password", OleDbType.VarWChar).Value = password;

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();

                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (count > 0)
                    {
                        //successful login
                        dashboardForm dashboard = new dashboardForm();
                        dashboard.LoggedInEmail = email;            //passing the email for the dashboard
                        dashboard.dashboardForm_LoadData();   //loading the data
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Password.Clear();
                        txt_Password.Focus();
                    }
                }
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
    }
}
