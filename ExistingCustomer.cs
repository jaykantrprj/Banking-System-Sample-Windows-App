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
    public partial class ExistingEmployee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
        public ExistingEmployee()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee y = new Employee();
            this.Hide();
            y.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCBankDataSet.CstomerInfo' table. You can move, or remove it, as needed.
           // this.cstomerInfoTableAdapter.Fill(this.iCBankDataSet.CstomerInfo);
            this.WindowState = FormWindowState.Maximized;
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from   CstomerInfo ";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from   CstomerInfo where AccountID  like ('" + textBox1.Text + "%')";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from   CstomerInfo where CustomerFName  like ('" + textBox2.Text + "%')";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();

        }
    }
}
