namespace GymManagement
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pl_createYourMembership = new System.Windows.Forms.Panel();
            this.lbl_CreateYourMembership = new System.Windows.Forms.Label();
            this.btn_Personal = new System.Windows.Forms.Button();
            this.btn_Plan = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.pl_Personal = new System.Windows.Forms.Panel();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_SelectPlan = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.pl_Plan = new System.Windows.Forms.Panel();
            this.cmb_Plan = new System.Windows.Forms.ComboBox();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.pl_Payment = new System.Windows.Forms.Panel();
            this.dtp_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Method = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.cmb_Method = new System.Windows.Forms.ComboBox();
            this.lbl_PaymentDate = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_CompleteRegistration = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pl_createYourMembership.SuspendLayout();
            this.pl_Personal.SuspendLayout();
            this.pl_Plan.SuspendLayout();
            this.pl_Payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_createYourMembership
            // 
            this.pl_createYourMembership.BackColor = System.Drawing.Color.Orange;
            this.pl_createYourMembership.Controls.Add(this.lbl_CreateYourMembership);
            this.pl_createYourMembership.Location = new System.Drawing.Point(0, 0);
            this.pl_createYourMembership.Name = "pl_createYourMembership";
            this.pl_createYourMembership.Size = new System.Drawing.Size(412, 34);
            this.pl_createYourMembership.TabIndex = 1;
            // 
            // lbl_CreateYourMembership
            // 
            this.lbl_CreateYourMembership.AutoSize = true;
            this.lbl_CreateYourMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateYourMembership.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_CreateYourMembership.Location = new System.Drawing.Point(12, 9);
            this.lbl_CreateYourMembership.Name = "lbl_CreateYourMembership";
            this.lbl_CreateYourMembership.Size = new System.Drawing.Size(177, 16);
            this.lbl_CreateYourMembership.TabIndex = 0;
            this.lbl_CreateYourMembership.Text = "Create your membership";
            // 
            // btn_Personal
            // 
            this.btn_Personal.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Personal.CausesValidation = false;
            this.btn_Personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Personal.Location = new System.Drawing.Point(81, 40);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(74, 37);
            this.btn_Personal.TabIndex = 7;
            this.btn_Personal.Text = "1. Personal";
            this.btn_Personal.UseVisualStyleBackColor = false;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click);
            // 
            // btn_Plan
            // 
            this.btn_Plan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Plan.CausesValidation = false;
            this.btn_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plan.Location = new System.Drawing.Point(161, 40);
            this.btn_Plan.Name = "btn_Plan";
            this.btn_Plan.Size = new System.Drawing.Size(74, 37);
            this.btn_Plan.TabIndex = 8;
            this.btn_Plan.Text = "2. Plan";
            this.btn_Plan.UseVisualStyleBackColor = false;
            this.btn_Plan.Click += new System.EventHandler(this.btn_Plan_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Payment.CausesValidation = false;
            this.btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Payment.Location = new System.Drawing.Point(241, 40);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(74, 37);
            this.btn_Payment.TabIndex = 9;
            this.btn_Payment.Text = "3. Payment";
            this.btn_Payment.UseVisualStyleBackColor = false;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // pl_Personal
            // 
            this.pl_Personal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_Personal.BackgroundImage")));
            this.pl_Personal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_Personal.CausesValidation = false;
            this.pl_Personal.Controls.Add(this.dtp_DateOfBirth);
            this.pl_Personal.Controls.Add(this.lbl_BirthDate);
            this.pl_Personal.Controls.Add(this.lbl_PhoneNumber);
            this.pl_Personal.Controls.Add(this.lbl_Password);
            this.pl_Personal.Controls.Add(this.lbl_Email);
            this.pl_Personal.Controls.Add(this.lbl_LastName);
            this.pl_Personal.Controls.Add(this.lbl_FirstName);
            this.pl_Personal.Controls.Add(this.txt_PhoneNumber);
            this.pl_Personal.Controls.Add(this.txt_Password);
            this.pl_Personal.Controls.Add(this.txt_Email);
            this.pl_Personal.Controls.Add(this.txt_LastName);
            this.pl_Personal.Controls.Add(this.txt_FirstName);
            this.pl_Personal.Location = new System.Drawing.Point(0, 92);
            this.pl_Personal.Name = "pl_Personal";
            this.pl_Personal.Size = new System.Drawing.Size(412, 240);
            this.pl_Personal.TabIndex = 10;
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(140, 188);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(218, 22);
            this.dtp_DateOfBirth.TabIndex = 25;
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_BirthDate.Location = new System.Drawing.Point(39, 193);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(69, 13);
            this.lbl_BirthDate.TabIndex = 15;
            this.lbl_BirthDate.Text = "Date of Birth:";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(39, 161);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lbl_PhoneNumber.TabIndex = 14;
            this.lbl_PhoneNumber.Text = "Phone Number:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Password.Location = new System.Drawing.Point(39, 129);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 13;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Email.Location = new System.Drawing.Point(39, 97);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_LastName.Location = new System.Drawing.Point(37, 65);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_LastName.TabIndex = 11;
            this.lbl_LastName.Text = "Last Name:";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_FirstName.Location = new System.Drawing.Point(37, 33);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_FirstName.TabIndex = 10;
            this.lbl_FirstName.Text = "First Name:";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txt_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNumber.Location = new System.Drawing.Point(140, 153);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(218, 26);
            this.txt_PhoneNumber.TabIndex = 9;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(140, 121);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(218, 26);
            this.txt_Password.TabIndex = 8;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(140, 89);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(218, 26);
            this.txt_Email.TabIndex = 7;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.SystemColors.Info;
            this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(140, 57);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(218, 26);
            this.txt_LastName.TabIndex = 6;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BackColor = System.Drawing.SystemColors.Info;
            this.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.Location = new System.Drawing.Point(140, 25);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(218, 26);
            this.txt_FirstName.TabIndex = 0;
            // 
            // lbl_SelectPlan
            // 
            this.lbl_SelectPlan.AutoSize = true;
            this.lbl_SelectPlan.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_SelectPlan.Location = new System.Drawing.Point(56, 38);
            this.lbl_SelectPlan.Name = "lbl_SelectPlan";
            this.lbl_SelectPlan.Size = new System.Drawing.Size(64, 13);
            this.lbl_SelectPlan.TabIndex = 0;
            this.lbl_SelectPlan.Text = "Select Plan:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_StartDate.Location = new System.Drawing.Point(56, 71);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(58, 13);
            this.lbl_StartDate.TabIndex = 19;
            this.lbl_StartDate.Text = "Start Date:";
            // 
            // pl_Plan
            // 
            this.pl_Plan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_Plan.BackgroundImage")));
            this.pl_Plan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_Plan.Controls.Add(this.cmb_Plan);
            this.pl_Plan.Controls.Add(this.dtp_StartDate);
            this.pl_Plan.Controls.Add(this.lbl_StartDate);
            this.pl_Plan.Controls.Add(this.lbl_SelectPlan);
            this.pl_Plan.Location = new System.Drawing.Point(0, 89);
            this.pl_Plan.Name = "pl_Plan";
            this.pl_Plan.Size = new System.Drawing.Size(412, 240);
            this.pl_Plan.TabIndex = 19;
            this.pl_Plan.Visible = false;
            // 
            // cmb_Plan
            // 
            this.cmb_Plan.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_Plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Plan.FormattingEnabled = true;
            this.cmb_Plan.Items.AddRange(new object[] {
            "Monthly - ₱800",
            "Quarterly - ₱1200",
            "Yearly - ₱1500"});
            this.cmb_Plan.Location = new System.Drawing.Point(126, 28);
            this.cmb_Plan.Name = "cmb_Plan";
            this.cmb_Plan.Size = new System.Drawing.Size(189, 28);
            this.cmb_Plan.TabIndex = 29;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Location = new System.Drawing.Point(126, 71);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(189, 22);
            this.dtp_StartDate.TabIndex = 26;
            // 
            // pl_Payment
            // 
            this.pl_Payment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_Payment.BackgroundImage")));
            this.pl_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_Payment.Controls.Add(this.lbl_Message);
            this.pl_Payment.Controls.Add(this.dtp_PaymentDate);
            this.pl_Payment.Controls.Add(this.lbl_Method);
            this.pl_Payment.Controls.Add(this.lbl_Amount);
            this.pl_Payment.Controls.Add(this.cmb_Method);
            this.pl_Payment.Controls.Add(this.lbl_PaymentDate);
            this.pl_Payment.Controls.Add(this.txt_Amount);
            this.pl_Payment.Location = new System.Drawing.Point(0, 83);
            this.pl_Payment.Name = "pl_Payment";
            this.pl_Payment.Size = new System.Drawing.Size(412, 243);
            this.pl_Payment.TabIndex = 22;
            this.pl_Payment.Visible = false;
            // 
            // dtp_PaymentDate
            // 
            this.dtp_PaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PaymentDate.Location = new System.Drawing.Point(147, 82);
            this.dtp_PaymentDate.Name = "dtp_PaymentDate";
            this.dtp_PaymentDate.Size = new System.Drawing.Size(189, 22);
            this.dtp_PaymentDate.TabIndex = 27;
            // 
            // lbl_Method
            // 
            this.lbl_Method.AutoSize = true;
            this.lbl_Method.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Method.Location = new System.Drawing.Point(43, 118);
            this.lbl_Method.Name = "lbl_Method";
            this.lbl_Method.Size = new System.Drawing.Size(46, 13);
            this.lbl_Method.TabIndex = 28;
            this.lbl_Method.Text = "Method:";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Amount.Location = new System.Drawing.Point(43, 52);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(89, 13);
            this.lbl_Amount.TabIndex = 27;
            this.lbl_Amount.Text = "Amount (Top-up):";
            // 
            // cmb_Method
            // 
            this.cmb_Method.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_Method.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Method.FormattingEnabled = true;
            this.cmb_Method.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Bank Transfer"});
            this.cmb_Method.Location = new System.Drawing.Point(147, 110);
            this.cmb_Method.Name = "cmb_Method";
            this.cmb_Method.Size = new System.Drawing.Size(189, 28);
            this.cmb_Method.TabIndex = 26;
            // 
            // lbl_PaymentDate
            // 
            this.lbl_PaymentDate.AutoSize = true;
            this.lbl_PaymentDate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_PaymentDate.Location = new System.Drawing.Point(43, 84);
            this.lbl_PaymentDate.Name = "lbl_PaymentDate";
            this.lbl_PaymentDate.Size = new System.Drawing.Size(77, 13);
            this.lbl_PaymentDate.TabIndex = 23;
            this.lbl_PaymentDate.Text = "Payment Date:";
            // 
            // txt_Amount
            // 
            this.txt_Amount.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(147, 44);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(189, 26);
            this.txt_Amount.TabIndex = 0;
            // 
            // btn_Next
            // 
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(176, 346);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 23;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_CompleteRegistration
            // 
            this.btn_CompleteRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompleteRegistration.Location = new System.Drawing.Point(269, 346);
            this.btn_CompleteRegistration.Name = "btn_CompleteRegistration";
            this.btn_CompleteRegistration.Size = new System.Drawing.Size(143, 23);
            this.btn_CompleteRegistration.TabIndex = 24;
            this.btn_CompleteRegistration.Text = "Complete Registration";
            this.btn_CompleteRegistration.UseVisualStyleBackColor = true;
            this.btn_CompleteRegistration.Click += new System.EventHandler(this.btn_CompleteRegistration_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(155, 27);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(166, 13);
            this.lbl_Message.TabIndex = 29;
            this.lbl_Message.Text = "(this will go to your credit balance)";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 381);
            this.Controls.Add(this.btn_CompleteRegistration);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.pl_Payment);
            this.Controls.Add(this.pl_Plan);
            this.Controls.Add(this.pl_Personal);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_Plan);
            this.Controls.Add(this.btn_Personal);
            this.Controls.Add(this.pl_createYourMembership);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.pl_createYourMembership.ResumeLayout(false);
            this.pl_createYourMembership.PerformLayout();
            this.pl_Personal.ResumeLayout(false);
            this.pl_Personal.PerformLayout();
            this.pl_Plan.ResumeLayout(false);
            this.pl_Plan.PerformLayout();
            this.pl_Payment.ResumeLayout(false);
            this.pl_Payment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_createYourMembership;
        private System.Windows.Forms.Label lbl_CreateYourMembership;
        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Button btn_Plan;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Panel pl_Personal;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_SelectPlan;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Panel pl_Plan;
        private System.Windows.Forms.Panel pl_Payment;
        private System.Windows.Forms.Label lbl_Method;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.ComboBox cmb_Method;
        private System.Windows.Forms.Label lbl_PaymentDate;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_CompleteRegistration;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_PaymentDate;
        private System.Windows.Forms.ComboBox cmb_Plan;
        private System.Windows.Forms.Label lbl_Message;
    }
}