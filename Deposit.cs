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
    public partial class Deposit : Form
    {
        string Account1;
        public Deposit()
        {
            InitializeComponent();
        }
        public Deposit(string ac)
        {
            InitializeComponent();
            Account1=ac;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tb_Deposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i; int temp = 0; int bal=0;
            // Entry on Account
            SqlCommand com;
            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Account", con);
            DataSet ds = new DataSet();
            con.Open();
            ds.Clear();
            da.Fill(ds, "Account");
            int a = ds.Tables["Account"].Rows.Count;
            temp = Convert.ToInt32(tb_Deposit.Text);
            if (temp <= 1000000)
            {
                for (i = 0; i < a; i++)
                {


                    //  pass = tb_Password.Text.Trim();
                    string tempa = ds.Tables["Account"].Rows[i][0].ToString().Trim();
                    //string TEMPP = ds.Tables["Login"].Rows[i][1].ToString().Trim();

                    if (tempa == Account1)
                    {

                        bal = Convert.ToInt32(ds.Tables["Account"].Rows[i][2]);

                        bal = bal + temp;

                        com = new SqlCommand("UPDATE Account SET Balance ='" + bal + "' Where AccountID='"+Account1+"'", con);
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(temp.ToString() + "  Is Deposited on Account Number: " + Account1);
                        break;
                    }


                }
                //Entry on Transiction
                string ID = "Deposit";
                //Account
                //temp
                string EmployeeId = "xxxxx";
                string date = dtp_Transiction.Value.Date.ToString();
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




                //
                this.Hide();
                Employee e4 = new Employee();
                e4.Show();
            }
            else 
            {

                MessageBox.Show("You Can't Deposite this much of ammount ,Please contact to Manager");
            }
        }
    }
}
