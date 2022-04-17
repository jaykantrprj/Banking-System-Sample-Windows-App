using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Speech.Synthesis;

namespace WindowsFormsApplication1
{
    public partial class MDIPage : Form
    {
        int s,m=0;
        private int childFormNumber = 0;

        public MDIPage()
        {
            InitializeComponent();
        }
        public MDIPage(int f)
        {
            InitializeComponent();
            s=f;
            if (s == 2)
            {
                m = 1;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void MDIPage_Load(object sender, EventArgs e)
        {
            
       
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newCustmorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer n = new NewCustomer();
            n.Show();
            n.MdiParent = this;
          
        }

        private void existingCustmorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExistingEmployee d = new ExistingEmployee();
           
            d.MdiParent = this;
            d.Show();
        }

        private void accountRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AccountRecord r = new AccountRecord();
            r.MdiParent = this;
            r.Show();
        }

        private void transictionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Transiction t = new Transiction();
            t.MdiParent = this;
            t.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
            
        }

        private void loginTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (m != 1)
            {
                MessageBox.Show("You are not autorized to access this record");
            }
            else
            {
                LoginRecord l = new LoginRecord();
                l.MdiParent = this;
                l.Show();
            }
            
        }

        private void employeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (m != 1)
            {
                MessageBox.Show(" You are not autorized to access this record");
            }
            else
            {

                EmployeeRecord emm = new EmployeeRecord();
                emm.MdiParent = this;
                emm.Show();

            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();

        }

        private void transectionWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (m == 1)
            {
                MessageBox.Show("You are not autorized to access this record");
            }
            else
            {
                Employee e5 = new Employee();
                e5.MdiParent = this;
                e5.Show();
            }
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank b = new Bank();
            b.MdiParent=this;
            b.Show();
        }

        private void devloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.MdiParent = this;
            a.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (m != 1)
            {
                MessageBox.Show("You are not autorized to access this record");
            }
            else
            {
                NewEmployee e5 = new NewEmployee();
                e5.MdiParent = this;
                e5.Show();
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void allEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m != 1)
            {
                MessageBox.Show("You are not autorized to access this record");
            }
            else
            {
               EmployeeRecord  e5 = new EmployeeRecord ();
                e5.MdiParent = this;
                e5.Show();
            }
        }

       private void myBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 f5 = new Form1();
            f5.MdiParent = this;
            f5.Show();
        }
    }
}
