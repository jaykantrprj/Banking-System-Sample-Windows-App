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
    public partial class LoginRecord : Form
    {
        public LoginRecord()
        {
            InitializeComponent();
        }

        private void LoginRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCBankDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.iCBankDataSet.Login);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
