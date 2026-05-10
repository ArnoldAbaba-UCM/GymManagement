namespace GymManagement
{
    partial class dashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardForm));
            this.pl_Welcome = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_WelcomeName = new System.Windows.Forms.Label();
            this.pl_Status = new System.Windows.Forms.Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Credit = new System.Windows.Forms.Label();
            this.lbl_JoinedDate = new System.Windows.Forms.Label();
            this.lbl_Member = new System.Windows.Forms.Label();
            this.btn_RenewEditPlan = new System.Windows.Forms.Button();
            this.btn_ViewTransactions = new System.Windows.Forms.Button();
            this.btn_EditProfile = new System.Windows.Forms.Button();
            this.lbl_RecentPayments = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pl_Welcome.SuspendLayout();
            this.pl_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_Welcome
            // 
            this.pl_Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.pl_Welcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_Welcome.Controls.Add(this.btn_Logout);
            this.pl_Welcome.Controls.Add(this.lbl_WelcomeName);
            this.pl_Welcome.Location = new System.Drawing.Point(-2, 0);
            this.pl_Welcome.Name = "pl_Welcome";
            this.pl_Welcome.Size = new System.Drawing.Size(780, 40);
            this.pl_Welcome.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Chocolate;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Logout.Location = new System.Drawing.Point(692, 9);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_WelcomeName
            // 
            this.lbl_WelcomeName.AutoSize = true;
            this.lbl_WelcomeName.ForeColor = System.Drawing.Color.White;
            this.lbl_WelcomeName.Location = new System.Drawing.Point(14, 14);
            this.lbl_WelcomeName.Name = "lbl_WelcomeName";
            this.lbl_WelcomeName.Size = new System.Drawing.Size(89, 13);
            this.lbl_WelcomeName.TabIndex = 0;
            this.lbl_WelcomeName.Text = "Welcome, Name!";
            // 
            // pl_Status
            // 
            this.pl_Status.BackColor = System.Drawing.Color.DarkSalmon;
            this.pl_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_Status.Controls.Add(this.lbl_Status);
            this.pl_Status.Controls.Add(this.lbl_Credit);
            this.pl_Status.Controls.Add(this.lbl_JoinedDate);
            this.pl_Status.Controls.Add(this.lbl_Member);
            this.pl_Status.Location = new System.Drawing.Point(42, 71);
            this.pl_Status.Name = "pl_Status";
            this.pl_Status.Size = new System.Drawing.Size(690, 115);
            this.pl_Status.TabIndex = 1;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(559, 67);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(40, 13);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "Status:";
            // 
            // lbl_Credit
            // 
            this.lbl_Credit.AutoSize = true;
            this.lbl_Credit.ForeColor = System.Drawing.Color.White;
            this.lbl_Credit.Location = new System.Drawing.Point(559, 26);
            this.lbl_Credit.Name = "lbl_Credit";
            this.lbl_Credit.Size = new System.Drawing.Size(37, 13);
            this.lbl_Credit.TabIndex = 2;
            this.lbl_Credit.Text = "Credit:";
            // 
            // lbl_JoinedDate
            // 
            this.lbl_JoinedDate.AutoSize = true;
            this.lbl_JoinedDate.ForeColor = System.Drawing.Color.White;
            this.lbl_JoinedDate.Location = new System.Drawing.Point(30, 67);
            this.lbl_JoinedDate.Name = "lbl_JoinedDate";
            this.lbl_JoinedDate.Size = new System.Drawing.Size(41, 13);
            this.lbl_JoinedDate.TabIndex = 1;
            this.lbl_JoinedDate.Text = "Joined:";
            // 
            // lbl_Member
            // 
            this.lbl_Member.AutoSize = true;
            this.lbl_Member.ForeColor = System.Drawing.Color.White;
            this.lbl_Member.Location = new System.Drawing.Point(30, 21);
            this.lbl_Member.Name = "lbl_Member";
            this.lbl_Member.Size = new System.Drawing.Size(51, 13);
            this.lbl_Member.TabIndex = 0;
            this.lbl_Member.Text = "Member: ";
            // 
            // btn_RenewEditPlan
            // 
            this.btn_RenewEditPlan.BackColor = System.Drawing.Color.Chocolate;
            this.btn_RenewEditPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RenewEditPlan.ForeColor = System.Drawing.Color.White;
            this.btn_RenewEditPlan.Location = new System.Drawing.Point(101, 221);
            this.btn_RenewEditPlan.Name = "btn_RenewEditPlan";
            this.btn_RenewEditPlan.Size = new System.Drawing.Size(144, 41);
            this.btn_RenewEditPlan.TabIndex = 2;
            this.btn_RenewEditPlan.Text = "Renew / Change Plan";
            this.btn_RenewEditPlan.UseVisualStyleBackColor = false;
            this.btn_RenewEditPlan.Click += new System.EventHandler(this.btn_RenewEditPlan_Click);
            // 
            // btn_ViewTransactions
            // 
            this.btn_ViewTransactions.BackColor = System.Drawing.Color.Chocolate;
            this.btn_ViewTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewTransactions.ForeColor = System.Drawing.Color.White;
            this.btn_ViewTransactions.Location = new System.Drawing.Point(251, 221);
            this.btn_ViewTransactions.Name = "btn_ViewTransactions";
            this.btn_ViewTransactions.Size = new System.Drawing.Size(144, 41);
            this.btn_ViewTransactions.TabIndex = 3;
            this.btn_ViewTransactions.Text = "View Transactions";
            this.btn_ViewTransactions.UseVisualStyleBackColor = false;
            // 
            // btn_EditProfile
            // 
            this.btn_EditProfile.BackColor = System.Drawing.Color.Chocolate;
            this.btn_EditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditProfile.ForeColor = System.Drawing.Color.White;
            this.btn_EditProfile.Location = new System.Drawing.Point(401, 221);
            this.btn_EditProfile.Name = "btn_EditProfile";
            this.btn_EditProfile.Size = new System.Drawing.Size(104, 41);
            this.btn_EditProfile.TabIndex = 4;
            this.btn_EditProfile.Text = "Edit Profile";
            this.btn_EditProfile.UseVisualStyleBackColor = false;
            // 
            // lbl_RecentPayments
            // 
            this.lbl_RecentPayments.AutoSize = true;
            this.lbl_RecentPayments.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbl_RecentPayments.ForeColor = System.Drawing.Color.White;
            this.lbl_RecentPayments.Location = new System.Drawing.Point(62, 286);
            this.lbl_RecentPayments.Name = "lbl_RecentPayments";
            this.lbl_RecentPayments.Size = new System.Drawing.Size(86, 13);
            this.lbl_RecentPayments.TabIndex = 4;
            this.lbl_RecentPayments.Text = "Recent Payment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 81);
            this.dataGridView1.TabIndex = 5;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_RecentPayments);
            this.Controls.Add(this.btn_EditProfile);
            this.Controls.Add(this.btn_ViewTransactions);
            this.Controls.Add(this.btn_RenewEditPlan);
            this.Controls.Add(this.pl_Status);
            this.Controls.Add(this.pl_Welcome);
            this.Name = "dashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardForm";
            this.pl_Welcome.ResumeLayout(false);
            this.pl_Welcome.PerformLayout();
            this.pl_Status.ResumeLayout(false);
            this.pl_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_Welcome;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_WelcomeName;
        private System.Windows.Forms.Panel pl_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Credit;
        private System.Windows.Forms.Label lbl_JoinedDate;
        private System.Windows.Forms.Label lbl_Member;
        private System.Windows.Forms.Button btn_RenewEditPlan;
        private System.Windows.Forms.Button btn_ViewTransactions;
        private System.Windows.Forms.Button btn_EditProfile;
        private System.Windows.Forms.Label lbl_RecentPayments;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}