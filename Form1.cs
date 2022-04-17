using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string url;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string s)
        {
            url = s;
            InitializeComponent();
            webBrowser1.Navigate(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            webBrowser1.Navigate(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Facebook_Click(object sender, EventArgs e)
        {
            timer1.Start();
            webBrowser1.Navigate("https://www.facebook.com/");
        }

        private void bt_Gmail_Click(object sender, EventArgs e)
        {
            timer1.Start();
            webBrowser1.Navigate("https://plus.google.com/104908203405786132287/posts");
        }

        private void bt_Youtube_Click(object sender, EventArgs e)
        {
            timer1.Start();
            webBrowser1.Navigate("https://www.youtube.com");
        }

        private void bt_Image_Click(object sender, EventArgs e)
        {
            timer1.Start();
            webBrowser1.Navigate("https://twitter.com/?lang=en");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            webBrowser1.Navigate("https://www.google.com");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
            webBrowser1.Navigate("https://www.google.com");
            timer1.Stop();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int s = 0;
            

            if (s > 30)
            {

                 label1.Visible = false;
                timer1.Stop();


            }
            else 
            {
                label1 .Visible = true;
                s=s+2;
            }
          

        }
    }
}
