namespace GymManagement
{
    partial class topUpForm
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
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.dtp_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_Method = new System.Windows.Forms.ComboBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_PaymentDate = new System.Windows.Forms.Label();
            this.lbl_Method = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(118, 44);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(189, 26);
            this.txt_Amount.TabIndex = 1;
            // 
            // dtp_PaymentDate
            // 
            this.dtp_PaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PaymentDate.Location = new System.Drawing.Point(118, 76);
            this.dtp_PaymentDate.Name = "dtp_PaymentDate";
            this.dtp_PaymentDate.Size = new System.Drawing.Size(189, 22);
            this.dtp_PaymentDate.TabIndex = 28;
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
            this.cmb_Method.Location = new System.Drawing.Point(118, 104);
            this.cmb_Method.Name = "cmb_Method";
            this.cmb_Method.Size = new System.Drawing.Size(189, 28);
            this.cmb_Method.TabIndex = 29;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Amount.Location = new System.Drawing.Point(23, 51);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(89, 13);
            this.lbl_Amount.TabIndex = 30;
            this.lbl_Amount.Text = "Amount (Top-up):";
            // 
            // lbl_PaymentDate
            // 
            this.lbl_PaymentDate.AutoSize = true;
            this.lbl_PaymentDate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_PaymentDate.Location = new System.Drawing.Point(23, 83);
            this.lbl_PaymentDate.Name = "lbl_PaymentDate";
            this.lbl_PaymentDate.Size = new System.Drawing.Size(77, 13);
            this.lbl_PaymentDate.TabIndex = 31;
            this.lbl_PaymentDate.Text = "Payment Date:";
            // 
            // lbl_Method
            // 
            this.lbl_Method.AutoSize = true;
            this.lbl_Method.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Method.Location = new System.Drawing.Point(23, 112);
            this.lbl_Method.Name = "lbl_Method";
            this.lbl_Method.Size = new System.Drawing.Size(46, 13);
            this.lbl_Method.TabIndex = 32;
            this.lbl_Method.Text = "Method:";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(217, 149);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(90, 50);
            this.btn_Confirm.TabIndex = 33;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(121, 149);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 50);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // topUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(342, 232);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Method);
            this.Controls.Add(this.lbl_PaymentDate);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.cmb_Method);
            this.Controls.Add(this.dtp_PaymentDate);
            this.Controls.Add(this.txt_Amount);
            this.Name = "topUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "topUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.DateTimePicker dtp_PaymentDate;
        private System.Windows.Forms.ComboBox cmb_Method;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_PaymentDate;
        private System.Windows.Forms.Label lbl_Method;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
    }
}