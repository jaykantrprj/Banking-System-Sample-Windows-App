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
    public partial class Employee : Form
    {
        string SID;
        public Employee()
        {
            InitializeComponent();
        }
        public Employee(string s)
        {
            InitializeComponent();
            SID = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, f=0;
            
            string ACPassing="xxxxxx";
            try
            {
            SqlConnection con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from CstomerInfo", con);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "CstomerInfo");
            int a = ds.Tables["CstomerInfo"].Rows.Count;
            
                for (i = 0; i < a; i++)
                {
                    string ac;

                    ac = tb_Ac.Text.Trim();
                    string actemp = ds.Tables["CstomerInfo"].Rows[i][1].ToString().Trim();

                    if (actemp.Equals(ac))
                    {
                        f = 1;
                        ACPassing = ds.Tables["CstomerInfo"].Rows[i][1].ToString().Trim();
                        break;
                    }
                    else
                    {
                        f = 0;
                    }
                }





                if (f == 1)
                {
                    string Fname, Lname, Mname, Name;



                    Fname = ds.Tables["CstomerInfo"].Rows[i][2].ToString().Trim();
                    Mname = ds.Tables["CstomerInfo"].Rows[i][3].ToString().Trim();
                    Lname = ds.Tables["CstomerInfo"].Rows[i][4].ToString().Trim();
                    Name = Fname + " " + Mname + " " + Lname;

                    EmployeeWork ew = new EmployeeWork(Name, ACPassing);
                    this.Hide();
                    ew.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Proper A/c ");
                }
            }
            catch (Exception  em)
            {
                MessageBox.Show("Exception");
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newCustmorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer n = new NewCustomer();
            n.Show();
            this.Hide();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void existingCustmorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExistingEmployee d = new ExistingEmployee();
            this.Hide();
            d.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            int i;
            this.WindowState = FormWindowState.Maximized;
            SqlConnection con = new SqlConnection("Data Source=Ironique_Z-PC;Initial Catalog=DataBank;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from StaffLogin", con);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "StaffLogin");
            int a = ds.Tables["StaffLogin"].Rows.Count;
            for (i = 0; i < a; i++)
            {
                string id;

                id = ds.Tables["StaffLogin"].Rows[i][0].ToString().Trim();


                if (id == SID)
                {
                    string n = ds.Tables["StaffLogin"].Rows[i][1].ToString().Trim();
                   // lb_Name.Text=n;
                    //lb_EmpID.Text=SID;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void accountRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountRecord r = new AccountRecord();
            r.Show();
        }

        private void transictionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transiction t = new Transiction();
            t.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void internetExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shutdown");

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginRecord l = new LoginRecord();
            l.Show();
        }

        private void employeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRecord er = new EmployeeRecord();
            er.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void custmorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
