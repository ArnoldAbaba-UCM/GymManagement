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
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
            MessageBox.Show(dtp_DateOfBirth.Value + " " + txt_LastName.Text);

        }

    }
}
