namespace WindowsFormsApplication1
{
    partial class EmployeeWork
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
            this.bt_Withdraw = new System.Windows.Forms.Button();
            this.bt_Deposit = new System.Windows.Forms.Button();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Balance = new System.Windows.Forms.Label();
            this.lb_Acno = new System.Windows.Forms.Label();
            this.bt_Detail = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Transfer = new System.Windows.Forms.Button();
            this.lb_Atype = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Withdraw
            // 
            this.bt_Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Withdraw.Location = new System.Drawing.Point(392, 338);
            this.bt_Withdraw.Name = "bt_Withdraw";
            this.bt_Withdraw.Size = new System.Drawing.Size(100, 70);
            this.bt_Withdraw.TabIndex = 0;
            this.bt_Withdraw.Text = "&Withdraw";
            this.bt_Withdraw.UseVisualStyleBackColor = true;
            this.bt_Withdraw.Click += new System.EventHandler(this.bt_Withdraw_Click);
            // 
            // bt_Deposit
            // 
            this.bt_Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Deposit.Location = new System.Drawing.Point(214, 341);
            this.bt_Deposit.Name = "bt_Deposit";
            this.bt_Deposit.Size = new System.Drawing.Size(118, 70);
            this.bt_Deposit.TabIndex = 1;
            this.bt_Deposit.Text = "&Deposit";
            this.bt_Deposit.UseVisualStyleBackColor = true;
            this.bt_Deposit.Click += new System.EventHandler(this.bt_Deposit_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(132, 18);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(248, 33);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "Jaykant Prajapati";
            this.lb_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Balance
            // 
            this.lb_Balance.AutoSize = true;
            this.lb_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lb_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Balance.Location = new System.Drawing.Point(133, 130);
            this.lb_Balance.Name = "lb_Balance";
            this.lb_Balance.Size = new System.Drawing.Size(222, 25);
            this.lb_Balance.TabIndex = 5;
            this.lb_Balance.Text = "Balance :45,450000";
            // 
            // lb_Acno
            // 
            this.lb_Acno.AutoSize = true;
            this.lb_Acno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Acno.Location = new System.Drawing.Point(134, 66);
            this.lb_Acno.Name = "lb_Acno";
            this.lb_Acno.Size = new System.Drawing.Size(202, 20);
            this.lb_Acno.TabIndex = 6;
            this.lb_Acno.Text = "Account Number :15554";
            // 
            // bt_Detail
            // 
            this.bt_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Detail.Location = new System.Drawing.Point(532, 339);
            this.bt_Detail.Name = "bt_Detail";
            this.bt_Detail.Size = new System.Drawing.Size(80, 64);
            this.bt_Detail.TabIndex = 7;
            this.bt_Detail.Text = "&Detail";
            this.bt_Detail.UseVisualStyleBackColor = true;
            this.bt_Detail.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(655, 333);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(111, 64);
            this.bt_Exit.TabIndex = 8;
            this.bt_Exit.Text = "&Close";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lb_Atype);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Controls.Add(this.lb_Acno);
            this.panel1.Controls.Add(this.lb_Balance);
            this.panel1.Location = new System.Drawing.Point(24, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 194);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_Transfer
            // 
            this.bt_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Transfer.Location = new System.Drawing.Point(55, 341);
            this.bt_Transfer.Name = "bt_Transfer";
            this.bt_Transfer.Size = new System.Drawing.Size(128, 67);
            this.bt_Transfer.TabIndex = 10;
            this.bt_Transfer.Text = "Transfer";
            this.bt_Transfer.UseVisualStyleBackColor = true;
            this.bt_Transfer.Click += new System.EventHandler(this.bt_Transfer_Click);
            // 
            // lb_Atype
            // 
            this.lb_Atype.AutoSize = true;
            this.lb_Atype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lb_Atype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Atype.Location = new System.Drawing.Point(133, 96);
            this.lb_Atype.Name = "lb_Atype";
            this.lb_Atype.Size = new System.Drawing.Size(222, 25);
            this.lb_Atype.TabIndex = 7;
            this.lb_Atype.Text = "Balance :45,450000";
            // 
            // EmployeeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.bt_Transfer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Detail);
            this.Controls.Add(this.bt_Deposit);
            this.Controls.Add(this.bt_Withdraw);
            this.Name = "EmployeeWork";
            this.Text = "EmployeeWork";
            this.Load += new System.EventHandler(this.EmployeeWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Withdraw;
        private System.Windows.Forms.Button bt_Deposit;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Balance;
        private System.Windows.Forms.Label lb_Acno;
        private System.Windows.Forms.Button bt_Detail;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Transfer;
        private System.Windows.Forms.Label lb_Atype;
    }
}