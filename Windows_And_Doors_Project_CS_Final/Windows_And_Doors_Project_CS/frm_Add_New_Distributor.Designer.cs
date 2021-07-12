namespace Windows_And_Doors_Project_CS
{
    partial class frm_Add_New_Distributor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Distributor));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Distributor_ID = new System.Windows.Forms.GroupBox();
            this.tbllpnl_Distributor_ID = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.gb_Distributor_Details = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.gb_Provider_Of = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Select_All = new System.Windows.Forms.Button();
            this.btn_Add_New_Material = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chlb_Windows_Material = new System.Windows.Forms.CheckedListBox();
            this.chlb_Other = new System.Windows.Forms.CheckedListBox();
            this.chlb_Door_Material = new System.Windows.Forms.CheckedListBox();
            this.tbllpnl_Provider_Of = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Windows_Material = new System.Windows.Forms.Label();
            this.lbl_Door_Material = new System.Windows.Forms.Label();
            this.lbl_Other = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_Window_None = new System.Windows.Forms.RadioButton();
            this.rbtn_Window_Select = new System.Windows.Forms.RadioButton();
            this.rbtn_Window_All = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtn_Door_None = new System.Windows.Forms.RadioButton();
            this.rbtn_Door_Select = new System.Windows.Forms.RadioButton();
            this.rbtn_Door_All = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn_Other_None = new System.Windows.Forms.RadioButton();
            this.rbtn_Other_Select = new System.Windows.Forms.RadioButton();
            this.rbtn_Other_All = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Distributor_ID.SuspendLayout();
            this.tbllpnl_Distributor_ID.SuspendLayout();
            this.gb_Distributor_Details.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_Provider_Of.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbllpnl_Provider_Of.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.pnl_Header.TabIndex = 12;
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
            this.lbl_Header.Size = new System.Drawing.Size(404, 51);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add New Distributor";
            // 
            // gb_Distributor_ID
            // 
            this.gb_Distributor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Distributor_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Distributor_ID.Controls.Add(this.tbllpnl_Distributor_ID);
            this.gb_Distributor_ID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Distributor_ID.Location = new System.Drawing.Point(12, 89);
            this.gb_Distributor_ID.Name = "gb_Distributor_ID";
            this.gb_Distributor_ID.Size = new System.Drawing.Size(978, 85);
            this.gb_Distributor_ID.TabIndex = 13;
            this.gb_Distributor_ID.TabStop = false;
            this.gb_Distributor_ID.Text = "Distributor ID";
            // 
            // tbllpnl_Distributor_ID
            // 
            this.tbllpnl_Distributor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_Distributor_ID.ColumnCount = 7;
            this.tbllpnl_Distributor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.797101F));
            this.tbllpnl_Distributor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18427F));
            this.tbllpnl_Distributor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.25673F));
            this.tbllpnl_Distributor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.97515F));
            this.tbllpnl_Distributor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.93907F));
            this.tbllpnl_Distributor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24999F));
            this.tbllpnl_Distributor_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.44545F));
            this.tbllpnl_Distributor_ID.Controls.Add(this.lbl_Date, 4, 0);
            this.tbllpnl_Distributor_ID.Controls.Add(this.tb_ID, 2, 0);
            this.tbllpnl_Distributor_ID.Controls.Add(this.lbl_ID, 1, 0);
            this.tbllpnl_Distributor_ID.Controls.Add(this.btn_Search, 3, 0);
            this.tbllpnl_Distributor_ID.Controls.Add(this.tb_Date, 5, 0);
            this.tbllpnl_Distributor_ID.Location = new System.Drawing.Point(6, 21);
            this.tbllpnl_Distributor_ID.Name = "tbllpnl_Distributor_ID";
            this.tbllpnl_Distributor_ID.RowCount = 1;
            this.tbllpnl_Distributor_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllpnl_Distributor_ID.Size = new System.Drawing.Size(966, 49);
            this.tbllpnl_Distributor_ID.TabIndex = 0;
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
            // gb_Distributor_Details
            // 
            this.gb_Distributor_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Distributor_Details.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Distributor_Details.Controls.Add(this.tableLayoutPanel1);
            this.gb_Distributor_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Distributor_Details.Location = new System.Drawing.Point(12, 180);
            this.gb_Distributor_Details.Name = "gb_Distributor_Details";
            this.gb_Distributor_Details.Size = new System.Drawing.Size(978, 85);
            this.gb_Distributor_Details.TabIndex = 14;
            this.gb_Distributor_Details.TabStop = false;
            this.gb_Distributor_Details.Text = "Distributor Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.797101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.18427F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.25673F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.73292F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.11387F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.44545F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mobile_No, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Mobile_No, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(564, 8);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(137, 33);
            this.lbl_Mobile_No.TabIndex = 13;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(225, 5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(209, 39);
            this.tb_Name.TabIndex = 12;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(99, 8);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 33);
            this.lbl_Name.TabIndex = 12;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(709, 5);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(190, 39);
            this.tb_Mobile_No.TabIndex = 27;
            // 
            // gb_Provider_Of
            // 
            this.gb_Provider_Of.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Provider_Of.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Provider_Of.Controls.Add(this.tableLayoutPanel4);
            this.gb_Provider_Of.Controls.Add(this.tableLayoutPanel2);
            this.gb_Provider_Of.Controls.Add(this.tbllpnl_Provider_Of);
            this.gb_Provider_Of.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Provider_Of.Location = new System.Drawing.Point(12, 271);
            this.gb_Provider_Of.Name = "gb_Provider_Of";
            this.gb_Provider_Of.Size = new System.Drawing.Size(978, 372);
            this.gb_Provider_Of.TabIndex = 15;
            this.gb_Provider_Of.TabStop = false;
            this.gb_Provider_Of.Text = "Provider Of";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.006198F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95938F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.7412F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.316771F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.178054F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.2588F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.35197F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00863F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Select_All, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Add_New_Material, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 308);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(966, 56);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btn_Select_All
            // 
            this.btn_Select_All.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select_All.AutoSize = true;
            this.btn_Select_All.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select_All.Location = new System.Drawing.Point(574, 3);
            this.btn_Select_All.Name = "btn_Select_All";
            this.btn_Select_All.Size = new System.Drawing.Size(238, 43);
            this.btn_Select_All.TabIndex = 26;
            this.btn_Select_All.Text = "Select All";
            this.btn_Select_All.UseVisualStyleBackColor = true;
            this.btn_Select_All.Click += new System.EventHandler(this.btn_Select_All_Click);
            // 
            // btn_Add_New_Material
            // 
            this.btn_Add_New_Material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_New_Material.AutoSize = true;
            this.btn_Add_New_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Material.Location = new System.Drawing.Point(166, 3);
            this.btn_Add_New_Material.Name = "btn_Add_New_Material";
            this.btn_Add_New_Material.Size = new System.Drawing.Size(233, 43);
            this.btn_Add_New_Material.TabIndex = 24;
            this.btn_Add_New_Material.Text = "Add New Material";
            this.btn_Add_New_Material.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.843112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.61894F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.506997F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0183F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.614639F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31001F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.934338F));
            this.tableLayoutPanel2.Controls.Add(this.chlb_Windows_Material, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chlb_Other, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.chlb_Door_Material, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(929, 190);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // chlb_Windows_Material
            // 
            this.chlb_Windows_Material.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chlb_Windows_Material.CheckOnClick = true;
            this.chlb_Windows_Material.Enabled = false;
            this.chlb_Windows_Material.FormattingEnabled = true;
            this.chlb_Windows_Material.Location = new System.Drawing.Point(66, 3);
            this.chlb_Windows_Material.Name = "chlb_Windows_Material";
            this.chlb_Windows_Material.Size = new System.Drawing.Size(232, 165);
            this.chlb_Windows_Material.TabIndex = 34;
            // 
            // chlb_Other
            // 
            this.chlb_Other.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chlb_Other.CheckOnClick = true;
            this.chlb_Other.Enabled = false;
            this.chlb_Other.FormattingEnabled = true;
            this.chlb_Other.Location = new System.Drawing.Point(584, 3);
            this.chlb_Other.Name = "chlb_Other";
            this.chlb_Other.Size = new System.Drawing.Size(257, 165);
            this.chlb_Other.TabIndex = 35;
            // 
            // chlb_Door_Material
            // 
            this.chlb_Door_Material.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chlb_Door_Material.CheckOnClick = true;
            this.chlb_Door_Material.Enabled = false;
            this.chlb_Door_Material.FormattingEnabled = true;
            this.chlb_Door_Material.Items.AddRange(new object[] {
            "Single Door",
            "Double Door",
            "Bathroom Door"});
            this.chlb_Door_Material.Location = new System.Drawing.Point(318, 3);
            this.chlb_Door_Material.Name = "chlb_Door_Material";
            this.chlb_Door_Material.Size = new System.Drawing.Size(245, 165);
            this.chlb_Door_Material.TabIndex = 33;
            // 
            // tbllpnl_Provider_Of
            // 
            this.tbllpnl_Provider_Of.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_Provider_Of.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbllpnl_Provider_Of.ColumnCount = 7;
            this.tbllpnl_Provider_Of.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.996771F));
            this.tbllpnl_Provider_Of.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.29602F));
            this.tbllpnl_Provider_Of.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.614639F));
            this.tbllpnl_Provider_Of.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.80301F));
            this.tbllpnl_Provider_Of.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.829925F));
            this.tbllpnl_Provider_Of.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31001F));
            this.tbllpnl_Provider_Of.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.934338F));
            this.tbllpnl_Provider_Of.Controls.Add(this.lbl_Windows_Material, 1, 0);
            this.tbllpnl_Provider_Of.Controls.Add(this.lbl_Door_Material, 3, 0);
            this.tbllpnl_Provider_Of.Controls.Add(this.lbl_Other, 5, 0);
            this.tbllpnl_Provider_Of.Controls.Add(this.panel1, 1, 1);
            this.tbllpnl_Provider_Of.Controls.Add(this.panel3, 3, 1);
            this.tbllpnl_Provider_Of.Controls.Add(this.panel4, 5, 1);
            this.tbllpnl_Provider_Of.Location = new System.Drawing.Point(25, 27);
            this.tbllpnl_Provider_Of.Name = "tbllpnl_Provider_Of";
            this.tbllpnl_Provider_Of.RowCount = 2;
            this.tbllpnl_Provider_Of.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.63964F));
            this.tbllpnl_Provider_Of.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.36036F));
            this.tbllpnl_Provider_Of.Size = new System.Drawing.Size(929, 86);
            this.tbllpnl_Provider_Of.TabIndex = 0;
            // 
            // lbl_Windows_Material
            // 
            this.lbl_Windows_Material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Windows_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Windows_Material.Location = new System.Drawing.Point(68, 1);
            this.lbl_Windows_Material.Name = "lbl_Windows_Material";
            this.lbl_Windows_Material.Size = new System.Drawing.Size(229, 33);
            this.lbl_Windows_Material.TabIndex = 13;
            this.lbl_Windows_Material.Text = "Windows Material";
            this.lbl_Windows_Material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Door_Material
            // 
            this.lbl_Door_Material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Door_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Door_Material.Location = new System.Drawing.Point(318, 1);
            this.lbl_Door_Material.Name = "lbl_Door_Material";
            this.lbl_Door_Material.Size = new System.Drawing.Size(243, 33);
            this.lbl_Door_Material.TabIndex = 14;
            this.lbl_Door_Material.Text = "Door Material";
            this.lbl_Door_Material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Other
            // 
            this.lbl_Other.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Other.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Other.Location = new System.Drawing.Point(584, 1);
            this.lbl_Other.Name = "lbl_Other";
            this.lbl_Other.Size = new System.Drawing.Size(257, 33);
            this.lbl_Other.TabIndex = 15;
            this.lbl_Other.Text = "Other";
            this.lbl_Other.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.rbtn_Window_None);
            this.panel1.Controls.Add(this.rbtn_Window_Select);
            this.panel1.Controls.Add(this.rbtn_Window_All);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(68, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 46);
            this.panel1.TabIndex = 16;
            // 
            // rbtn_Window_None
            // 
            this.rbtn_Window_None.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Window_None.AutoSize = true;
            this.rbtn_Window_None.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Window_None.Location = new System.Drawing.Point(159, 10);
            this.rbtn_Window_None.Name = "rbtn_Window_None";
            this.rbtn_Window_None.Size = new System.Drawing.Size(75, 27);
            this.rbtn_Window_None.TabIndex = 2;
            this.rbtn_Window_None.TabStop = true;
            this.rbtn_Window_None.Text = "None";
            this.rbtn_Window_None.UseVisualStyleBackColor = true;
            this.rbtn_Window_None.CheckedChanged += new System.EventHandler(this.rbtn_Window_None_CheckedChanged);
            // 
            // rbtn_Window_Select
            // 
            this.rbtn_Window_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Window_Select.AutoSize = true;
            this.rbtn_Window_Select.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Window_Select.Location = new System.Drawing.Point(70, 10);
            this.rbtn_Window_Select.Name = "rbtn_Window_Select";
            this.rbtn_Window_Select.Size = new System.Drawing.Size(83, 27);
            this.rbtn_Window_Select.TabIndex = 1;
            this.rbtn_Window_Select.TabStop = true;
            this.rbtn_Window_Select.Text = "Select";
            this.rbtn_Window_Select.UseVisualStyleBackColor = true;
            this.rbtn_Window_Select.CheckedChanged += new System.EventHandler(this.rbtn_Window_Select_CheckedChanged);
            // 
            // rbtn_Window_All
            // 
            this.rbtn_Window_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Window_All.AutoSize = true;
            this.rbtn_Window_All.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Window_All.Location = new System.Drawing.Point(3, 10);
            this.rbtn_Window_All.Name = "rbtn_Window_All";
            this.rbtn_Window_All.Size = new System.Drawing.Size(55, 27);
            this.rbtn_Window_All.TabIndex = 0;
            this.rbtn_Window_All.TabStop = true;
            this.rbtn_Window_All.Text = "All";
            this.rbtn_Window_All.UseVisualStyleBackColor = true;
            this.rbtn_Window_All.CheckedChanged += new System.EventHandler(this.rbtn_Window_All_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.rbtn_Door_None);
            this.panel3.Controls.Add(this.rbtn_Door_Select);
            this.panel3.Controls.Add(this.rbtn_Door_All);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(318, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 46);
            this.panel3.TabIndex = 17;
            // 
            // rbtn_Door_None
            // 
            this.rbtn_Door_None.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Door_None.AutoSize = true;
            this.rbtn_Door_None.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Door_None.Location = new System.Drawing.Point(162, 10);
            this.rbtn_Door_None.Name = "rbtn_Door_None";
            this.rbtn_Door_None.Size = new System.Drawing.Size(75, 27);
            this.rbtn_Door_None.TabIndex = 5;
            this.rbtn_Door_None.TabStop = true;
            this.rbtn_Door_None.Text = "None";
            this.rbtn_Door_None.UseVisualStyleBackColor = true;
            this.rbtn_Door_None.CheckedChanged += new System.EventHandler(this.rbtn_Door_None_CheckedChanged);
            // 
            // rbtn_Door_Select
            // 
            this.rbtn_Door_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Door_Select.AutoSize = true;
            this.rbtn_Door_Select.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Door_Select.Location = new System.Drawing.Point(73, 10);
            this.rbtn_Door_Select.Name = "rbtn_Door_Select";
            this.rbtn_Door_Select.Size = new System.Drawing.Size(83, 27);
            this.rbtn_Door_Select.TabIndex = 4;
            this.rbtn_Door_Select.TabStop = true;
            this.rbtn_Door_Select.Text = "Select";
            this.rbtn_Door_Select.UseVisualStyleBackColor = true;
            this.rbtn_Door_Select.CheckedChanged += new System.EventHandler(this.rbtn_Door_Select_CheckedChanged);
            // 
            // rbtn_Door_All
            // 
            this.rbtn_Door_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Door_All.AutoSize = true;
            this.rbtn_Door_All.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Door_All.Location = new System.Drawing.Point(6, 10);
            this.rbtn_Door_All.Name = "rbtn_Door_All";
            this.rbtn_Door_All.Size = new System.Drawing.Size(55, 27);
            this.rbtn_Door_All.TabIndex = 3;
            this.rbtn_Door_All.TabStop = true;
            this.rbtn_Door_All.Text = "All";
            this.rbtn_Door_All.UseVisualStyleBackColor = true;
            this.rbtn_Door_All.CheckedChanged += new System.EventHandler(this.rbtn_Door_All_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.rbtn_Other_None);
            this.panel4.Controls.Add(this.rbtn_Other_Select);
            this.panel4.Controls.Add(this.rbtn_Other_All);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(584, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 46);
            this.panel4.TabIndex = 18;
            // 
            // rbtn_Other_None
            // 
            this.rbtn_Other_None.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Other_None.AutoSize = true;
            this.rbtn_Other_None.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Other_None.Location = new System.Drawing.Point(169, 10);
            this.rbtn_Other_None.Name = "rbtn_Other_None";
            this.rbtn_Other_None.Size = new System.Drawing.Size(75, 27);
            this.rbtn_Other_None.TabIndex = 5;
            this.rbtn_Other_None.TabStop = true;
            this.rbtn_Other_None.Text = "None";
            this.rbtn_Other_None.UseVisualStyleBackColor = true;
            this.rbtn_Other_None.CheckedChanged += new System.EventHandler(this.rbtn_Other_None_CheckedChanged);
            // 
            // rbtn_Other_Select
            // 
            this.rbtn_Other_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Other_Select.AutoSize = true;
            this.rbtn_Other_Select.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Other_Select.Location = new System.Drawing.Point(80, 10);
            this.rbtn_Other_Select.Name = "rbtn_Other_Select";
            this.rbtn_Other_Select.Size = new System.Drawing.Size(83, 27);
            this.rbtn_Other_Select.TabIndex = 4;
            this.rbtn_Other_Select.TabStop = true;
            this.rbtn_Other_Select.Text = "Select";
            this.rbtn_Other_Select.UseVisualStyleBackColor = true;
            this.rbtn_Other_Select.CheckedChanged += new System.EventHandler(this.rbtn_Other_Select_CheckedChanged);
            // 
            // rbtn_Other_All
            // 
            this.rbtn_Other_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtn_Other_All.AutoSize = true;
            this.rbtn_Other_All.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Other_All.Location = new System.Drawing.Point(13, 10);
            this.rbtn_Other_All.Name = "rbtn_Other_All";
            this.rbtn_Other_All.Size = new System.Drawing.Size(55, 27);
            this.rbtn_Other_All.TabIndex = 3;
            this.rbtn_Other_All.TabStop = true;
            this.rbtn_Other_All.Text = "All";
            this.rbtn_Other_All.UseVisualStyleBackColor = true;
            this.rbtn_Other_All.CheckedChanged += new System.EventHandler(this.rbtn_Other_All_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 666);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 66);
            this.panel2.TabIndex = 36;
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
            // frm_Add_New_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Provider_Of);
            this.Controls.Add(this.gb_Distributor_Details);
            this.Controls.Add(this.gb_Distributor_ID);
            this.Controls.Add(this.pnl_Header);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Add_New_Distributor";
            this.Text = "Add New Distributor";
            this.Load += new System.EventHandler(this.frm_Add_New_Distributor_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Distributor_ID.ResumeLayout(false);
            this.tbllpnl_Distributor_ID.ResumeLayout(false);
            this.tbllpnl_Distributor_ID.PerformLayout();
            this.gb_Distributor_Details.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Provider_Of.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tbllpnl_Provider_Of.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Distributor_ID;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_Distributor_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.GroupBox gb_Distributor_Details;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.GroupBox gb_Provider_Of;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_Provider_Of;
        private System.Windows.Forms.Label lbl_Windows_Material;
        private System.Windows.Forms.Label lbl_Door_Material;
        private System.Windows.Forms.Label lbl_Other;
        private System.Windows.Forms.CheckedListBox chlb_Door_Material;
        private System.Windows.Forms.CheckedListBox chlb_Windows_Material;
        private System.Windows.Forms.CheckedListBox chlb_Other;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_Window_None;
        private System.Windows.Forms.RadioButton rbtn_Window_Select;
        private System.Windows.Forms.RadioButton rbtn_Window_All;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtn_Door_None;
        private System.Windows.Forms.RadioButton rbtn_Door_Select;
        private System.Windows.Forms.RadioButton rbtn_Door_All;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtn_Other_None;
        private System.Windows.Forms.RadioButton rbtn_Other_Select;
        private System.Windows.Forms.RadioButton rbtn_Other_All;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Select_All;
        private System.Windows.Forms.Button btn_Add_New_Material;
    }
}