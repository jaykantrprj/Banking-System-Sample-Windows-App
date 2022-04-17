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
    public partial class NewCust1 : Form
    {
        public NewCust1()
        {
            InitializeComponent();
        }
        

        private void NewCust1_Load(object sender, EventArgs e)
        {

        }
        string Acno,N,Atype;
        
        public NewCust1(int ac,string Name,string atype)
        {
            InitializeComponent();
            Acno = ac.ToString(); ;
            N = Name;
            Atype = atype;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCustomer n = new NewCustomer();
            n.Show();
            this.Hide();

        }

        private void NewCustomer1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee e4 = new Employee();
            this.Hide();
            e4.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Submit_Click_1(object sender, EventArgs e)
        {
            string Balance = tb_DepositAmount.Text;
            
            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(@"INSERT INTO Account
                             (Balance, AccountID, AccountType)
                              VALUES  ('" + Balance + "','" + Acno + "','" + Atype + "')", con);

            com.ExecuteNonQuery();
            con.Close();


            NewCustomer2 ew = new NewCustomer2(Acno,N,Atype,Balance );
            this.Hide();
            ew.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    
    }
}
