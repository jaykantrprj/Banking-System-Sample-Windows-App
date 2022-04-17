namespace WindowsFormsApplication1
{
    partial class Transfer
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
            this.lb_Transfer = new System.Windows.Forms.Label();
            this.tb_Transfer = new System.Windows.Forms.TextBox();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DestinitionAcc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Transfer
            // 
            this.lb_Transfer.AutoSize = true;
            this.lb_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Transfer.Location = new System.Drawing.Point(12, 186);
            this.lb_Transfer.Name = "lb_Transfer";
            this.lb_Transfer.Size = new System.Drawing.Size(269, 25);
            this.lb_Transfer.TabIndex = 0;
            this.lb_Transfer.Text = "Enter Amount to transfer";
            // 
            // tb_Transfer
            // 
            this.tb_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Transfer.Location = new System.Drawing.Point(402, 180);
            this.tb_Transfer.Name = "tb_Transfer";
            this.tb_Transfer.Size = new System.Drawing.Size(201, 31);
            this.tb_Transfer.TabIndex = 1;
            // 
            // bt_Submit
            // 
            this.bt_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Submit.Location = new System.Drawing.Point(468, 303);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(95, 41);
            this.bt_Submit.TabIndex = 2;
            this.bt_Submit.Text = "&Submit";
            this.bt_Submit.UseVisualStyleBackColor = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Destinition Account Number";
            // 
            // tb_DestinitionAcc
            // 
            this.tb_DestinitionAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DestinitionAcc.Location = new System.Drawing.Point(402, 57);
            this.tb_DestinitionAcc.Name = "tb_DestinitionAcc";
            this.tb_DestinitionAcc.Size = new System.Drawing.Size(195, 31);
            this.tb_DestinitionAcc.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 462);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(648, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_DestinitionAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.tb_Transfer);
            this.Controls.Add(this.lb_Transfer);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Transfer;
        private System.Windows.Forms.TextBox tb_Transfer;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_DestinitionAcc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}