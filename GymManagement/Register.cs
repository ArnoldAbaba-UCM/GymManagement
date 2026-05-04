using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Register : Form
    {
        int nextCounter=1;

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
            switch (nextCounter) {
                case 2:
                    pl_Personal.Show();
                    pl_Plan.Hide();
                    pl_Payment.Hide();
                    break;
                case 3:
                    pl_Personal.Hide();
                    pl_Plan.Show();
                    pl_Payment.Hide();
                    break;
                case 4:
                    pl_Payment.Show();
                    pl_Plan.Hide();
                    pl_Personal.Hide();
                    break;
                case 5:
                    nextCounter = 1;
                    break;
            }
            nextCounter++;
        }

        private void btn_CompleteRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
