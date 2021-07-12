namespace Windows_And_Doors_Project_CS
{
    partial class frm_Add_New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Employee));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Employee_ID = new System.Windows.Forms.GroupBox();
            this.tbllpnl_Employee_ID = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.gb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.tbllpnl_Personal_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Other_Details = new System.Windows.Forms.GroupBox();
            this.tbllpnl_Other_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.lbl_Post = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Adhaar_No = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Adhaar_No = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.cmb_Qualification = new System.Windows.Forms.ComboBox();
            this.cmb_Post = new System.Windows.Forms.ComboBox();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.cmb_Experience = new System.Windows.Forms.ComboBox();
            this.pnl_Header.SuspendLayout();
            this.gb_Employee_ID.SuspendLayout();
            this.tbllpnl_Employee_ID.SuspendLayout();
            this.gb_Personal_Details.SuspendLayout();
            this.tbllpnl_Personal_Details.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gb_Other_Details.SuspendLayout();
            this.tbllpnl_Other_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Header.Controls.Add(this.btn_Close);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1002, 83);
            this.pnl_Header.TabIndex = 11;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(927, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 41);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(317, 14);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(400, 51);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add New Employee";
            // 
            // gb_Employee_ID
            // 
            this.gb_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Employee_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Employee_ID.Controls.Add(this.tbllpnl_Employee_ID);
            this.gb_Employee_ID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employee_ID.Location = new System.Drawing.Point(12, 89);
            this.gb_Employee_ID.Name = "gb_Employee_ID";
            this.gb_Employee_ID.Size = new System.Drawing.Size(978, 85);
            this.gb_Employee_ID.TabIndex = 12;
            this.gb_Employee_ID.TabStop = false;
            this.gb_Employee_ID.Text = "Employee ID";
            // 
            // tbllpnl_Employee_ID
            // 
            this.tbllpnl_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_Employee_ID.ColumnCount = 7;
            this.tbllpnl_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.797101F));
            this.tbllpnl_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18427F));
            this.tbllpnl_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.25673F));
            this.tbllpnl_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.97515F));
            this.tbllpnl_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.93907F));
            this.tbllpnl_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24999F));
            this.tbllpnl_Employee_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.44545F));
            this.tbllpnl_Employee_ID.Controls.Add(this.lbl_Date, 4, 0);
            this.tbllpnl_Employee_ID.Controls.Add(this.tb_ID, 2, 0);
            this.tbllpnl_Employee_ID.Controls.Add(this.lbl_ID, 1, 0);
            this.tbllpnl_Employee_ID.Controls.Add(this.btn_Search, 3, 0);
            this.tbllpnl_Employee_ID.Controls.Add(this.tb_Date, 5, 0);
            this.tbllpnl_Employee_ID.Location = new System.Drawing.Point(6, 21);
            this.tbllpnl_Employee_ID.Name = "tbllpnl_Employee_ID";
            this.tbllpnl_Employee_ID.RowCount = 1;
            this.tbllpnl_Employee_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllpnl_Employee_ID.Size = new System.Drawing.Size(966, 49);
            this.tbllpnl_Employee_ID.TabIndex = 0;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(605, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(67, 33);
            this.lbl_Date.TabIndex = 13;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(225, 5);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(209, 39);
            this.tb_ID.TabIndex = 12;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(117, 8);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(43, 33);
            this.lbl_ID.TabIndex = 12;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(440, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(129, 37);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Date
            // 
            this.tb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Date.Enabled = false;
            this.tb_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(709, 5);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(189, 39);
            this.tb_Date.TabIndex = 27;
            // 
            // gb_Personal_Details
            // 
            this.gb_Personal_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Personal_Details.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Personal_Details.Controls.Add(this.tbllpnl_Personal_Details);
            this.gb_Personal_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Personal_Details.Location = new System.Drawing.Point(12, 180);
            this.gb_Personal_Details.Name = "gb_Personal_Details";
            this.gb_Personal_Details.Size = new System.Drawing.Size(978, 125);
            this.gb_Personal_Details.TabIndex = 13;
            this.gb_Personal_Details.TabStop = false;
            this.gb_Personal_Details.Text = "Personal Details";
            // 
            // tbllpnl_Personal_Details
            // 
            this.tbllpnl_Personal_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_Personal_Details.ColumnCount = 7;
            this.tbllpnl_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.519669F));
            this.tbllpnl_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08282F));
            this.tbllpnl_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.18841F));
            this.tbllpnl_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.45549F));
            this.tbllpnl_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.14907F));
            this.tbllpnl_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87578F));
            this.tbllpnl_Personal_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.625259F));
            this.tbllpnl_Personal_Details.Controls.Add(this.lbl_Gender, 4, 1);
            this.tbllpnl_Personal_Details.Controls.Add(this.lbl_Mobile_No, 4, 0);
            this.tbllpnl_Personal_Details.Controls.Add(this.lbl_Date_Of_Birth, 1, 1);
            this.tbllpnl_Personal_Details.Controls.Add(this.lbl_Name, 1, 0);
            this.tbllpnl_Personal_Details.Controls.Add(this.dtp_DOB, 2, 1);
            this.tbllpnl_Personal_Details.Controls.Add(this.tb_Name, 2, 0);
            this.tbllpnl_Personal_Details.Controls.Add(this.tb_Mobile_No, 5, 0);
            this.tbllpnl_Personal_Details.Controls.Add(this.gb_Gender, 5, 1);
            this.tbllpnl_Personal_Details.Location = new System.Drawing.Point(6, 19);
            this.tbllpnl_Personal_Details.Name = "tbllpnl_Personal_Details";
            this.tbllpnl_Personal_Details.RowCount = 2;
            this.tbllpnl_Personal_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllpnl_Personal_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllpnl_Personal_Details.Size = new System.Drawing.Size(966, 100);
            this.tbllpnl_Personal_Details.TabIndex = 0;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(556, 58);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(150, 33);
            this.lbl_Gender.TabIndex = 14;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(556, 8);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(150, 33);
            this.lbl_Mobile_No.TabIndex = 15;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(37, 58);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(188, 33);
            this.lbl_Date_Of_Birth.TabIndex = 16;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            this.lbl_Date_Of_Birth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(37, 8);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(188, 33);
            this.lbl_Name.TabIndex = 17;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(231, 55);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(218, 39);
            this.dtp_DOB.TabIndex = 18;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(231, 5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(218, 39);
            this.tb_Name.TabIndex = 19;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(712, 5);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(186, 39);
            this.tb_Mobile_No.TabIndex = 20;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Gender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_Gender.Controls.Add(this.rbtn_Female);
            this.gb_Gender.Controls.Add(this.rbtn_Male);
            this.gb_Gender.Location = new System.Drawing.Point(712, 53);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(186, 44);
            this.gb_Gender.TabIndex = 21;
            this.gb_Gender.TabStop = false;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.BackColor = System.Drawing.Color.DarkGray;
            this.rbtn_Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Female.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Female.Location = new System.Drawing.Point(84, 7);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(102, 31);
            this.rbtn_Female.TabIndex = 14;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = false;
            this.rbtn_Female.CheckedChanged += new System.EventHandler(this.rtbn_Female_CheckedChanged);
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.BackColor = System.Drawing.Color.DarkGray;
            this.rbtn_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Male.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Male.Location = new System.Drawing.Point(-3, 7);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(81, 31);
            this.rbtn_Male.TabIndex = 0;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = false;
            this.rbtn_Male.CheckedChanged += new System.EventHandler(this.rbtn_Male_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 666);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 66);
            this.panel2.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.006198F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95938F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7253F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.75495F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95445F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7253F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.8658F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00863F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Save, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Refresh, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(966, 56);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.AutoSize = true;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(574, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 43);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.AutoSize = true;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(166, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 43);
            this.btn_Refresh.TabIndex = 24;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_Other_Details
            // 
            this.gb_Other_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Other_Details.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Other_Details.Controls.Add(this.tbllpnl_Other_Panel);
            this.gb_Other_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Other_Details.Location = new System.Drawing.Point(12, 311);
            this.gb_Other_Details.Name = "gb_Other_Details";
            this.gb_Other_Details.Size = new System.Drawing.Size(978, 320);
            this.gb_Other_Details.TabIndex = 36;
            this.gb_Other_Details.TabStop = false;
            this.gb_Other_Details.Text = "Other Details";
            // 
            // tbllpnl_Other_Panel
            // 
            this.tbllpnl_Other_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_Other_Panel.ColumnCount = 7;
            this.tbllpnl_Other_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.100692F));
            this.tbllpnl_Other_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.25466F));
            this.tbllpnl_Other_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tbllpnl_Other_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.35197F));
            this.tbllpnl_Other_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35611F));
            this.tbllpnl_Other_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.84265F));
            this.tbllpnl_Other_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.100692F));
            this.tbllpnl_Other_Panel.Controls.Add(this.lbl_Account_No, 1, 0);
            this.tbllpnl_Other_Panel.Controls.Add(this.lbl_Qualification, 1, 1);
            this.tbllpnl_Other_Panel.Controls.Add(this.lbl_Post, 1, 2);
            this.tbllpnl_Other_Panel.Controls.Add(this.lbl_Address, 1, 3);
            this.tbllpnl_Other_Panel.Controls.Add(this.lbl_Adhaar_No, 4, 0);
            this.tbllpnl_Other_Panel.Controls.Add(this.lbl_Salary, 4, 2);
            this.tbllpnl_Other_Panel.Controls.Add(this.tb_Account_No, 2, 0);
            this.tbllpnl_Other_Panel.Controls.Add(this.tb_Address, 2, 3);
            this.tbllpnl_Other_Panel.Controls.Add(this.tb_Adhaar_No, 5, 0);
            this.tbllpnl_Other_Panel.Controls.Add(this.tb_Salary, 5, 2);
            this.tbllpnl_Other_Panel.Controls.Add(this.cmb_Qualification, 2, 1);
            this.tbllpnl_Other_Panel.Controls.Add(this.cmb_Post, 2, 2);
            this.tbllpnl_Other_Panel.Controls.Add(this.lbl_Experience, 4, 1);
            this.tbllpnl_Other_Panel.Controls.Add(this.cmb_Experience, 5, 1);
            this.tbllpnl_Other_Panel.Location = new System.Drawing.Point(6, 18);
            this.tbllpnl_Other_Panel.Name = "tbllpnl_Other_Panel";
            this.tbllpnl_Other_Panel.RowCount = 4;
            this.tbllpnl_Other_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.14695F));
            this.tbllpnl_Other_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.99642F));
            this.tbllpnl_Other_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84588F));
            this.tbllpnl_Other_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.01075F));
            this.tbllpnl_Other_Panel.Size = new System.Drawing.Size(966, 279);
            this.tbllpnl_Other_Panel.TabIndex = 0;
            // 
            // lbl_Account_No
            // 
            this.lbl_Account_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Account_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account_No.Location = new System.Drawing.Point(42, 12);
            this.lbl_Account_No.Name = "lbl_Account_No";
            this.lbl_Account_No.Size = new System.Drawing.Size(180, 33);
            this.lbl_Account_No.TabIndex = 18;
            this.lbl_Account_No.Text = "Account No";
            this.lbl_Account_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Qualification.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.Location = new System.Drawing.Point(42, 68);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(180, 33);
            this.lbl_Qualification.TabIndex = 19;
            this.lbl_Qualification.Text = "Qualification";
            this.lbl_Qualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Post
            // 
            this.lbl_Post.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Post.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Post.Location = new System.Drawing.Point(42, 118);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Size = new System.Drawing.Size(180, 33);
            this.lbl_Post.TabIndex = 20;
            this.lbl_Post.Text = "Post";
            this.lbl_Post.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(42, 158);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(180, 33);
            this.lbl_Address.TabIndex = 21;
            this.lbl_Address.Text = "Address";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Adhaar_No
            // 
            this.lbl_Adhaar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Adhaar_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhaar_No.Location = new System.Drawing.Point(558, 12);
            this.lbl_Adhaar_No.Name = "lbl_Adhaar_No";
            this.lbl_Adhaar_No.Size = new System.Drawing.Size(152, 33);
            this.lbl_Adhaar_No.TabIndex = 22;
            this.lbl_Adhaar_No.Text = "Adhaar No";
            this.lbl_Adhaar_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Salary.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(558, 118);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(152, 33);
            this.lbl_Salary.TabIndex = 24;
            this.lbl_Salary.Text = "Salary";
            this.lbl_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Account_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(228, 9);
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(224, 39);
            this.tb_Account_No.TabIndex = 25;
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(228, 161);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(224, 115);
            this.tb_Address.TabIndex = 26;
            // 
            // tb_Adhaar_No
            // 
            this.tb_Adhaar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Adhaar_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhaar_No.Location = new System.Drawing.Point(716, 9);
            this.tb_Adhaar_No.Name = "tb_Adhaar_No";
            this.tb_Adhaar_No.Size = new System.Drawing.Size(205, 39);
            this.tb_Adhaar_No.TabIndex = 27;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Salary.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(716, 115);
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(205, 39);
            this.tb_Salary.TabIndex = 28;
            // 
            // cmb_Qualification
            // 
            this.cmb_Qualification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Qualification.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Qualification.FormattingEnabled = true;
            this.cmb_Qualification.Items.AddRange(new object[] {
            "10",
            "12",
            "Bachelor Degree"});
            this.cmb_Qualification.Location = new System.Drawing.Point(228, 64);
            this.cmb_Qualification.Name = "cmb_Qualification";
            this.cmb_Qualification.Size = new System.Drawing.Size(224, 39);
            this.cmb_Qualification.TabIndex = 29;
            // 
            // cmb_Post
            // 
            this.cmb_Post.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Post.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Post.FormattingEnabled = true;
            this.cmb_Post.Items.AddRange(new object[] {
            "Cutter",
            "Installor",
            "Assembler",
            "Cleaner",
            "polisher",
            "Other"});
            this.cmb_Post.Location = new System.Drawing.Point(228, 114);
            this.cmb_Post.Name = "cmb_Post";
            this.cmb_Post.Size = new System.Drawing.Size(224, 39);
            this.cmb_Post.TabIndex = 30;
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Experience.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Experience.Location = new System.Drawing.Point(558, 68);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(152, 33);
            this.lbl_Experience.TabIndex = 23;
            this.lbl_Experience.Text = "Experience";
            this.lbl_Experience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Experience
            // 
            this.cmb_Experience.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Experience.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Experience.FormattingEnabled = true;
            this.cmb_Experience.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_Experience.Location = new System.Drawing.Point(716, 64);
            this.cmb_Experience.Name = "cmb_Experience";
            this.cmb_Experience.Size = new System.Drawing.Size(205, 39);
            this.cmb_Experience.TabIndex = 31;
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Other_Details);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Personal_Details);
            this.Controls.Add(this.gb_Employee_ID);
            this.Controls.Add(this.pnl_Header);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Add_New_Employee";
            this.Text = "frm_Add_New_Employee";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Employee_ID.ResumeLayout(false);
            this.tbllpnl_Employee_ID.ResumeLayout(false);
            this.tbllpnl_Employee_ID.PerformLayout();
            this.gb_Personal_Details.ResumeLayout(false);
            this.tbllpnl_Personal_Details.ResumeLayout(false);
            this.tbllpnl_Personal_Details.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gb_Other_Details.ResumeLayout(false);
            this.tbllpnl_Other_Panel.ResumeLayout(false);
            this.tbllpnl_Other_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Employee_ID;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_Employee_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.GroupBox gb_Personal_Details;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_Personal_Details;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_Other_Details;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_Other_Panel;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.Label lbl_Post;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Adhaar_No;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Adhaar_No;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.ComboBox cmb_Qualification;
        private System.Windows.Forms.ComboBox cmb_Post;
        private System.Windows.Forms.ComboBox cmb_Experience;
    }
}