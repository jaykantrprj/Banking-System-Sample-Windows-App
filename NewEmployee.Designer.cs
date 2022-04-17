namespace WindowsFormsApplication1
{
    partial class NewEmployee
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
            this.tb_Pincode = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_State = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_ContactNumber = new System.Windows.Forms.TextBox();
            this.lb_ContactNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_MidelName = new System.Windows.Forms.TextBox();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.DTP_Openingdate = new System.Windows.Forms.DateTimePicker();
            this.CB_YY = new System.Windows.Forms.ComboBox();
            this.lb_DateOfBirth = new System.Windows.Forms.Label();
            this.CB_MM = new System.Windows.Forms.ComboBox();
            this.cb_DD = new System.Windows.Forms.ComboBox();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Proceed = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.tb_EmailAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_Pincode = new System.Windows.Forms.Label();
            this.lb_State = new System.Windows.Forms.Label();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_EmailAddress = new System.Windows.Forms.Label();
            this.lb_Correspondence = new System.Windows.Forms.Label();
            this.lb_Permanant = new System.Windows.Forms.Label();
            this.tb_Correspondence = new System.Windows.Forms.TextBox();
            this.tb_Permanant = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Atype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Pincode
            // 
            this.tb_Pincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pincode.Location = new System.Drawing.Point(690, 132);
            this.tb_Pincode.Name = "tb_Pincode";
            this.tb_Pincode.Size = new System.Drawing.Size(161, 22);
            this.tb_Pincode.TabIndex = 46;
            this.tb_Pincode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pincode_KeyPress);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(189, 86);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(180, 22);
            this.tb_Password.TabIndex = 54;
            this.tb_Password.Tag = "";
            this.tb_Password.Text = "jay12345";
            // 
            // tb_State
            // 
            this.tb_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_State.Location = new System.Drawing.Point(404, 138);
            this.tb_State.Name = "tb_State";
            this.tb_State.Size = new System.Drawing.Size(161, 22);
            this.tb_State.TabIndex = 45;
            this.tb_State.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_State_KeyPress);
            // 
            // tb_City
            // 
            this.tb_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_City.Location = new System.Drawing.Point(149, 138);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(165, 22);
            this.tb_City.TabIndex = 44;
            this.tb_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_City_KeyPress);
            // 
            // tb_ContactNumber
            // 
            this.tb_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ContactNumber.Location = new System.Drawing.Point(149, 175);
            this.tb_ContactNumber.Name = "tb_ContactNumber";
            this.tb_ContactNumber.Size = new System.Drawing.Size(175, 22);
            this.tb_ContactNumber.TabIndex = 34;
            this.tb_ContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNumber_KeyPress);
            // 
            // lb_ContactNumber
            // 
            this.lb_ContactNumber.AutoSize = true;
            this.lb_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ContactNumber.Location = new System.Drawing.Point(8, 178);
            this.lb_ContactNumber.Name = "lb_ContactNumber";
            this.lb_ContactNumber.Size = new System.Drawing.Size(107, 16);
            this.lb_ContactNumber.TabIndex = 36;
            this.lb_ContactNumber.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.tb_FirstName);
            this.groupBox1.Controls.Add(this.tb_MidelName);
            this.groupBox1.Controls.Add(this.cb_Gender);
            this.groupBox1.Controls.Add(this.tb_LastName);
            this.groupBox1.Controls.Add(this.DTP_Openingdate);
            this.groupBox1.Controls.Add(this.CB_YY);
            this.groupBox1.Controls.Add(this.lb_DateOfBirth);
            this.groupBox1.Controls.Add(this.CB_MM);
            this.groupBox1.Controls.Add(this.cb_DD);
            this.groupBox1.Controls.Add(this.lb_Gender);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 174);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(12, 44);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(48, 16);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Name:";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FirstName.Location = new System.Drawing.Point(110, 44);
            this.tb_FirstName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(232, 22);
            this.tb_FirstName.TabIndex = 3;
            this.tb_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_FirstName_KeyPress);
            // 
            // tb_MidelName
            // 
            this.tb_MidelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MidelName.Location = new System.Drawing.Point(366, 44);
            this.tb_MidelName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_MidelName.Name = "tb_MidelName";
            this.tb_MidelName.Size = new System.Drawing.Size(201, 22);
            this.tb_MidelName.TabIndex = 2;
            this.tb_MidelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MidelName_KeyPress);
            // 
            // cb_Gender
            // 
            this.cb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(607, 91);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(121, 24);
            this.cb_Gender.Sorted = true;
            this.cb_Gender.TabIndex = 40;
            this.cb_Gender.Text = "Male";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LastName.Location = new System.Drawing.Point(607, 44);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(226, 22);
            this.tb_LastName.TabIndex = 20;
            this.tb_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_LastName_KeyPress);
            // 
            // DTP_Openingdate
            // 
            this.DTP_Openingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Openingdate.Location = new System.Drawing.Point(582, 146);
            this.DTP_Openingdate.Name = "DTP_Openingdate";
            this.DTP_Openingdate.Size = new System.Drawing.Size(299, 22);
            this.DTP_Openingdate.TabIndex = 44;
            // 
            // CB_YY
            // 
            this.CB_YY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_YY.FormattingEnabled = true;
            this.CB_YY.Items.AddRange(new object[] {
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995"});
            this.CB_YY.Location = new System.Drawing.Point(303, 83);
            this.CB_YY.Name = "CB_YY";
            this.CB_YY.Size = new System.Drawing.Size(74, 24);
            this.CB_YY.Sorted = true;
            this.CB_YY.TabIndex = 39;
            this.CB_YY.Text = "1955";
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DateOfBirth.Location = new System.Drawing.Point(12, 91);
            this.lb_DateOfBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(85, 16);
            this.lb_DateOfBirth.TabIndex = 21;
            this.lb_DateOfBirth.Text = "Date Of Birth:";
            // 
            // CB_MM
            // 
            this.CB_MM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MM.FormattingEnabled = true;
            this.CB_MM.Items.AddRange(new object[] {
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.CB_MM.Location = new System.Drawing.Point(200, 83);
            this.CB_MM.Name = "CB_MM";
            this.CB_MM.Size = new System.Drawing.Size(79, 24);
            this.CB_MM.TabIndex = 38;
            this.CB_MM.Text = "01";
            // 
            // cb_DD
            // 
            this.cb_DD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DD.FormattingEnabled = true;
            this.cb_DD.Items.AddRange(new object[] {
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_DD.Location = new System.Drawing.Point(111, 83);
            this.cb_DD.Name = "cb_DD";
            this.cb_DD.Size = new System.Drawing.Size(61, 24);
            this.cb_DD.TabIndex = 37;
            this.cb_DD.Text = "01";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(511, 94);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(56, 16);
            this.lb_Gender.TabIndex = 24;
            this.lb_Gender.Text = "Gender:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bt_Save);
            this.panel1.Controls.Add(this.bt_Proceed);
            this.panel1.Controls.Add(this.bt_Reset);
            this.panel1.Location = new System.Drawing.Point(19, 595);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 54);
            this.panel1.TabIndex = 47;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(540, 13);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(90, 31);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Proceed
            // 
            this.bt_Proceed.Location = new System.Drawing.Point(27, 11);
            this.bt_Proceed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_Proceed.Name = "bt_Proceed";
            this.bt_Proceed.Size = new System.Drawing.Size(125, 32);
            this.bt_Proceed.TabIndex = 1;
            this.bt_Proceed.Text = "&Reset";
            this.bt_Proceed.UseVisualStyleBackColor = true;
            // 
            // bt_Reset
            // 
            this.bt_Reset.Location = new System.Drawing.Point(658, 13);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(125, 32);
            this.bt_Reset.TabIndex = 0;
            this.bt_Reset.Text = "&Proceed";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // tb_EmailAddress
            // 
            this.tb_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmailAddress.Location = new System.Drawing.Point(565, 178);
            this.tb_EmailAddress.Name = "tb_EmailAddress";
            this.tb_EmailAddress.Size = new System.Drawing.Size(286, 22);
            this.tb_EmailAddress.TabIndex = 33;
            this.tb_EmailAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_EmailAddress_KeyPress);
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
            this.groupBox2.Location = new System.Drawing.Point(27, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 222);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lb_Pincode
            // 
            this.lb_Pincode.AutoSize = true;
            this.lb_Pincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pincode.Location = new System.Drawing.Point(579, 138);
            this.lb_Pincode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Pincode.Name = "lb_Pincode";
            this.lb_Pincode.Size = new System.Drawing.Size(58, 16);
            this.lb_Pincode.TabIndex = 43;
            this.lb_Pincode.Text = "Pincode";
            // 
            // lb_State
            // 
            this.lb_State.AutoSize = true;
            this.lb_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_State.Location = new System.Drawing.Point(326, 144);
            this.lb_State.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_State.Name = "lb_State";
            this.lb_State.Size = new System.Drawing.Size(39, 16);
            this.lb_State.TabIndex = 42;
            this.lb_State.Text = "State";
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_City.Location = new System.Drawing.Point(16, 135);
            this.lb_City.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(30, 16);
            this.lb_City.TabIndex = 41;
            this.lb_City.Text = "City";
            // 
            // lb_EmailAddress
            // 
            this.lb_EmailAddress.AutoSize = true;
            this.lb_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmailAddress.Location = new System.Drawing.Point(401, 184);
            this.lb_EmailAddress.Name = "lb_EmailAddress";
            this.lb_EmailAddress.Size = new System.Drawing.Size(99, 16);
            this.lb_EmailAddress.TabIndex = 35;
            this.lb_EmailAddress.Text = "Email Address:";
            // 
            // lb_Correspondence
            // 
            this.lb_Correspondence.AutoSize = true;
            this.lb_Correspondence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Correspondence.Location = new System.Drawing.Point(6, 39);
            this.lb_Correspondence.Name = "lb_Correspondence";
            this.lb_Correspondence.Size = new System.Drawing.Size(112, 16);
            this.lb_Correspondence.TabIndex = 34;
            this.lb_Correspondence.Text = "Correspondence:";
            // 
            // lb_Permanant
            // 
            this.lb_Permanant.AutoSize = true;
            this.lb_Permanant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Permanant.Location = new System.Drawing.Point(8, 89);
            this.lb_Permanant.Name = "lb_Permanant";
            this.lb_Permanant.Size = new System.Drawing.Size(76, 16);
            this.lb_Permanant.TabIndex = 33;
            this.lb_Permanant.Text = "Permanant:";
            // 
            // tb_Correspondence
            // 
            this.tb_Correspondence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Correspondence.Location = new System.Drawing.Point(149, 39);
            this.tb_Correspondence.Name = "tb_Correspondence";
            this.tb_Correspondence.Size = new System.Drawing.Size(559, 22);
            this.tb_Correspondence.TabIndex = 33;
            this.tb_Correspondence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Correspondence_KeyPress);
            // 
            // tb_Permanant
            // 
            this.tb_Permanant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Permanant.Location = new System.Drawing.Point(149, 89);
            this.tb_Permanant.Name = "tb_Permanant";
            this.tb_Permanant.Size = new System.Drawing.Size(559, 22);
            this.tb_Permanant.TabIndex = 33;
            this.tb_Permanant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Permanant_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.tb_salary);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cb_Atype);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(27, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 49);
            this.panel3.TabIndex = 48;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tb_salary
            // 
            this.tb_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salary.Location = new System.Drawing.Point(675, 10);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(161, 22);
            this.tb_salary.TabIndex = 38;
            this.tb_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_salary_KeyPress);
            this.tb_salary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_salary_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Salary";
            // 
            // cb_Atype
            // 
            this.cb_Atype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Atype.FormattingEnabled = true;
            this.cb_Atype.Items.AddRange(new object[] {
            "Casier",
            "Accountant"});
            this.cb_Atype.Location = new System.Drawing.Point(149, 8);
            this.cb_Atype.Name = "cb_Atype";
            this.cb_Atype.Size = new System.Drawing.Size(226, 24);
            this.cb_Atype.TabIndex = 5;
            this.cb_Atype.Text = "General";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Employee Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "EmployeeID";
            // 
            // tb_EmployeeID
            // 
            this.tb_EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmployeeID.Location = new System.Drawing.Point(189, 41);
            this.tb_EmployeeID.Name = "tb_EmployeeID";
            this.tb_EmployeeID.Size = new System.Drawing.Size(180, 22);
            this.tb_EmployeeID.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "All field are mandatary.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 58;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(987, 686);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_EmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Name = "NewEmployee";
            this.Text = "NewEmployee";
            this.Load += new System.EventHandler(this.NewEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Pincode;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_State;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_ContactNumber;
        private System.Windows.Forms.Label lb_ContactNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_MidelName;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.DateTimePicker DTP_Openingdate;
        private System.Windows.Forms.ComboBox CB_YY;
        private System.Windows.Forms.Label lb_DateOfBirth;
        private System.Windows.Forms.ComboBox CB_MM;
        private System.Windows.Forms.ComboBox cb_DD;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Proceed;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.TextBox tb_EmailAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Pincode;
        private System.Windows.Forms.Label lb_State;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.Label lb_EmailAddress;
        private System.Windows.Forms.Label lb_Correspondence;
        private System.Windows.Forms.Label lb_Permanant;
        private System.Windows.Forms.TextBox tb_Correspondence;
        private System.Windows.Forms.TextBox tb_Permanant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_Atype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_EmployeeID;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;

    }
}