namespace WindowsFormsApplication1
{
    partial class NewEmployee1
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
            this.lbe_Name = new System.Windows.Forms.Label();
            this.lbe1_Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_namedisp = new System.Windows.Forms.Label();
            this.lb_empid = new System.Windows.Forms.Label();
            this.lb_userdisp = new System.Windows.Forms.Label();
            this.lb_passdisp = new System.Windows.Forms.Label();
            this.bte1_Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_salary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbe_Name
            // 
            this.lbe_Name.AutoSize = true;
            this.lbe_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbe_Name.Location = new System.Drawing.Point(85, 110);
            this.lbe_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbe_Name.Name = "lbe_Name";
            this.lbe_Name.Size = new System.Drawing.Size(48, 18);
            this.lbe_Name.TabIndex = 1;
            this.lbe_Name.Text = "Name";
            this.lbe_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbe1_Username
            // 
            this.lbe1_Username.AutoSize = true;
            this.lbe1_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbe1_Username.Location = new System.Drawing.Point(85, 219);
            this.lbe1_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbe1_Username.Name = "lbe1_Username";
            this.lbe1_Username.Size = new System.Drawing.Size(77, 18);
            this.lbe1_Username.TabIndex = 2;
            this.lbe1_Username.Text = "Username";
            this.lbe1_Username.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "EmployeeId";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lb_namedisp
            // 
            this.lb_namedisp.AutoSize = true;
            this.lb_namedisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namedisp.Location = new System.Drawing.Point(359, 110);
            this.lb_namedisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_namedisp.Name = "lb_namedisp";
            this.lb_namedisp.Size = new System.Drawing.Size(46, 18);
            this.lb_namedisp.TabIndex = 5;
            this.lb_namedisp.Text = "label5";
            // 
            // lb_empid
            // 
            this.lb_empid.AutoSize = true;
            this.lb_empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empid.Location = new System.Drawing.Point(359, 159);
            this.lb_empid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_empid.Name = "lb_empid";
            this.lb_empid.Size = new System.Drawing.Size(11, 18);
            this.lb_empid.TabIndex = 6;
            this.lb_empid.Text = "l";
            // 
            // lb_userdisp
            // 
            this.lb_userdisp.AutoSize = true;
            this.lb_userdisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userdisp.Location = new System.Drawing.Point(359, 219);
            this.lb_userdisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_userdisp.Name = "lb_userdisp";
            this.lb_userdisp.Size = new System.Drawing.Size(46, 18);
            this.lb_userdisp.TabIndex = 7;
            this.lb_userdisp.Text = "label7";
            this.lb_userdisp.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_passdisp
            // 
            this.lb_passdisp.AutoSize = true;
            this.lb_passdisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passdisp.Location = new System.Drawing.Point(359, 287);
            this.lb_passdisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_passdisp.Name = "lb_passdisp";
            this.lb_passdisp.Size = new System.Drawing.Size(46, 18);
            this.lb_passdisp.TabIndex = 8;
            this.lb_passdisp.Text = "label1";
            this.lb_passdisp.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bte1_Done
            // 
            this.bte1_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bte1_Done.Location = new System.Drawing.Point(758, 565);
            this.bte1_Done.Margin = new System.Windows.Forms.Padding(4);
            this.bte1_Done.Name = "bte1_Done";
            this.bte1_Done.Size = new System.Drawing.Size(228, 82);
            this.bte1_Done.TabIndex = 9;
            this.bte1_Done.Text = "Done";
            this.bte1_Done.UseVisualStyleBackColor = true;
            this.bte1_Done.Click += new System.EventHandler(this.bte1_Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salary";
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salary.Location = new System.Drawing.Point(359, 355);
            this.lb_salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(75, 18);
            this.lb_salary.TabIndex = 11;
            this.lb_salary.Text = "Password";
            // 
            // NewEmployee1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.lb_salary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bte1_Done);
            this.Controls.Add(this.lb_passdisp);
            this.Controls.Add(this.lb_userdisp);
            this.Controls.Add(this.lb_empid);
            this.Controls.Add(this.lb_namedisp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbe1_Username);
            this.Controls.Add(this.lbe_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewEmployee1";
            this.Text = "NewEmployee1";
            this.Load += new System.EventHandler(this.NewEmployee1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbe_Name;
        private System.Windows.Forms.Label lbe1_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_namedisp;
        private System.Windows.Forms.Label lb_empid;
        private System.Windows.Forms.Label lb_userdisp;
        private System.Windows.Forms.Label lb_passdisp;
        private System.Windows.Forms.Button bte1_Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_salary;
    }
}