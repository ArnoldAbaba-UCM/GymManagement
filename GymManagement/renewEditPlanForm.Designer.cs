namespace GymManagement
{
    partial class renewEditPlanForm
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
            this.cmb_Plan = new System.Windows.Forms.ComboBox();
            this.dtp_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_SelectPlan = new System.Windows.Forms.Label();
            this.lbl_PaymentDate = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Expiry = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmb_Plan.Location = new System.Drawing.Point(120, 53);
            this.cmb_Plan.Name = "cmb_Plan";
            this.cmb_Plan.Size = new System.Drawing.Size(189, 28);
            this.cmb_Plan.TabIndex = 30;
            // 
            // dtp_PaymentDate
            // 
            this.dtp_PaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PaymentDate.Location = new System.Drawing.Point(120, 99);
            this.dtp_PaymentDate.Name = "dtp_PaymentDate";
            this.dtp_PaymentDate.Size = new System.Drawing.Size(189, 22);
            this.dtp_PaymentDate.TabIndex = 31;
            // 
            // lbl_SelectPlan
            // 
            this.lbl_SelectPlan.AutoSize = true;
            this.lbl_SelectPlan.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_SelectPlan.Location = new System.Drawing.Point(26, 61);
            this.lbl_SelectPlan.Name = "lbl_SelectPlan";
            this.lbl_SelectPlan.Size = new System.Drawing.Size(64, 13);
            this.lbl_SelectPlan.TabIndex = 32;
            this.lbl_SelectPlan.Text = "Select Plan:";
            // 
            // lbl_PaymentDate
            // 
            this.lbl_PaymentDate.AutoSize = true;
            this.lbl_PaymentDate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_PaymentDate.Location = new System.Drawing.Point(26, 106);
            this.lbl_PaymentDate.Name = "lbl_PaymentDate";
            this.lbl_PaymentDate.Size = new System.Drawing.Size(77, 13);
            this.lbl_PaymentDate.TabIndex = 33;
            this.lbl_PaymentDate.Text = "Payment Date:";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(222, 144);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(102, 40);
            this.btn_Confirm.TabIndex = 34;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(120, 144);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(102, 40);
            this.btn_Cancel.TabIndex = 35;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Expiry
            // 
            this.lbl_Expiry.AutoSize = true;
            this.lbl_Expiry.Location = new System.Drawing.Point(35, 9);
            this.lbl_Expiry.Name = "lbl_Expiry";
            this.lbl_Expiry.Size = new System.Drawing.Size(88, 13);
            this.lbl_Expiry.TabIndex = 36;
            this.lbl_Expiry.Text = "Your current plan";
            // 
            // renewEditPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(368, 210);
            this.Controls.Add(this.lbl_Expiry);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_PaymentDate);
            this.Controls.Add(this.lbl_SelectPlan);
            this.Controls.Add(this.dtp_PaymentDate);
            this.Controls.Add(this.cmb_Plan);
            this.Name = "renewEditPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "renewEditPlanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Plan;
        private System.Windows.Forms.DateTimePicker dtp_PaymentDate;
        private System.Windows.Forms.Label lbl_SelectPlan;
        private System.Windows.Forms.Label lbl_PaymentDate;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Expiry;

    }
}