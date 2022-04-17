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
    public partial class NewCustomer : Form
    {
        //Global Declaration
        SqlCommand com;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        int Allowprocced = 0;
        
        int FlagAccontID = 0, FlagCustomerID = 0,a;
        int ac = 0, CustId = 0;

        //
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

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            //int f = 0;
            string FName, MName, LName, PerAdd, CorAdd;
            string City, State, Pincode, Email;
            string dd, mm, yy, date, Contact,Gen,OpeningDate;
            string Atype, Name;
            
            

           if(Allowprocced==1)
           {
               
                FName = tb_FirstName.Text;
                MName = tb_MidelName.Text;
                LName = tb_LastName.Text;
                PerAdd = tb_Permanant.Text;
                CorAdd = tb_Correspondence.Text;
                City = tb_City.Text;
                State = tb_State.Text;
                Pincode = tb_Pincode.Text;
                Email = tb_EmailAddress.Text;
                Contact = tb_ContactNumber.Text;
                
                //date = dd + "/" + mm + "/" + yy;
                date = DTP_Openingdate.Text;
                MessageBox.Show("  "+date);
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
                    com = new SqlCommand(@"INSERT INTO CstomerInfo (CustomerId, AccountID,
                                 CustomerFName, CustomerMName, CustomerLName, CustomerPermanentAdd,
                                 CustomerCAddress, City, Pincode, State, Email, Contact, 
                                 DOB, Gender, OpeningDate)
                                 VALUES('" + CustId.ToString() + "','" + ac.ToString() + "','" + FName + "','" + MName + "','" + LName + "','" + PerAdd + "','" + CorAdd + "','" + City + "','" + Pincode + "','" + State + "','" + Email + "','" + Contact + "','" + date + "','" + Gen + "','" + OpeningDate + "')", con);

                    com.ExecuteNonQuery();
                    con.Close();
               // }
                //catch (SqlException se1)
                //{
                  //  MessageBox.Show("Please Enter CustomerId numeric only","Error",MessageBoxButtons.OKCancel); 
                //}

               


                NewCust1  jay= new NewCust1(ac,Name,Atype);
                this.Hide();
                jay.Show();
           }
           else
           {
               MessageBox.Show("Please Save Data First");
           }
               

          // }
           // catch (Exception  se)
           // {
             //   MessageBox.Show("Please Enter all the fields ","Error",MessageBoxButtons.RetryCancel );
            //}
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Employee e3 = new Employee();
            this.Hide();
            e3.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeFOrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee e2 = new Employee();
            this.Hide();
                e2.Show();
            MessageBox.Show("New Account is not Created.");
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=IRONIQUE_Z-PC;Initial Catalog=ICBank;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("select * from CstomerInfo", con);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds,"CstomerInfo");
            a = ds.Tables["CstomerInfo"].Rows.Count;
            if (a == 0)
            {
                FlagAccontID = FlagCustomerID = 0;
            }
            else
            {
                FlagCustomerID = FlagAccontID = 1;
            }
            if (FlagAccontID == 0 && FlagCustomerID == 0)
            {
                ac = 201501;
                CustId = 1230001;
                tb_Accountnumber.Text = ac.ToString().Trim();
                tb_CustomerID.Text = Convert.ToString(CustId).Trim();
                tb_Accountnumber.Enabled = false;
                
                tb_CustomerID.Enabled = false;
              

            }
            else
            {
                int Custidtemp = Convert.ToInt32(ds.Tables["CstomerInfo"].Rows[a - 1][0]);
                int Accountidtemp = Convert.ToInt32(ds.Tables["CstomerInfo"].Rows[a - 1][1]);
                Custidtemp++;
                CustId = Custidtemp ;
                Accountidtemp++;
                ac = Accountidtemp;
                tb_CustomerID.Text = Custidtemp.ToString().Trim();
                tb_Accountnumber.Text = Accountidtemp.ToString().Trim();

            }


            tb_CustomerID.Enabled = false;
            tb_Accountnumber.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_MM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            int state=0;
            if (tb_ContactNumber.TextLength == 1 ||tb_ContactNumber.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper contact number", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
              state++;
            }
            
                if (tb_City.TextLength == 1 ||tb_City.TextLength == 0 )
            {
                MessageBox.Show("Please enter the proper City name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
              state++;
            }

            
                if (tb_Correspondence.TextLength == 1 ||tb_Correspondence.TextLength == 0 )
            {
                MessageBox.Show("Please enter the proper Coressponadance address name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
              state++;
            }

                 if (tb_EmailAddress.TextLength == 1 ||tb_EmailAddress.TextLength == 0)
            {
                MessageBox.Show("Please enter the proper Email");
            }
            else
            {
              state++;
            }

               if (tb_FirstName.TextLength == 1||tb_FirstName.TextLength ==0 )
            {
                MessageBox.Show("Please enter the proper First name", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
              state++;
            }

            
               if (tb_LastName.TextLength == 1 || tb_LastName.TextLength == 0 )
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
            //
             if (state == 10)
             {
                 MessageBox.Show("Save Succssed");
                 Allowprocced = 1;

             }
             

        }

        private void tb_Accountnumber_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Accountnumber .Enabled = false;
            tb_CustomerID.Enabled = false;

        }

        private void tb_CustomerID_MouseClick(object sender, MouseEventArgs e)
        {
            tb_CustomerID .Enabled = false;
            tb_Accountnumber.Enabled = false;
        }

        private void tb_Accountnumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_FirstName.TextLength,f=0;
           
            
                if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')||e.KeyChar==8))
                {
                    tb_FirstName.Text = "";
                    MessageBox.Show("Please Enter Alphabets Only.");
                    f = 1;
                }
                if (l > 20)
                {
                    MessageBox.Show("Your name is too longer");
                    tb_FirstName.Text = "";
                    f = 1;
                }
                if (f == 1)
                {
                    tb_Pincode.Clear();

                }
            
            
        }

        private void tb_MidelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_MidelName.TextLength,f=0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8))
            {
                tb_MidelName.Text = "";
                MessageBox.Show("Please Enter Alphabets Only.");
                f = 1;
            }
            if (l > 20)
            {
                MessageBox.Show("Your name is too longer");
                tb_MidelName.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_LastName.TextLength,f=0;


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

        private void tb_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_City.TextLength,f=0;


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
            int l = tb_State.TextLength,f=0;


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

        private void tb_Pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_Pincode.TextLength,f=0;

           
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9')  || e.KeyChar == 8))
            {
                tb_Pincode.Text = "";
                MessageBox.Show("Please Enter Digit Only.");
                f = 1;

            }
            if (l > 5)
            {
                MessageBox.Show("Invalid Pincode [More than 6 digit]");
                tb_Pincode.Text  = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();
              
            }
        }

        private void tb_ContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_ContactNumber.TextLength,f=0;


            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                tb_ContactNumber .Text = "";
                MessageBox.Show("Please Enter Digit Only.");
                f = 1;

            }
            if (l > 9)
            {
                MessageBox.Show("Invalid Mobile Number [More than 6 digit]");
                tb_ContactNumber.Text ="";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }
        }

        private void tb_EmailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_EmailAddress .TextLength,f=0;


            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')||(e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '@' || e.KeyChar == '.'))
            {
                tb_EmailAddress .Text = "";
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

        private void tb_Correspondence_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = tb_Correspondence .TextLength, f = 0;


            
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
            int l = tb_Permanant.TextLength, f = 0;



            if (l > 60)
            {
                MessageBox.Show("Your permanent Address is too longer");
                tb_Permanant.Text = "";
                f = 1;
            }
            if (f == 1)
            {
                tb_Pincode.Clear();

            }

        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("New customer is not added");
        }
    }
}
