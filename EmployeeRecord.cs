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
    public partial class EmployeeRecord : Form
    {
        SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
        public EmployeeRecord()
        {
            InitializeComponent();
        }

        private void EmployeeRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCBankDataSet2.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter2.Fill(this.iCBankDataSet2.EmployeeInfo);
            // TODO: This line of code loads data into the 'iCBankDataSet11.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter1.Fill(this.iCBankDataSet11.EmployeeInfo);
            // TODO: This line of code loads data into the 'iCBankDataSet1.EmployeeInfo' table. You can move, or remove it, as needed.
          //  this.employeeInfoTableAdapter.Fill(this.iCBankDataSet1.EmployeeInfo);

            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from  EmployeeInfo ";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from  EmployeeInfo where EmployeeFName  like ('" + textBox2.Text + "%')";
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
            com.CommandText = "select * from  EmployeeInfo where EmployeeID  like ('" + textBox1.Text + "%')";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }
    }
}
