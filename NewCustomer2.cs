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
    public partial class NewCustomer2 : Form
    {
        string Namethis, acthis, Atypethis,Balancethis;
        public NewCustomer2()
        {
            InitializeComponent();
        }
        public NewCustomer2(string ac,string Name,string Atype,string Bal) 
        {
            InitializeComponent();
            Namethis = Name;
            acthis = ac;
            Atypethis = Atype;
            Balancethis=Bal;
            
        }

        private void NewCustomer2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lb_NameDisplay.Text = Namethis;
            lb_BalanceDisplay.Text = Balancethis;
            lb_AcnDisplay.Text = Atypethis;
            lb_AtypeDisplay .Text = acthis;

        }

        private void bt_Done_Click(object sender, EventArgs e)
        {
            this.Hide();
           

        }

        private void label4_Click(object sender, EventArgs e)
        {
            

                    
        }
    }
}
