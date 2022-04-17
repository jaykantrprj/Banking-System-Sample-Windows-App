namespace WindowsFormsApplication1
{
    partial class Deposit
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
            this.lb_EnterAmountToDeposit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Deposit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtp_Transiction = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_EnterAmountToDeposit
            // 
            this.lb_EnterAmountToDeposit.AutoSize = true;
            this.lb_EnterAmountToDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EnterAmountToDeposit.Location = new System.Drawing.Point(17, 32);
            this.lb_EnterAmountToDeposit.Name = "lb_EnterAmountToDeposit";
            this.lb_EnterAmountToDeposit.Size = new System.Drawing.Size(251, 24);
            this.lb_EnterAmountToDeposit.TabIndex = 0;
            this.lb_EnterAmountToDeposit.Text = "Enter Amount To Deposit ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.tb_Deposit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lb_EnterAmountToDeposit);
            this.panel1.Location = new System.Drawing.Point(85, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 235);
            this.panel1.TabIndex = 2;
            // 
            // tb_Deposit
            // 
            this.tb_Deposit.Location = new System.Drawing.Point(61, 95);
            this.tb_Deposit.Name = "tb_Deposit";
            this.tb_Deposit.Size = new System.Drawing.Size(168, 20);
            this.tb_Deposit.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.backToolStripMenuItem.Text = "Home";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // dtp_Transiction
            // 
            this.dtp_Transiction.Location = new System.Drawing.Point(114, 354);
            this.dtp_Transiction.Name = "dtp_Transiction";
            this.dtp_Transiction.Size = new System.Drawing.Size(200, 20);
            this.dtp_Transiction.TabIndex = 4;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 462);
            this.Controls.Add(this.dtp_Transiction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_EnterAmountToDeposit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_Deposit;
        private System.Windows.Forms.DateTimePicker dtp_Transiction;
    }
}