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
    public partial class Transfer : Form
    {
        string AccountID;
        public Transfer()
        {
            InitializeComponent();
        }
        public Transfer(string ac)
        {
            AccountID = ac;
            InitializeComponent();
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            int i,isource=0,idest=0, f = 0,f1=0,Destinitionbalance=0,TransferBalance,SourceBalance=0;
            string  actemp, acdestinition;
            string tempamt, bal;
            acdestinition = tb_DestinitionAcc.Text.Trim();
            SqlCommand com;
            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Account", con);
            
            DataSet ds = new DataSet();
            
            
            ds.Clear();
            da.Fill(ds, "Account");
            
            
            int a = ds.Tables["Account"].Rows.Count;
            
            acdestinition = tb_DestinitionAcc.Text.Trim();
           // try
           // {
                for (i = 0; i < a; i++)
                {
                    
                    actemp = ds.Tables["Account"].Rows[i][0].ToString().Trim();

                    if (AccountID == actemp)
                    {
                        SourceBalance = Convert.ToInt32(ds.Tables["Account"].Rows[i][2]);
                        
                                               
                    break;
                    }

                }

                for (i = 0; i < a; i++)
                {
                   
                    actemp = ds.Tables["Account"].Rows[i][0].ToString().Trim();
                  //  int bald  =Convert.ToInt32( ds.Tables["Account"].Rows[i][2]);
                    if (acdestinition == actemp)
                    {
                        Destinitionbalance=Convert.ToInt32 (ds.Tables["Account"].Rows[i][2]);
                        f = 1;
                        
                       
                        break;
                        
                    }

                }

                

                if (f == 1)
                {
                    TransferBalance = Convert.ToInt32(tb_Transfer .Text);
                    SourceBalance =SourceBalance- TransferBalance;
                    Destinitionbalance =Destinitionbalance+ TransferBalance;

                    if (TransferBalance < 100 )
                    {
                        f1 = 1;
                        MessageBox.Show("You can't Transfer Balance Less than 100");
                    }
                    else if (SourceBalance < 500)
                    {
                        MessageBox.Show("You Don't enough balance to transffer");
                    }
                    else
                    {

                        //

                        for (i = 0; i < a; i++)
                        {
                            // = tb_DestinitionAcc.Text.Trim();
                            actemp = ds.Tables["Account"].Rows[i][0].ToString().Trim();

                            if (AccountID == actemp)
                            {
                                com = new SqlCommand("UPDATE Account SET Balance ='" + SourceBalance + "' where AccountID='" + AccountID + "'", con);
                                com.ExecuteNonQuery();
                                //con.Close();
                                break;
                            }

                        }
                        for (i = 0; i < a; i++)
                        {
                            // = tb_DestinitionAcc.Text.Trim();
                            actemp = ds.Tables["Account"].Rows[i][0].ToString().Trim();

                            if (acdestinition == actemp)
                            {
                                com = new SqlCommand("UPDATE Account SET Balance ='" + Destinitionbalance + "' where AccountID='" + acdestinition + "'", con);
                                com.ExecuteNonQuery();
                                //con.Close();
                                break;
                            }

                        }

                        //
                        string ID = "Transffer";
                        //Account
                        //temp
                        string EmployeeId = "xxxxx";
                        string date = dateTimePicker1 .Value.ToString();
                        //bal
                        con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
                        con.Open();
                        com = new SqlCommand(@"INSERT INTO Transiction
                  (AccountID, TransictionId,
                  TransictionAmount, EmployeeID, 
                  TransictionDate, NewBalance)VALUES        
                   ('" + AccountID.ToString() + "','" + ID.ToString() + "','" + TransferBalance .ToString() + "','" + EmployeeId.ToString() + "','" + date + "','" + SourceBalance.ToString() + "')", con);

                        com.ExecuteNonQuery();
                        con.Close();






                        //
                    


                        MessageBox.Show(" "+TransferBalance+" Rupees is transffered from Account Number "+ AccountID+" TO Account Number Successfully !!! " +acdestinition  );
                    }
                    //
                }
                else
                {
                    MessageBox.Show("Destinition  Account not found");
                }
           // }
           // catch (Exception exce)
           // {
           //     MessageBox.Show("   "+exce);
            //}
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Money is not transffered");
        }
    }
}
