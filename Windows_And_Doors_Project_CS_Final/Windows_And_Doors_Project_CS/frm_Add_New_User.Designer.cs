namespace Windows_And_Doors_Project_CS
{
    partial class frm_Add_New_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_User));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tbllpnl_Add_New_User = new System.Windows.Forms.TableLayoutPanel();
            this.gb_User_Details = new System.Windows.Forms.GroupBox();
            this.tbl_User_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_Treat_As = new System.Windows.Forms.Label();
            this.lbl_Security_Key = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.tb_Security_Key = new System.Windows.Forms.TextBox();
            this.cmb_Treat_As = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Right_Border = new System.Windows.Forms.Panel();
            this.pnl_Left_Border = new System.Windows.Forms.Panel();
            this.tbllpnl_User_ID = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.tbllpnl_Add_New_User.SuspendLayout();
            this.gb_User_Details.SuspendLayout();
            this.tbl_User_Details.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tbllpnl_User_ID.SuspendLayout();
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
            this.pnl_Header.TabIndex = 34;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(924, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 41);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Header.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(317, 14);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(274, 49);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add New User";
            // 
            // tbllpnl_Add_New_User
            // 
            this.tbllpnl_Add_New_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_Add_New_User.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbllpnl_Add_New_User.ColumnCount = 7;
            this.tbllpnl_Add_New_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.214724F));
            this.tbllpnl_Add_New_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.760736F));
            this.tbllpnl_Add_New_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.476483F));
            this.tbllpnl_Add_New_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.23313F));
            this.tbllpnl_Add_New_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.396728F));
            this.tbllpnl_Add_New_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.760736F));
            this.tbllpnl_Add_New_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.055215F));
            this.tbllpnl_Add_New_User.Controls.Add(this.gb_User_Details, 3, 1);
            this.tbllpnl_Add_New_User.Controls.Add(this.pnl_Right_Border, 4, 1);
            this.tbllpnl_Add_New_User.Controls.Add(this.pnl_Left_Border, 2, 1);
            this.tbllpnl_Add_New_User.Controls.Add(this.tbllpnl_User_ID, 3, 0);
            this.tbllpnl_Add_New_User.Location = new System.Drawing.Point(12, 89);
            this.tbllpnl_Add_New_User.Name = "tbllpnl_Add_New_User";
            this.tbllpnl_Add_New_User.RowCount = 3;
            this.tbllpnl_Add_New_User.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.96346F));
            this.tbllpnl_Add_New_User.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.2093F));
            this.tbllpnl_Add_New_User.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.827242F));
            this.tbllpnl_Add_New_User.Size = new System.Drawing.Size(978, 602);
            this.tbllpnl_Add_New_User.TabIndex = 35;
            // 
            // gb_User_Details
            // 
            this.gb_User_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_User_Details.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_User_Details.Controls.Add(this.tbl_User_Details);
            this.gb_User_Details.Controls.Add(this.panel2);
            this.gb_User_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_User_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_User_Details.Location = new System.Drawing.Point(115, 69);
            this.gb_User_Details.Name = "gb_User_Details";
            this.gb_User_Details.Size = new System.Drawing.Size(720, 518);
            this.gb_User_Details.TabIndex = 0;
            this.gb_User_Details.TabStop = false;
            this.gb_User_Details.Text = "User Details";
            // 
            // tbl_User_Details
            // 
            this.tbl_User_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_User_Details.ColumnCount = 5;
            this.tbl_User_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5625F));
            this.tbl_User_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.48587F));
            this.tbl_User_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.237288F));
            this.tbl_User_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.02825F));
            this.tbl_User_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09039F));
            this.tbl_User_Details.Controls.Add(this.lbl_Username, 1, 0);
            this.tbl_User_Details.Controls.Add(this.tb_Username, 3, 0);
            this.tbl_User_Details.Controls.Add(this.lbl_Password, 1, 1);
            this.tbl_User_Details.Controls.Add(this.lbl_Confirm_Password, 1, 2);
            this.tbl_User_Details.Controls.Add(this.lbl_Treat_As, 1, 3);
            this.tbl_User_Details.Controls.Add(this.lbl_Security_Key, 1, 4);
            this.tbl_User_Details.Controls.Add(this.tb_Password, 3, 1);
            this.tbl_User_Details.Controls.Add(this.tb_Confirm_Password, 3, 2);
            this.tbl_User_Details.Controls.Add(this.tb_Security_Key, 3, 4);
            this.tbl_User_Details.Controls.Add(this.cmb_Treat_As, 3, 3);
            this.tbl_User_Details.Location = new System.Drawing.Point(6, 27);
            this.tbl_User_Details.Name = "tbl_User_Details";
            this.tbl_User_Details.RowCount = 5;
            this.tbl_User_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_User_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_User_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_User_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_User_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_User_Details.Size = new System.Drawing.Size(708, 423);
            this.tbl_User_Details.TabIndex = 37;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(84, 25);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(223, 33);
            this.lbl_Username.TabIndex = 15;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Username.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(342, 22);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(241, 39);
            this.tb_Username.TabIndex = 16;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(84, 109);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(223, 33);
            this.lbl_Password.TabIndex = 17;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(84, 193);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(223, 33);
            this.lbl_Confirm_Password.TabIndex = 18;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            this.lbl_Confirm_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Treat_As
            // 
            this.lbl_Treat_As.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Treat_As.AutoSize = true;
            this.lbl_Treat_As.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Treat_As.Location = new System.Drawing.Point(84, 277);
            this.lbl_Treat_As.Name = "lbl_Treat_As";
            this.lbl_Treat_As.Size = new System.Drawing.Size(223, 33);
            this.lbl_Treat_As.TabIndex = 19;
            this.lbl_Treat_As.Text = "Treat As";
            this.lbl_Treat_As.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Security_Key
            // 
            this.lbl_Security_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Security_Key.AutoSize = true;
            this.lbl_Security_Key.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Security_Key.Location = new System.Drawing.Point(84, 363);
            this.lbl_Security_Key.Name = "lbl_Security_Key";
            this.lbl_Security_Key.Size = new System.Drawing.Size(223, 33);
            this.lbl_Security_Key.TabIndex = 20;
            this.lbl_Security_Key.Text = "Security Key";
            this.lbl_Security_Key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(342, 106);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(241, 39);
            this.tb_Password.TabIndex = 21;
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm_Password.Location = new System.Drawing.Point(342, 190);
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.Size = new System.Drawing.Size(241, 39);
            this.tb_Confirm_Password.TabIndex = 22;
            // 
            // tb_Security_Key
            // 
            this.tb_Security_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Security_Key.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Security_Key.Location = new System.Drawing.Point(342, 360);
            this.tb_Security_Key.Name = "tb_Security_Key";
            this.tb_Security_Key.Size = new System.Drawing.Size(241, 39);
            this.tb_Security_Key.TabIndex = 24;
            // 
            // cmb_Treat_As
            // 
            this.cmb_Treat_As.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Treat_As.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Treat_As.FormattingEnabled = true;
            this.cmb_Treat_As.Items.AddRange(new object[] {
            "Manager",
            "Employee",
            "Admin"});
            this.cmb_Treat_As.Location = new System.Drawing.Point(342, 273);
            this.cmb_Treat_As.Name = "cmb_Treat_As";
            this.cmb_Treat_As.Size = new System.Drawing.Size(241, 39);
            this.cmb_Treat_As.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 59);
            this.panel2.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.006198F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95938F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.3126F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.96563F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95445F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7253F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.8658F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00863F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Save, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Refresh, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(678, 53);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.AutoSize = true;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(404, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 43);
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
            this.btn_Refresh.Location = new System.Drawing.Point(118, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(125, 43);
            this.btn_Refresh.TabIndex = 24;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // pnl_Right_Border
            // 
            this.pnl_Right_Border.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_Right_Border.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Right_Border.Location = new System.Drawing.Point(857, 69);
            this.pnl_Right_Border.Name = "pnl_Right_Border";
            this.pnl_Right_Border.Size = new System.Drawing.Size(4, 518);
            this.pnl_Right_Border.TabIndex = 1;
            // 
            // pnl_Left_Border
            // 
            this.pnl_Left_Border.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_Left_Border.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Left_Border.Location = new System.Drawing.Point(93, 69);
            this.pnl_Left_Border.Name = "pnl_Left_Border";
            this.pnl_Left_Border.Size = new System.Drawing.Size(4, 518);
            this.pnl_Left_Border.TabIndex = 2;
            // 
            // tbllpnl_User_ID
            // 
            this.tbllpnl_User_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_User_ID.ColumnCount = 7;
            this.tbllpnl_User_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.008219F));
            this.tbllpnl_User_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.63889F));
            this.tbllpnl_User_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.69444F));
            this.tbllpnl_User_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91667F));
            this.tbllpnl_User_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80556F));
            this.tbllpnl_User_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.41667F));
            this.tbllpnl_User_ID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.182089F));
            this.tbllpnl_User_ID.Controls.Add(this.label1, 4, 0);
            this.tbllpnl_User_ID.Controls.Add(this.tb_ID, 2, 0);
            this.tbllpnl_User_ID.Controls.Add(this.lbl_ID, 1, 0);
            this.tbllpnl_User_ID.Controls.Add(this.tb_Date, 5, 0);
            this.tbllpnl_User_ID.Controls.Add(this.btn_Search, 3, 0);
            this.tbllpnl_User_ID.Location = new System.Drawing.Point(115, 3);
            this.tbllpnl_User_ID.Name = "tbllpnl_User_ID";
            this.tbllpnl_User_ID.RowCount = 1;
            this.tbllpnl_User_ID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllpnl_User_ID.Size = new System.Drawing.Size(720, 60);
            this.tbllpnl_User_ID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(137, 10);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(179, 39);
            this.tb_ID.TabIndex = 12;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(67, 13);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(43, 33);
            this.lbl_ID.TabIndex = 12;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Date
            // 
            this.tb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Date.Enabled = false;
            this.tb_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(536, 10);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(141, 39);
            this.tb_Date.TabIndex = 27;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(327, 11);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(113, 38);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.tbllpnl_Add_New_User);
            this.Controls.Add(this.pnl_Header);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Add_New_User";
            this.Text = "frm_Add_New_User";
            this.Load += new System.EventHandler(this.frm_Add_New_User_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.tbllpnl_Add_New_User.ResumeLayout(false);
            this.gb_User_Details.ResumeLayout(false);
            this.tbl_User_Details.ResumeLayout(false);
            this.tbl_User_Details.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tbllpnl_User_ID.ResumeLayout(false);
            this.tbllpnl_User_ID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_Add_New_User;
        private System.Windows.Forms.GroupBox gb_User_Details;
        private System.Windows.Forms.TableLayoutPanel tbl_User_Details;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_Treat_As;
        private System.Windows.Forms.Label lbl_Security_Key;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Security_Key;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel pnl_Right_Border;
        private System.Windows.Forms.Panel pnl_Left_Border;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_User_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.ComboBox cmb_Treat_As;
    }
}