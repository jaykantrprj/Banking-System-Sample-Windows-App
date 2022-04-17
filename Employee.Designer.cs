namespace WindowsFormsApplication1
{
    partial class Employee
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
            this.lb_AccountNumber = new System.Windows.Forms.Label();
            this.tb_Ac = new System.Windows.Forms.TextBox();
            this.bt_Open = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_AccountNumber
            // 
            this.lb_AccountNumber.AutoSize = true;
            this.lb_AccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccountNumber.Location = new System.Drawing.Point(15, 43);
            this.lb_AccountNumber.Name = "lb_AccountNumber";
            this.lb_AccountNumber.Size = new System.Drawing.Size(129, 16);
            this.lb_AccountNumber.TabIndex = 0;
            this.lb_AccountNumber.Text = "Account Number:";
            // 
            // tb_Ac
            // 
            this.tb_Ac.Location = new System.Drawing.Point(198, 43);
            this.tb_Ac.Name = "tb_Ac";
            this.tb_Ac.Size = new System.Drawing.Size(120, 20);
            this.tb_Ac.TabIndex = 1;
            this.tb_Ac.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_Open
            // 
            this.bt_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Open.Location = new System.Drawing.Point(138, 176);
            this.bt_Open.Name = "bt_Open";
            this.bt_Open.Size = new System.Drawing.Size(117, 41);
            this.bt_Open.TabIndex = 2;
            this.bt_Open.Text = "&Open";
            this.bt_Open.UseVisualStyleBackColor = true;
            this.bt_Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lb_AccountNumber);
            this.panel1.Controls.Add(this.bt_Open);
            this.panel1.Controls.Add(this.tb_Ac);
            this.panel1.Location = new System.Drawing.Point(227, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 268);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(778, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_AccountNumber;
        private System.Windows.Forms.TextBox tb_Ac;
        private System.Windows.Forms.Button bt_Open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}