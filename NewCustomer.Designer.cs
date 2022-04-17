namespace WindowsFormsApplication1
{
    partial class NewCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.lb_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Proceed = new System.Windows.Forms.Button();
            this.lb_PersonalDetails = new System.Windows.Forms.Label();
            this.tb_MidelName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.lb_DateOfBirth = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lb_ContactNumber = new System.Windows.Forms.Label();
            this.tb_ContactNumber = new System.Windows.Forms.TextBox();
            this.tb_EmailAddress = new System.Windows.Forms.TextBox();
            this.lb_EmailAddress = new System.Windows.Forms.Label();
            this.lb_Correspondence = new System.Windows.Forms.Label();
            this.lb_Permanant = new System.Windows.Forms.Label();
            this.tb_Permanant = new System.Windows.Forms.TextBox();
            this.tb_Correspondence = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_Atype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Accountnumber = new System.Windows.Forms.TextBox();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_Openingdate = new System.Windows.Forms.DateTimePicker();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_State = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Pincode = new System.Windows.Forms.TextBox();
            this.tb_State = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.lb_Pincode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CustomerID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Reset
            // 
            this.bt_Reset.Location = new System.Drawing.Point(697, 12);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(125, 32);
            this.bt_Reset.TabIndex = 0;
            this.bt_Reset.Text = "&Proceed";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(11, 38);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(60, 20);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Name:";
            this.lb_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bt_Save);
            this.panel1.Controls.Add(this.bt_Proceed);
            this.panel1.Controls.Add(this.bt_Reset);
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 54);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(599, 12);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(90, 31);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Proceed
            // 
            this.bt_Proceed.Location = new System.Drawing.Point(88, 11);
            this.bt_Proceed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_Proceed.Name = "bt_Proceed";
            this.bt_Proceed.Size = new System.Drawing.Size(125, 32);
            this.bt_Proceed.TabIndex = 1;
            this.bt_Proceed.Text = "&Reset";
            this.bt_Proceed.UseVisualStyleBackColor = true;
            this.bt_Proceed.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // lb_PersonalDetails
            // 
            this.lb_PersonalDetails.AutoSize = true;
            this.lb_PersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PersonalDetails.Location = new System.Drawing.Point(12, 24);
            this.lb_PersonalDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_PersonalDetails.Name = "lb_PersonalDetails";
            this.lb_PersonalDetails.Size = new System.Drawing.Size(160, 24);
            this.lb_PersonalDetails.TabIndex = 13;
            this.lb_PersonalDetails.Text = "Personal Details";
            // 
            // tb_MidelName
            // 
            this.tb_MidelName.Location = new System.Drawing.Point(343, 44);
            this.tb_MidelName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_MidelName.Name = "tb_MidelName";
            this.tb_MidelName.Size = new System.Drawing.Size(201, 24);
            this.tb_MidelName.TabIndex = 2;
            this.tb_MidelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MidelName_KeyPress);
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(100, 40);
            this.tb_FirstName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(232, 24);
            this.tb_FirstName.TabIndex = 3;
            this.tb_FirstName.TextChanged += new System.EventHandler(this.tb_FirstName_TextChanged);
            this.tb_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_FirstName_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(82, 26);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.dToolStripMenuItem.Text = "d";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(575, 44);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(226, 24);
            this.tb_LastName.TabIndex = 20;
            this.tb_LastName.TextChanged += new System.EventHandler(this.tb_LastName_TextChanged);
            this.tb_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_LastName_KeyPress);
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DateOfBirth.Location = new System.Drawing.Point(12, 91);
            this.lb_DateOfBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(111, 18);
            this.lb_DateOfBirth.TabIndex = 21;
            this.lb_DateOfBirth.Text = "Date Of Birth:";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(555, 100);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(68, 18);
            this.lb_Gender.TabIndex = 24;
            this.lb_Gender.Text = "Gender:";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lb_ContactNumber
            // 
            this.lb_ContactNumber.AutoSize = true;
            this.lb_ContactNumber.Location = new System.Drawing.Point(8, 178);
            this.lb_ContactNumber.Name = "lb_ContactNumber";
            this.lb_ContactNumber.Size = new System.Drawing.Size(136, 18);
            this.lb_ContactNumber.TabIndex = 36;
            this.lb_ContactNumber.Text = "Contact Number:";
            // 
            // tb_ContactNumber
            // 
            this.tb_ContactNumber.Location = new System.Drawing.Point(153, 178);
            this.tb_ContactNumber.Name = "tb_ContactNumber";
            this.tb_ContactNumber.Size = new System.Drawing.Size(161, 24);
            this.tb_ContactNumber.TabIndex = 34;
            this.tb_ContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNumber_KeyPress);
            // 
            // tb_EmailAddress
            // 
            this.tb_EmailAddress.Location = new System.Drawing.Point(528, 184);
            this.tb_EmailAddress.Name = "tb_EmailAddress";
            this.tb_EmailAddress.Size = new System.Drawing.Size(240, 24);
            this.tb_EmailAddress.TabIndex = 33;
            this.tb_EmailAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_EmailAddress_KeyPress);
            // 
            // lb_EmailAddress
            // 
            this.lb_EmailAddress.AutoSize = true;
            this.lb_EmailAddress.Location = new System.Drawing.Point(401, 190);
            this.lb_EmailAddress.Name = "lb_EmailAddress";
            this.lb_EmailAddress.Size = new System.Drawing.Size(121, 18);
            this.lb_EmailAddress.TabIndex = 35;
            this.lb_EmailAddress.Text = "Email Address:";
            // 
            // lb_Correspondence
            // 
            this.lb_Correspondence.AutoSize = true;
            this.lb_Correspondence.Location = new System.Drawing.Point(1, 42);
            this.lb_Correspondence.Name = "lb_Correspondence";
            this.lb_Correspondence.Size = new System.Drawing.Size(138, 18);
            this.lb_Correspondence.TabIndex = 34;
            this.lb_Correspondence.Text = "Correspondence:";
            // 
            // lb_Permanant
            // 
            this.lb_Permanant.AutoSize = true;
            this.lb_Permanant.Location = new System.Drawing.Point(26, 89);
            this.lb_Permanant.Name = "lb_Permanant";
            this.lb_Permanant.Size = new System.Drawing.Size(94, 18);
            this.lb_Permanant.TabIndex = 33;
            this.lb_Permanant.Text = "Permanant:";
            // 
            // tb_Permanant
            // 
            this.tb_Permanant.Location = new System.Drawing.Point(149, 89);
            this.tb_Permanant.Name = "tb_Permanant";
            this.tb_Permanant.Size = new System.Drawing.Size(559, 24);
            this.tb_Permanant.TabIndex = 33;
            this.tb_Permanant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Permanant_KeyPress);
            // 
            // tb_Correspondence
            // 
            this.tb_Correspondence.Location = new System.Drawing.Point(149, 39);
            this.tb_Correspondence.Name = "tb_Correspondence";
            this.tb_Correspondence.Size = new System.Drawing.Size(559, 24);
            this.tb_Correspondence.TabIndex = 33;
            this.tb_Correspondence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Correspondence_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.cb_Atype);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(41, 560);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 52);
            this.panel3.TabIndex = 33;
            // 
            // cb_Atype
            // 
            this.cb_Atype.FormattingEnabled = true;
            this.cb_Atype.Items.AddRange(new object[] {
            "Saving",
            "Current",
            "Recuring"});
            this.cb_Atype.Location = new System.Drawing.Point(139, 8);
            this.cb_Atype.Name = "cb_Atype";
            this.cb_Atype.Size = new System.Drawing.Size(226, 26);
            this.cb_Atype.TabIndex = 5;
            this.cb_Atype.Text = "Fixed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Account Type:";
            // 
            // tb_Accountnumber
            // 
            this.tb_Accountnumber.Location = new System.Drawing.Point(253, 62);
            this.tb_Accountnumber.Name = "tb_Accountnumber";
            this.tb_Accountnumber.Size = new System.Drawing.Size(180, 24);
            this.tb_Accountnumber.TabIndex = 40;
            this.tb_Accountnumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Accountnumber_MouseClick);
            this.tb_Accountnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Accountnumber_KeyPress);
            // 
            // cb_Gender
            // 
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(643, 97);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(121, 26);
            this.cb_Gender.Sorted = true;
            this.cb_Gender.TabIndex = 40;
            this.cb_Gender.Text = "Male";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.tb_FirstName);
            this.groupBox1.Controls.Add(this.tb_MidelName);
            this.groupBox1.Controls.Add(this.cb_Gender);
            this.groupBox1.Controls.Add(this.tb_LastName);
            this.groupBox1.Controls.Add(this.DTP_Openingdate);
            this.groupBox1.Controls.Add(this.lb_DateOfBirth);
            this.groupBox1.Controls.Add(this.lb_Gender);
            this.groupBox1.Location = new System.Drawing.Point(41, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 179);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DTP_Openingdate
            // 
            this.DTP_Openingdate.Location = new System.Drawing.Point(139, 91);
            this.DTP_Openingdate.Name = "DTP_Openingdate";
            this.DTP_Openingdate.Size = new System.Drawing.Size(299, 24);
            this.DTP_Openingdate.TabIndex = 44;
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_City.Location = new System.Drawing.Point(16, 135);
            this.lb_City.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(37, 18);
            this.lb_City.TabIndex = 41;
            this.lb_City.Text = "City";
            // 
            // lb_State
            // 
            this.lb_State.AutoSize = true;
            this.lb_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_State.Location = new System.Drawing.Point(267, 135);
            this.lb_State.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_State.Name = "lb_State";
            this.lb_State.Size = new System.Drawing.Size(47, 18);
            this.lb_State.TabIndex = 42;
            this.lb_State.Text = "State";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Pincode);
            this.groupBox2.Controls.Add(this.tb_State);
            this.groupBox2.Controls.Add(this.tb_City);
            this.groupBox2.Controls.Add(this.lb_Pincode);
            this.groupBox2.Controls.Add(this.lb_State);
            this.groupBox2.Controls.Add(this.tb_EmailAddress);
            this.groupBox2.Controls.Add(this.lb_City);
            this.groupBox2.Controls.Add(this.tb_ContactNumber);
            this.groupBox2.Controls.Add(this.lb_EmailAddress);
            this.groupBox2.Controls.Add(this.lb_ContactNumber);
            this.groupBox2.Controls.Add(this.lb_Correspondence);
            this.groupBox2.Controls.Add(this.lb_Permanant);
            this.groupBox2.Controls.Add(this.tb_Correspondence);
            this.groupBox2.Controls.Add(this.tb_Permanant);
            this.groupBox2.Location = new System.Drawing.Point(41, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 222);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact";
            // 
            // tb_Pincode
            // 
            this.tb_Pincode.Location = new System.Drawing.Point(607, 135);
            this.tb_Pincode.Name = "tb_Pincode";
            this.tb_Pincode.Size = new System.Drawing.Size(161, 24);
            this.tb_Pincode.TabIndex = 46;
            this.tb_Pincode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pincode_KeyPress);
            // 
            // tb_State
            // 
            this.tb_State.Location = new System.Drawing.Point(322, 135);
            this.tb_State.Name = "tb_State";
            this.tb_State.Size = new System.Drawing.Size(161, 24);
            this.tb_State.TabIndex = 45;
            this.tb_State.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_State_KeyPress);
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(81, 135);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(178, 24);
            this.tb_City.TabIndex = 44;
            this.tb_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_City_KeyPress);
            // 
            // lb_Pincode
            // 
            this.lb_Pincode.AutoSize = true;
            this.lb_Pincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pincode.Location = new System.Drawing.Point(525, 135);
            this.lb_Pincode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Pincode.Name = "lb_Pincode";
            this.lb_Pincode.Size = new System.Drawing.Size(69, 18);
            this.lb_Pincode.TabIndex = 43;
            this.lb_Pincode.Text = "Pincode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "AccountNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "CustomerID";
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Location = new System.Drawing.Point(253, 98);
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.Size = new System.Drawing.Size(180, 24);
            this.tb_CustomerID.TabIndex = 46;
            this.tb_CustomerID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_CustomerID_MouseClick);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.tb_CustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Accountnumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_PersonalDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Proceed;
        private System.Windows.Forms.Label lb_PersonalDetails;
        private System.Windows.Forms.TextBox tb_MidelName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label lb_DateOfBirth;
        private System.Windows.Forms.Label lb_Gender;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lb_ContactNumber;
        private System.Windows.Forms.TextBox tb_ContactNumber;
        private System.Windows.Forms.TextBox tb_EmailAddress;
        private System.Windows.Forms.Label lb_EmailAddress;
        private System.Windows.Forms.Label lb_Correspondence;
        private System.Windows.Forms.Label lb_Permanant;
        private System.Windows.Forms.TextBox tb_Permanant;
        private System.Windows.Forms.TextBox tb_Correspondence;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Accountnumber;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker DTP_Openingdate;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.Label lb_State;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Pincode;
        private System.Windows.Forms.TextBox tb_State;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label lb_Pincode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CustomerID;
        private System.Windows.Forms.ComboBox cb_Atype;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button button1;
    }
}