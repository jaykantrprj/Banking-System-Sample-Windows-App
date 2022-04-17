namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_Facebook = new System.Windows.Forms.Button();
            this.bt_Gmail = new System.Windows.Forms.Button();
            this.bt_Youtube = new System.Windows.Forms.Button();
            this.bt_Image = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 110);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(33, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(946, 554);
            this.webBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(675, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(651, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "https://www.google.co.in/";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_Facebook
            // 
            this.bt_Facebook.BackColor = System.Drawing.Color.White;
            this.bt_Facebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Facebook.ForeColor = System.Drawing.Color.Blue;
            this.bt_Facebook.Location = new System.Drawing.Point(14, 53);
            this.bt_Facebook.Margin = new System.Windows.Forms.Padding(5);
            this.bt_Facebook.Name = "bt_Facebook";
            this.bt_Facebook.Size = new System.Drawing.Size(116, 35);
            this.bt_Facebook.TabIndex = 3;
            this.bt_Facebook.Text = "Facebook";
            this.bt_Facebook.UseVisualStyleBackColor = false;
            this.bt_Facebook.Click += new System.EventHandler(this.bt_Facebook_Click);
            // 
            // bt_Gmail
            // 
            this.bt_Gmail.BackColor = System.Drawing.Color.White;
            this.bt_Gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Gmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Gmail.Location = new System.Drawing.Point(140, 53);
            this.bt_Gmail.Margin = new System.Windows.Forms.Padding(5);
            this.bt_Gmail.Name = "bt_Gmail";
            this.bt_Gmail.Size = new System.Drawing.Size(125, 35);
            this.bt_Gmail.TabIndex = 4;
            this.bt_Gmail.Text = "Gmail";
            this.bt_Gmail.UseVisualStyleBackColor = false;
            this.bt_Gmail.Click += new System.EventHandler(this.bt_Gmail_Click);
            // 
            // bt_Youtube
            // 
            this.bt_Youtube.BackColor = System.Drawing.Color.White;
            this.bt_Youtube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Youtube.ForeColor = System.Drawing.Color.Fuchsia;
            this.bt_Youtube.Location = new System.Drawing.Point(400, 53);
            this.bt_Youtube.Margin = new System.Windows.Forms.Padding(5);
            this.bt_Youtube.Name = "bt_Youtube";
            this.bt_Youtube.Size = new System.Drawing.Size(125, 35);
            this.bt_Youtube.TabIndex = 5;
            this.bt_Youtube.Text = "YouTube";
            this.bt_Youtube.UseVisualStyleBackColor = false;
            this.bt_Youtube.Click += new System.EventHandler(this.bt_Youtube_Click);
            // 
            // bt_Image
            // 
            this.bt_Image.BackColor = System.Drawing.Color.White;
            this.bt_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Image.Location = new System.Drawing.Point(540, 53);
            this.bt_Image.Margin = new System.Windows.Forms.Padding(5);
            this.bt_Image.Name = "bt_Image";
            this.bt_Image.Size = new System.Drawing.Size(125, 35);
            this.bt_Image.TabIndex = 6;
            this.bt_Image.Text = "Twitter";
            this.bt_Image.UseVisualStyleBackColor = false;
            this.bt_Image.Click += new System.EventHandler(this.bt_Image_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(275, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Google";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please Wait...";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(972, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_Image);
            this.Controls.Add(this.bt_Youtube);
            this.Controls.Add(this.bt_Gmail);
            this.Controls.Add(this.bt_Facebook);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "My Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_Facebook;
        private System.Windows.Forms.Button bt_Gmail;
        private System.Windows.Forms.Button bt_Youtube;
        private System.Windows.Forms.Button bt_Image;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

