namespace GymManagement
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.pl_MemberLogin = new System.Windows.Forms.Panel();
            this.lbl_memberLogin = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_UsernameEmail = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_NewMember = new System.Windows.Forms.Label();
            this.lbl_CreateAccount = new System.Windows.Forms.Label();
            this.pl_MemberLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_MemberLogin
            // 
            this.pl_MemberLogin.BackColor = System.Drawing.Color.NavajoWhite;
            this.pl_MemberLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_MemberLogin.Controls.Add(this.lbl_memberLogin);
            this.pl_MemberLogin.Location = new System.Drawing.Point(102, 12);
            this.pl_MemberLogin.Name = "pl_MemberLogin";
            this.pl_MemberLogin.Size = new System.Drawing.Size(127, 34);
            this.pl_MemberLogin.TabIndex = 0;
            // 
            // lbl_memberLogin
            // 
            this.lbl_memberLogin.AutoSize = true;
            this.lbl_memberLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_memberLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_memberLogin.Location = new System.Drawing.Point(12, 9);
            this.lbl_memberLogin.Name = "lbl_memberLogin";
            this.lbl_memberLogin.Size = new System.Drawing.Size(106, 16);
            this.lbl_memberLogin.TabIndex = 0;
            this.lbl_memberLogin.Text = "Member Login";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.Wheat;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(53, 79);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(233, 26);
            this.txt_Email.TabIndex = 1;
            // 
            // lbl_UsernameEmail
            // 
            this.lbl_UsernameEmail.AutoSize = true;
            this.lbl_UsernameEmail.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_UsernameEmail.Location = new System.Drawing.Point(50, 63);
            this.lbl_UsernameEmail.Name = "lbl_UsernameEmail";
            this.lbl_UsernameEmail.Size = new System.Drawing.Size(32, 13);
            this.lbl_UsernameEmail.TabIndex = 2;
            this.lbl_UsernameEmail.Text = "Email";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_Password.Location = new System.Drawing.Point(50, 126);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Wheat;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(53, 142);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(233, 26);
            this.txt_Password.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Tomato;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(225, 184);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(61, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(149, 184);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(61, 37);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // lbl_NewMember
            // 
            this.lbl_NewMember.AutoSize = true;
            this.lbl_NewMember.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_NewMember.Location = new System.Drawing.Point(89, 243);
            this.lbl_NewMember.Name = "lbl_NewMember";
            this.lbl_NewMember.Size = new System.Drawing.Size(75, 13);
            this.lbl_NewMember.TabIndex = 7;
            this.lbl_NewMember.Text = "New member?";
            // 
            // lbl_CreateAccount
            // 
            this.lbl_CreateAccount.AutoSize = true;
            this.lbl_CreateAccount.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_CreateAccount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_CreateAccount.Location = new System.Drawing.Point(170, 243);
            this.lbl_CreateAccount.Name = "lbl_CreateAccount";
            this.lbl_CreateAccount.Size = new System.Drawing.Size(95, 13);
            this.lbl_CreateAccount.TabIndex = 8;
            this.lbl_CreateAccount.Text = "Create an account";
            this.lbl_CreateAccount.Click += new System.EventHandler(this.lbl_CreateAccount_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 294);
            this.Controls.Add(this.lbl_CreateAccount);
            this.Controls.Add(this.lbl_NewMember);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UsernameEmail);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.pl_MemberLogin);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pl_MemberLogin.ResumeLayout(false);
            this.pl_MemberLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_MemberLogin;
        private System.Windows.Forms.Label lbl_memberLogin;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_UsernameEmail;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_NewMember;
        private System.Windows.Forms.Label lbl_CreateAccount;
    }
}

