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
    public partial class NewCustomer1 : Form
    {
        string Acno,N;
        public NewCustomer1()
        {
            InitializeComponent();
        }
        public NewCustomer1(string ac,string Name)
        {
            Acno = ac;
            N = Name;
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
            string Balance = tb_DepositAmount.Text;
            string Atype = "Current";
           SqlConnection  con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
           con.Open();
           SqlCommand  com = new SqlCommand(@"INSERT INTO Account
                             (Balance, AccountID, AccountType)
                              VALUES  ('"+Balance +"','"+Acno +"','"+Atype+"')", con);

            com.ExecuteNonQuery();
            con.Close();


            NewCustomer2  ew = new NewCustomer2(Acno,N,Atype,Balance );
            this.Hide();
            ew.Show();
        }
    }
}
