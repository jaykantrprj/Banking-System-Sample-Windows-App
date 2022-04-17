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
    public partial class AccountRecord : Form
    {
        public AccountRecord()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCBankDataSet4.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter2.Fill(this.iCBankDataSet4.Account);
            // TODO: This line of code loads data into the 'iCBankDataSet1.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter1.Fill(this.iCBankDataSet1.Account);
            // TODO: This line of code loads data into the 'iCBankDataSet.Account' table. You can move, or remove it, as needed.
           // this.accountTableAdapter.Fill(this.iCBankDataSet.Account);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
