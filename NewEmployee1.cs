using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NewEmployee1 : Form
    {
        string Name, Username, pass, Salary, Empid;
        public NewEmployee1()
        {
            InitializeComponent();
        }
        public NewEmployee1(string name,string empid,string username,string password,string salary)
        {
            InitializeComponent();
            Name = name;
            Empid = empid.ToString(); ;
            Username = username;
            pass = password;
            Salary = salary;
            lb_namedisp .Text = name;
            lb_userdisp .Text  = username;
            lb_passdisp.Text = password;
            lb_empid.Text = Empid;
            lb_salary.Text  = salary;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployee1_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("New Employee is not Added Successfully.");
        }

        private void bte1_Done_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
            MessageBox.Show("New Employee is Added Successfully");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
