namespace WindowsFormsApplication1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Captcha = new System.Windows.Forms.TextBox();
            this.lb_Captcha = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.lb_Username = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.bt_Exit, "bt_Exit");
            this.bt_Exit.ForeColor = System.Drawing.Color.White;
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tb_Captcha);
            this.panel1.Controls.Add(this.lb_Captcha);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_Reset);
            this.panel1.Controls.Add(this.lb_Username);
            this.panel1.Controls.Add(this.bt_Login);
            this.panel1.Controls.Add(this.tb_Password);
            this.panel1.Controls.Add(this.lb_Password);
            this.panel1.Controls.Add(this.tb_Username);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tb_Captcha
            // 
            this.tb_Captcha.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tb_Captcha, "tb_Captcha");
            this.tb_Captcha.Name = "tb_Captcha";
            // 
            // lb_Captcha
            // 
            resources.ApplyResources(this.lb_Captcha, "lb_Captcha");
            this.lb_Captcha.BackColor = System.Drawing.Color.White;
            this.lb_Captcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Captcha.Name = "lb_Captcha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Captcha;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.images__3_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.images__3_;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bt_Reset, "bt_Reset");
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // lb_Username
            // 
            resources.ApplyResources(this.lb_Username, "lb_Username");
            this.lb_Username.BackColor = System.Drawing.Color.White;
            this.lb_Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Username.Name = "lb_Username";
            // 
            // bt_Login
            // 
            this.bt_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bt_Login, "bt_Login");
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tb_Password, "tb_Password");
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // lb_Password
            // 
            resources.ApplyResources(this.lb_Password, "lb_Password");
            this.lb_Password.BackColor = System.Drawing.Color.White;
            this.lb_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Click += new System.EventHandler(this.lb_Password_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tb_Username, "tb_Username");
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Untitled1;
            this.CancelButton = this.bt_Exit;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Exit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_Captcha;
        private System.Windows.Forms.Label lb_Captcha;
        private System.Windows.Forms.Panel panel2;
    }
}

