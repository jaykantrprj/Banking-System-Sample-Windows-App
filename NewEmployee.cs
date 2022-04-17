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
    public partial class NewEmployee : Form
    {

        SqlCommand com;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        int Allowprocced = 0;

        int  FlagCustomerID = 0, a;
        int ac =0, CustId =0;

        public NewEmployee()
        {
            InitializeComponent();
        }
        public void clear()
        {
            // tb_Accountnumber.Text = null;
            tb_City.Text = null;
            tb_ContactNumber.Text = null;
            tb_Correspondence.Text = null;
            //tb_CustomerID.Text = null;
            tb_EmailAddress.Text = null;
            tb_FirstName.Text = null;
            tb_LastName.Text = null;
            tb_MidelName.Text = null;
            tb_Permanant.Text = null;
            tb_Pincode.Text = null;
            tb_State.Text = null;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("select * from EmployeeInfo", con);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "EmployeeInfo");
            a = ds.Tables["EmployeeInfo"].Rows.Count;
            if (a == 0)
            {
               FlagCustomerID = 0;
            }
            else
            {
                FlagCustomerID =1;
            }
            if (a == 0)
            {
                CustId = 21420001;
                tb_EmployeeID.Text = CustId.ToString().Trim();
            
               
                
            }
            else 
            {
                int Custidtemp = Convert.ToInt32(ds.Tables["EmployeeInfo"].Rows[a - 1][0]);
               // int Accountidtemp = Convert.ToInt32(ds.Tables["CstomerInfo"].Rows[a - 1][1]);
                Custidtemp++;
                //Accountidtemp++;
                CustId = Custidtemp;
                tb_EmployeeID.Text = CustId .ToString().Trim();
               

            }

            //MessageBox.Show("   " +CustId );
            tb_EmployeeID.Enabled = false;
            
            this.WindowState = FormWindowState.Maximized;
  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bte_Proceed_Click(object sender, EventArgs e)
        {
            NewEmployee1 ne = new NewEmployee1();
            ne.MdiParent = this;
            ne.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("select * from EmployeeInfo", con);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "EmployeeInfo");
            a = ds.Tables["EmployeeInfo"].Rows.Count;


            int state = 0;
            if (tb_ContactNumber.TextLength == 1 || tb_ContactNumber.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper contact number", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }

            if (tb_City.TextLength == 1 || tb_City.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper City name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }


            if (tb_Correspondence.TextLength == 1 || tb_Correspondence.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper Coressponadance address name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }

            if (tb_EmailAddress.TextLength == 1 || tb_EmailAddress.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper Email");
            }
            else
            {
                state++;
            }

            if (tb_FirstName.TextLength == 1 || tb_FirstName.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper First name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }


            if (tb_LastName.TextLength == 1 || tb_LastName.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper Last name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }


            if (tb_MidelName.TextLength == 1 || tb_MidelName.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper Midel name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }

            if (tb_Permanant.TextLength == 1 || tb_Permanant.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper permanet address", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }

            if (tb_Pincode.TextLength == 1 || tb_Pincode.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper Pincode", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }


            if (tb_State.TextLength == 1 || tb_State.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper state name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }

            if (tb_salary.TextLength ==0 )
            {
                MessageBox.Show("Please enter the salary it is important", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                state++;
            }
            //
            if (state == 11)
            {
                MessageBox.Show("Save Succssed");
                Allowprocced = 1;

            }
            


            
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            string FName, MName, LName, PerAdd, CorAdd;
            string City, State, Pincode, Email;
            string dd, mm, yy, date, Contact, Gen, OpeningDate;
            string Atype, Name, Username, Password,id;



            if (Allowprocced == 1)
            {
                id = CustId.ToString(); 
                FName = tb_FirstName.Text;
                
                Username = id.Trim();
                Password = "jay12345".Trim();
                MName = tb_MidelName.Text;
                LName = tb_LastName.Text;
                PerAdd = tb_Permanant.Text;
                CorAdd = tb_Correspondence.Text;
                City = tb_City.Text;
                State = tb_State.Text;
                Pincode = tb_Pincode.Text;
                Email = tb_EmailAddress.Text;
                Contact = tb_ContactNumber.Text;
                dd = cb_DD.Text;
                mm = CB_MM.Text;
                yy = CB_YY.Text;
                date = dd + "/" + mm + "/" + yy;
                Gen = cb_Gender.Text;
                OpeningDate = DTP_Openingdate.Value.ToString();
                Atype = cb_Atype.Text;
                Name = FName + " " + MName + " " + LName;
                //Verification






                // try
                //{

                //CustomerInfo Entery
                con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
                con.Open();
                //try
                //{
                com = new SqlCommand(@"INSERT INTO EmployeeInfo
                         (EmployeeID, EmployeeFName, EmployeeMName,
                          EmployeeLName,EmpPerAdd, EmpCorAdd, City,
                         State, Pincode, Contact, Gender, DOB,
                         EmpOpeningDate,  Password, Email, Username,Salary)
                      VALUES      
              ('"+id+"','"+FName +"','"+MName +"','"+LName +"','"+PerAdd +"','"+CorAdd +"','"+City +"','"+State +"','"+Pincode +"','"+Contact +"','"+Gen +"','"+date +"','"+OpeningDate +"','"+Password+"','"+Email +"','"+id +"','"+tb_salary .Text +"')", con);

                com.ExecuteNonQuery();
                com = new SqlCommand(@"INSERT INTO Login (CostumerID,Password ) VALUES('" + Username + "','" + Password + "')", con);
                com.ExecuteNonQuery();
                con.Close();
                // }
                //catch (SqlException se1)
                //{
                //  MessageBox.Show("Please Enter CustomerId numeric only","Error",MessageBoxButtons.OKCancel); 
                //}




                NewEmployee1 ne = new NewEmployee1(Name,id.ToString() ,Username ,Password ,tb_salary.Text);
                this.Hide();
                ne.Show();
            }
            else
            {
                MessageBox.Show("Please Save Data First");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("New employee is not added successfully .");
        }

        private void tb_salary_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tb_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
             int l = tb_salary.TextLength, f = 0;



            if (l >= 6)
            {
                MessageBox.Show("Please enter salary<999999");
                tb_Permanant.Text = "";
                f = 1;
            }
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                tb_Pincode.Text = "";
                MessageBox.Show("Please Enter Digit Only.");
                f = 1;

            }

            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_LastName.TextLength, f = 0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                tb_LastName.Text = "";
                MessageBox.Show("Please Enter Alphabets Only.");
                f = 1;
            }
            if (l > 20)
            {
                MessageBox.Show("Your name is too longer");
                tb_LastName.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_MidelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_LastName.TextLength, f = 0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                tb_LastName.Text = "";
                MessageBox.Show("Please Enter Alphabets Only.");
                f = 1;
            }
            if (l > 20)
            {
                MessageBox.Show("Your name is too longer");
                tb_LastName.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_LastName.TextLength, f = 0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                tb_LastName.Text = "";
                MessageBox.Show("Please Enter Alphabets Only.");
                f = 1;
            }
            if (l > 20)
            {
                MessageBox.Show("Your name is too longer");
                tb_LastName.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_Correspondence_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_Correspondence.TextLength, f = 0;



            if (l > 60)
            {
                MessageBox.Show("Your correspondance Address is too longer");
                tb_LastName.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }

        }

        private void tb_Permanant_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_Correspondence.TextLength, f = 0;



            if (l > 60)
            {
                MessageBox.Show("Your correspondance Address is too longer");
                tb_LastName.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }

        }

        private void tb_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_City.TextLength, f = 0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                tb_City.Text = "";
                MessageBox.Show("Please Enter Alphabets Only.");
                f = 1;
            }
            if (l > 20)
            {
                MessageBox.Show("Your City name is too longer");
                tb_City.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_State_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_State.TextLength, f = 0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                tb_State.Text = "";
                MessageBox.Show("Please Enter Alphabets Only.");
                f = 1;

            }
            if (l > 20)
            {
                MessageBox.Show("Your State name is too longer");
                tb_State.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_ContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_ContactNumber.TextLength, f = 0;


            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                tb_ContactNumber.Text = "";
                MessageBox.Show("Please Enter Digit Only.");
                f = 1;

            }
            if (l > 9)
            {
                MessageBox.Show("Invalid Mobile Number [More than 6 digit]");
                tb_ContactNumber.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_Pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_Pincode.TextLength, f = 0;


            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                tb_Pincode.Text = "";
                MessageBox.Show("Please Enter Digit Only.");
                f = 1;

            }
            if (l > 5)
            {
                MessageBox.Show("Invalid Pincode [More than 6 digit]");
                tb_Pincode.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_EmailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_EmailAddress.TextLength, f = 0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '@' || e.KeyChar == '.'))
            {
                tb_EmailAddress.Text = "";
                MessageBox.Show("Don't enter other characters please.");
                f = 1;
            }
            if (l > 60)
            {
                MessageBox.Show("Your Email address is too longer");
                tb_EmailAddress.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }
    }
}
