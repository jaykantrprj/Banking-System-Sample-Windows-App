namespace WindowsFormsApplication1
{
    partial class NewCust1
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
            this.Facilities = new System.Windows.Forms.GroupBox();
            this.cb_SafeLockers = new System.Windows.Forms.CheckBox();
            this.cb_SmsAlerts = new System.Windows.Forms.CheckBox();
            this.cb_ChequeBook = new System.Windows.Forms.CheckBox();
            this.cb_CreditCard = new System.Windows.Forms.CheckBox();
            this.lb_DebitCard = new System.Windows.Forms.CheckBox();
            this.cb_AtmCard = new System.Windows.Forms.CheckBox();
            this.cb_MobileBanking = new System.Windows.Forms.CheckBox();
            this.cb_NetBanking = new System.Windows.Forms.CheckBox();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.bt_PreviousForm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lb_DepositAmount = new System.Windows.Forms.Label();
            this.tb_DepositAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Facilities.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Facilities
            // 
            this.Facilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Facilities.Controls.Add(this.cb_SafeLockers);
            this.Facilities.Controls.Add(this.cb_SmsAlerts);
            this.Facilities.Controls.Add(this.cb_ChequeBook);
            this.Facilities.Controls.Add(this.cb_CreditCard);
            this.Facilities.Controls.Add(this.lb_DebitCard);
            this.Facilities.Controls.Add(this.cb_AtmCard);
            this.Facilities.Controls.Add(this.cb_MobileBanking);
            this.Facilities.Controls.Add(this.cb_NetBanking);
            this.Facilities.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facilities.Location = new System.Drawing.Point(14, 47);
            this.Facilities.Name = "Facilities";
            this.Facilities.Size = new System.Drawing.Size(223, 301);
            this.Facilities.TabIndex = 4;
            this.Facilities.TabStop = false;
            this.Facilities.Text = "Facilities";
            // 
            // cb_SafeLockers
            // 
            this.cb_SafeLockers.AutoSize = true;
            this.cb_SafeLockers.Location = new System.Drawing.Point(6, 213);
            this.cb_SafeLockers.Name = "cb_SafeLockers";
            this.cb_SafeLockers.Size = new System.Drawing.Size(151, 26);
            this.cb_SafeLockers.TabIndex = 8;
            this.cb_SafeLockers.Text = "Safe Lockers";
            this.cb_SafeLockers.UseVisualStyleBackColor = true;
            // 
            // cb_SmsAlerts
            // 
            this.cb_SmsAlerts.AutoSize = true;
            this.cb_SmsAlerts.Location = new System.Drawing.Point(6, 244);
            this.cb_SmsAlerts.Name = "cb_SmsAlerts";
            this.cb_SmsAlerts.Size = new System.Drawing.Size(128, 26);
            this.cb_SmsAlerts.TabIndex = 7;
            this.cb_SmsAlerts.Text = "Sms Alerts";
            this.cb_SmsAlerts.UseVisualStyleBackColor = true;
            // 
            // cb_ChequeBook
            // 
            this.cb_ChequeBook.AutoSize = true;
            this.cb_ChequeBook.Location = new System.Drawing.Point(6, 89);
            this.cb_ChequeBook.Name = "cb_ChequeBook";
            this.cb_ChequeBook.Size = new System.Drawing.Size(155, 26);
            this.cb_ChequeBook.TabIndex = 6;
            this.cb_ChequeBook.Text = "Cheque Book";
            this.cb_ChequeBook.UseVisualStyleBackColor = true;
            // 
            // cb_CreditCard
            // 
            this.cb_CreditCard.AutoSize = true;
            this.cb_CreditCard.Location = new System.Drawing.Point(6, 151);
            this.cb_CreditCard.Name = "cb_CreditCard";
            this.cb_CreditCard.Size = new System.Drawing.Size(135, 26);
            this.cb_CreditCard.TabIndex = 5;
            this.cb_CreditCard.Text = "Credit Card";
            this.cb_CreditCard.UseVisualStyleBackColor = true;
            // 
            // lb_DebitCard
            // 
            this.lb_DebitCard.AutoSize = true;
            this.lb_DebitCard.Location = new System.Drawing.Point(6, 120);
            this.lb_DebitCard.Name = "lb_DebitCard";
            this.lb_DebitCard.Size = new System.Drawing.Size(127, 26);
            this.lb_DebitCard.TabIndex = 4;
            this.lb_DebitCard.Text = "Debit Card";
            this.lb_DebitCard.UseVisualStyleBackColor = true;
            // 
            // cb_AtmCard
            // 
            this.cb_AtmCard.AutoSize = true;
            this.cb_AtmCard.Location = new System.Drawing.Point(6, 182);
            this.cb_AtmCard.Name = "cb_AtmCard";
            this.cb_AtmCard.Size = new System.Drawing.Size(115, 26);
            this.cb_AtmCard.TabIndex = 3;
            this.cb_AtmCard.Text = "Atm Card";
            this.cb_AtmCard.UseVisualStyleBackColor = true;
            // 
            // cb_MobileBanking
            // 
            this.cb_MobileBanking.AutoSize = true;
            this.cb_MobileBanking.Location = new System.Drawing.Point(6, 58);
            this.cb_MobileBanking.Name = "cb_MobileBanking";
            this.cb_MobileBanking.Size = new System.Drawing.Size(173, 26);
            this.cb_MobileBanking.TabIndex = 2;
            this.cb_MobileBanking.Text = "Mobile Banking";
            this.cb_MobileBanking.UseVisualStyleBackColor = true;
            // 
            // cb_NetBanking
            // 
            this.cb_NetBanking.AutoSize = true;
            this.cb_NetBanking.Location = new System.Drawing.Point(6, 27);
            this.cb_NetBanking.Name = "cb_NetBanking";
            this.cb_NetBanking.Size = new System.Drawing.Size(141, 26);
            this.cb_NetBanking.TabIndex = 1;
            this.cb_NetBanking.Text = "Net Banking";
            this.cb_NetBanking.UseVisualStyleBackColor = true;
            // 
            // bt_Submit
            // 
            this.bt_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Submit.Location = new System.Drawing.Point(421, 372);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(152, 51);
            this.bt_Submit.TabIndex = 7;
            this.bt_Submit.Text = "&Submit";
            this.bt_Submit.UseVisualStyleBackColor = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click_1);
            // 
            // bt_PreviousForm
            // 
            this.bt_PreviousForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PreviousForm.Location = new System.Drawing.Point(20, 372);
            this.bt_PreviousForm.Name = "bt_PreviousForm";
            this.bt_PreviousForm.Size = new System.Drawing.Size(224, 51);
            this.bt_PreviousForm.TabIndex = 8;
            this.bt_PreviousForm.Text = "&Previous Form";
            this.bt_PreviousForm.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Location = new System.Drawing.Point(14, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lb_DepositAmount
            // 
            this.lb_DepositAmount.AutoSize = true;
            this.lb_DepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DepositAmount.Location = new System.Drawing.Point(116, 59);
            this.lb_DepositAmount.Name = "lb_DepositAmount";
            this.lb_DepositAmount.Size = new System.Drawing.Size(164, 24);
            this.lb_DepositAmount.TabIndex = 0;
            this.lb_DepositAmount.Text = "Deposit Amount:";
            // 
            // tb_DepositAmount
            // 
            this.tb_DepositAmount.AccessibleDescription = "Enter Account ";
            this.tb_DepositAmount.BackColor = System.Drawing.Color.White;
            this.tb_DepositAmount.Location = new System.Drawing.Point(133, 125);
            this.tb_DepositAmount.Name = "tb_DepositAmount";
            this.tb_DepositAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_DepositAmount.Size = new System.Drawing.Size(139, 20);
            this.tb_DepositAmount.TabIndex = 1;
            this.tb_DepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tb_DepositAmount);
            this.panel1.Controls.Add(this.lb_DepositAmount);
            this.panel1.Location = new System.Drawing.Point(243, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 301);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NewCust1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 575);
            this.Controls.Add(this.Facilities);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.bt_PreviousForm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "NewCust1";
            this.Text = "NewCust1";
            this.Load += new System.EventHandler(this.NewCust1_Load);
            this.Facilities.ResumeLayout(false);
            this.Facilities.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Facilities;
        private System.Windows.Forms.CheckBox cb_SafeLockers;
        private System.Windows.Forms.CheckBox cb_SmsAlerts;
        private System.Windows.Forms.CheckBox cb_ChequeBook;
        private System.Windows.Forms.CheckBox cb_CreditCard;
        private System.Windows.Forms.CheckBox lb_DebitCard;
        private System.Windows.Forms.CheckBox cb_AtmCard;
        private System.Windows.Forms.CheckBox cb_MobileBanking;
        private System.Windows.Forms.CheckBox cb_NetBanking;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.Button bt_PreviousForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lb_DepositAmount;
        private System.Windows.Forms.TextBox tb_DepositAmount;
        private System.Windows.Forms.Panel panel1;
    }
}