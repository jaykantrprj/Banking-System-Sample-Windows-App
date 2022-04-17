using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class WithDraw : Form
    {
        string Account1;
        public WithDraw()
        {
            InitializeComponent();
        }
         public WithDraw(string ac)
        {
            InitializeComponent();
             Account1 =ac;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            
            this.Hide();
           
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            int i,f=0; int temp = 0; int bal=0;
            // Entry on Account
            SqlCommand com;
            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Account", con);
            DataSet ds = new DataSet();
            con.Open();
            ds.Clear();
            da.Fill(ds, "Account");
            int a = ds.Tables["Account"].Rows.Count;


            for (i = 0; i < a; i++)
            {
                
                temp = Convert.ToInt32(tb_Submit.Text);
                //  pass = tb_Password.Text.Trim();
                string tempa = ds.Tables["Account"].Rows[i][0].ToString().Trim();
                //string TEMPP = ds.Tables["Login"].Rows[i][1].ToString().Trim();

                if (tempa == Account1)
                {
                    
                    bal = Convert.ToInt32(ds.Tables["Account"].Rows[i][2]);
                  
                   
                    bal = bal - temp;
                    if (Convert.ToInt32(bal) < 500 && Convert.ToInt32(temp )> 100000)
                    {
                        f = 1;
                        MessageBox.Show("Insuffisient Balance ");
                        break;
                    }
                    
                    
                    com = new SqlCommand("UPDATE Account SET Balance ='"+bal+"' Where AccountID ='"+Account1+"'",con);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(temp.ToString()+"  Is Withdrawen on Account Number: "+Account1 );
                    break;
                }
                
                    
            }
            if (f == 0)
            {
                //Entry on Transiction
                string ID = "Withdaraw";
                //Account
                //temp
                string EmployeeId = "xxxxx";
                string date = dateTimePicker1.Value.Date.ToString();
                //bal
                con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
                con.Open();
                com = new SqlCommand(@"INSERT INTO Transiction
                  (AccountID, TransictionId,
                  TransictionAmount, EmployeeID, 
                  TransictionDate, NewBalance)VALUES        
                   ('" + Account1.ToString() + "','" + ID.ToString() + "','" + temp.ToString() + "','" + EmployeeId.ToString() + "','" + date + "','" + bal.ToString() + "')", con);

                com.ExecuteNonQuery();
                con.Close();


                this.Hide();
                MessageBox.Show("Submit Successful.");

            }
        }

            
        


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void WithDraw_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        
    }
}

