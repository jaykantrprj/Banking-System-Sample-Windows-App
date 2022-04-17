using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Speech.Synthesis;



namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        string S;
        int f1=0;
        public Login()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
            int i,f=0;
           
            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Login", con);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "Login");
            int a = ds.Tables["Login"].Rows.Count;
            
            
            for (i = 0; i < a; i++)
            {
           
                string user, pass;
                user = tb_Username.Text.Trim();
                pass = tb_Password.Text.Trim();
                string tempu = ds.Tables["Login"].Rows[i][0].ToString().Trim();
                string TEMPP = ds.Tables["Login"].Rows[i][1].ToString().Trim();

                if (user.Equals(tempu) && pass.Equals(TEMPP))
                {
                    f = 1;
                    f1 = f;
                    S = ds.Tables["Login"].Rows[i][0].ToString().Trim();
                    break;
                }
                
                else 
                {
                    f1= 0; 
                }
            }
            if (tb_Username .Text  == "admin" && tb_Password.Text == "jaykant.12345")
            {
                f = 2;
                f1 = f;
                
            }
            if (f1== 1)
            {
                if (tb_Captcha.Text == "83tsU")
                {


                    MDIPage md = new MDIPage(f1);
                    this.Hide();
                    md.Show();
                    

                  }
             
                else 
                {
                    tb_Username.Text = null;
                    tb_Password.Text = null;
                    tb_Captcha.Text = null;
                    MessageBox.Show("Please Enter Proper Captcha.");
                }
            }
            else if (f1== 2)
            {
                MDIPage md = new MDIPage(f1);
                this.Hide();
                md.Show();
              
                    
            }


            else
            {
                MessageBox.Show("Invalid Authentication", "Error", MessageBoxButtons.RetryCancel);
            }

        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            tb_Username.Text = null;
            tb_Password.Text = null;
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
         {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void lb_Password_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

    /*    private void button1_Click_2(object sender, EventArgs e)
        {

            int f = 0;
            int i;

            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Login", con);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "Login");
            int a = ds.Tables["Login"].Rows.Count;


            for (i = 0; i < a; i++)
            {

                string user, pass;
                user = tb_Username.Text.Trim();
                pass = tb_Password.Text.Trim();
                string tempu = ds.Tables["Login"].Rows[i][0].ToString().Trim();
                string TEMPP = ds.Tables["Login"].Rows[i][1].ToString().Trim();

                if (user.Equals(tempu) && pass.Equals(TEMPP))
                {
                    f = 1;
                    f1 = f;
                    S = ds.Tables["Login"].Rows[i][0].ToString().Trim(); ;
                    break;
                }
                else
                {
                    f = 0;
                    f1 = f;
                }
            }
            if (f == 1)
            {
                if (tb_Captcha.Text == "83tsU")
                {



                    MDIPage md = new MDIPage(f1);
                    this.Hide();
                    md.Show();
                    
                }

                else
                {
                    tb_Username.Text = null;
                    tb_Password.Text = null;
                    tb_Captcha.Text = null;
                    MessageBox.Show("Please Enter Proper Captcha.");
                }
            }
            else if (f == 2)
            {

                MDIPage md = new MDIPage(f1);
                this.Hide();
                md.Show();
                

 
            }
            else
            {
                MessageBox.Show("Invalid Authentication", "Error", MessageBoxButtons.RetryCancel);
            }
       
        }*/
    }
}
