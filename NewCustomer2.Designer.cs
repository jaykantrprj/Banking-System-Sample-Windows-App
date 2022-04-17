namespace WindowsFormsApplication1
{
    partial class NewCustomer2
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_AccountNumber = new System.Windows.Forms.Label();
            this.lb_Balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_AcnDisplay = new System.Windows.Forms.Label();
            this.lb_BalanceDisplay = new System.Windows.Forms.Label();
            this.lb_NameDisplay = new System.Windows.Forms.Label();
            this.bt_Done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_AtypeDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(20, 14);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(60, 20);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Name:";
            // 
            // lb_AccountNumber
            // 
            this.lb_AccountNumber.AutoSize = true;
            this.lb_AccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccountNumber.Location = new System.Drawing.Point(20, 81);
            this.lb_AccountNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_AccountNumber.Name = "lb_AccountNumber";
            this.lb_AccountNumber.Size = new System.Drawing.Size(147, 20);
            this.lb_AccountNumber.TabIndex = 1;
            this.lb_AccountNumber.Text = "Account Number:";
            // 
            // lb_Balance
            // 
            this.lb_Balance.AutoSize = true;
            this.lb_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Balance.Location = new System.Drawing.Point(20, 141);
            this.lb_Balance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Balance.Name = "lb_Balance";
            this.lb_Balance.Size = new System.Drawing.Size(79, 24);
            this.lb_Balance.TabIndex = 2;
            this.lb_Balance.Text = "Balace:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // lb_AcnDisplay
            // 
            this.lb_AcnDisplay.AutoSize = true;
            this.lb_AcnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_AcnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AcnDisplay.Location = new System.Drawing.Point(283, 227);
            this.lb_AcnDisplay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_AcnDisplay.Name = "lb_AcnDisplay";
            this.lb_AcnDisplay.Size = new System.Drawing.Size(49, 20);
            this.lb_AcnDisplay.TabIndex = 4;
            this.lb_AcnDisplay.Text = "xxxxx";
            // 
            // lb_BalanceDisplay
            // 
            this.lb_BalanceDisplay.AutoSize = true;
            this.lb_BalanceDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_BalanceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BalanceDisplay.ForeColor = System.Drawing.Color.Black;
            this.lb_BalanceDisplay.Location = new System.Drawing.Point(281, 167);
            this.lb_BalanceDisplay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_BalanceDisplay.Name = "lb_BalanceDisplay";
            this.lb_BalanceDisplay.Size = new System.Drawing.Size(41, 20);
            this.lb_BalanceDisplay.TabIndex = 5;
            this.lb_BalanceDisplay.Text = "xxxx";
            // 
            // lb_NameDisplay
            // 
            this.lb_NameDisplay.AutoSize = true;
            this.lb_NameDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_NameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameDisplay.Location = new System.Drawing.Point(283, 25);
            this.lb_NameDisplay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_NameDisplay.Name = "lb_NameDisplay";
            this.lb_NameDisplay.Size = new System.Drawing.Size(73, 20);
            this.lb_NameDisplay.TabIndex = 6;
            this.lb_NameDisplay.Text = "xxxxxxxx";
            this.lb_NameDisplay.Click += new System.EventHandler(this.label4_Click);
            // 
            // bt_Done
            // 
            this.bt_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Done.Location = new System.Drawing.Point(564, 499);
            this.bt_Done.Margin = new System.Windows.Forms.Padding(5);
            this.bt_Done.Name = "bt_Done";
            this.bt_Done.Size = new System.Drawing.Size(231, 91);
            this.bt_Done.TabIndex = 7;
            this.bt_Done.Text = "Done";
            this.bt_Done.UseVisualStyleBackColor = true;
            this.bt_Done.Click += new System.EventHandler(this.bt_Done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account Type";
            // 
            // lb_AtypeDisplay
            // 
            this.lb_AtypeDisplay.AutoSize = true;
            this.lb_AtypeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AtypeDisplay.Location = new System.Drawing.Point(282, 76);
            this.lb_AtypeDisplay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_AtypeDisplay.Name = "lb_AtypeDisplay";
            this.lb_AtypeDisplay.Size = new System.Drawing.Size(84, 25);
            this.lb_AtypeDisplay.TabIndex = 9;
            this.lb_AtypeDisplay.Text = "xxxxxx";
            // 
            // NewCustomer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.lb_AtypeDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Done);
            this.Controls.Add(this.lb_NameDisplay);
            this.Controls.Add(this.lb_BalanceDisplay);
            this.Controls.Add(this.lb_AcnDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Balance);
            this.Controls.Add(this.lb_AccountNumber);
            this.Controls.Add(this.lb_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewCustomer2";
            this.Text = "NewCustomer2";
            this.Load += new System.EventHandler(this.NewCustomer2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_AccountNumber;
        private System.Windows.Forms.Label lb_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_AcnDisplay;
        private System.Windows.Forms.Label lb_BalanceDisplay;
        private System.Windows.Forms.Label lb_NameDisplay;
        private System.Windows.Forms.Button bt_Done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_AtypeDisplay;
    }
}