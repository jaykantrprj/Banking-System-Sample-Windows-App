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
    public partial class EmployeeWork : Form
    {
        string ac;
        public EmployeeWork()
        {
            InitializeComponent();
        }
        public EmployeeWork(string Name, string Ac)
        {
            InitializeComponent();
            int i;
            lb_Name.Text = Name;
            lb_Acno.Text = Ac;
            ac = Ac;
            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Account", con);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "Account");
            int a = ds.Tables["Account"].Rows.Count;


            for (i = 0; i < a; i++)
            {

                string accountnotemp;
                
                accountnotemp  = ds.Tables["Account"].Rows[i][0].ToString().Trim();
               
                if (accountnotemp.Trim()==ac.Trim() )
                {

                    lb_Balance.Text = ds.Tables["Account"].Rows[i][2].ToString().Trim();
                    lb_Atype.Text = ds.Tables["Account"].Rows[i][1].ToString().Trim();
                    break;
                    
                }

                else
                {
                }
            }
         


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExistingEmployee d = new ExistingEmployee();
            d.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee el = new Employee();
            this.Hide();
            el.Show();
            

            
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            
            u.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Employee a1=new Employee();
            this.Hide();
            a1.Show();
        }

        private void bt_Withdraw_Click(object sender, EventArgs e)
        {
            WithDraw wd = new WithDraw(ac);
            
            wd.Show();
       }

        private void bt_Deposit_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit(ac);
            this.Hide();
            d.Show();
        }

        private void bt_Transfer_Click(object sender, EventArgs e)
        {
            Transfer t=new Transfer(ac);
            t.Show();
        }

        private void EmployeeWork_Load(object sender, EventArgs e)
        {
            
           



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
