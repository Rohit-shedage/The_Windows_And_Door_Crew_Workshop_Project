namespace Windows_And_Doors_Project_CS
{
    partial class frm_Accept_New_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accept_New_Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gpb_Customer_Information = new System.Windows.Forms.GroupBox();
            this.tlpbl_Customer_Info_2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tlpnl_Customer_Info_1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gpb_Order_Details = new System.Windows.Forms.GroupBox();
            this.dgv_Order_Details = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_View_Product = new System.Windows.Forms.Button();
            this.tlpnl_Order_Details = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_Glass_Type = new System.Windows.Forms.ComboBox();
            this.cmb_Colour = new System.Windows.Forms.ComboBox();
            this.cmb_Material_Type = new System.Windows.Forms.ComboBox();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Glass_Type = new System.Windows.Forms.Label();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.lbl_Material_Type = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Pricce = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.tb_Width = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.tb_Height = new System.Windows.Forms.TextBox();
            this.lbl_Track = new System.Windows.Forms.Label();
            this.cmb_Track = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Update_Order = new System.Windows.Forms.Button();
            this.pnl_Radio_Button = new System.Windows.Forms.Panel();
            this.lbl_Order_ID = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.rbtn_Old_Customer = new System.Windows.Forms.RadioButton();
            this.rbtn_New_Customer = new System.Windows.Forms.RadioButton();
            this.pnl_Header.SuspendLayout();
            this.gpb_Customer_Information.SuspendLayout();
            this.tlpbl_Customer_Info_2.SuspendLayout();
            this.tlpnl_Customer_Info_1.SuspendLayout();
            this.gpb_Order_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Details)).BeginInit();
            this.panel1.SuspendLayout();
            this.tlpnl_Order_Details.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Radio_Button.SuspendLayout();
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
            this.pnl_Header.Size = new System.Drawing.Size(1002, 77);
            this.pnl_Header.TabIndex = 10;
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
            this.lbl_Header.Location = new System.Drawing.Point(317, 11);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(372, 51);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Accept New Order";
            // 
            // gpb_Customer_Information
            // 
            this.gpb_Customer_Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_Customer_Information.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpb_Customer_Information.Controls.Add(this.tlpbl_Customer_Info_2);
            this.gpb_Customer_Information.Controls.Add(this.tlpnl_Customer_Info_1);
            this.gpb_Customer_Information.Location = new System.Drawing.Point(12, 112);
            this.gpb_Customer_Information.Name = "gpb_Customer_Information";
            this.gpb_Customer_Information.Size = new System.Drawing.Size(978, 127);
            this.gpb_Customer_Information.TabIndex = 11;
            this.gpb_Customer_Information.TabStop = false;
            this.gpb_Customer_Information.Text = "Customer Information";
            // 
            // tlpbl_Customer_Info_2
            // 
            this.tlpbl_Customer_Info_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpbl_Customer_Info_2.ColumnCount = 8;
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.271199F));
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.6646F));
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.04555F));
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.45963F));
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08075F));
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63147F));
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35611F));
            this.tlpbl_Customer_Info_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.270769F));
            this.tlpbl_Customer_Info_2.Controls.Add(this.tb_Mobile_No, 4, 0);
            this.tlpbl_Customer_Info_2.Controls.Add(this.tb_Name, 2, 0);
            this.tlpbl_Customer_Info_2.Controls.Add(this.lbl_Address, 5, 0);
            this.tlpbl_Customer_Info_2.Controls.Add(this.lbl_Mobile_No, 3, 0);
            this.tlpbl_Customer_Info_2.Controls.Add(this.lbl_Name, 1, 0);
            this.tlpbl_Customer_Info_2.Controls.Add(this.tb_Address, 6, 0);
            this.tlpbl_Customer_Info_2.Location = new System.Drawing.Point(6, 76);
            this.tlpbl_Customer_Info_2.Name = "tlpbl_Customer_Info_2";
            this.tlpbl_Customer_Info_2.RowCount = 1;
            this.tlpbl_Customer_Info_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpbl_Customer_Info_2.Size = new System.Drawing.Size(966, 48);
            this.tlpbl_Customer_Info_2.TabIndex = 12;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(470, 4);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(159, 39);
            this.tb_Mobile_No.TabIndex = 16;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(156, 4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(149, 39);
            this.tb_Name.TabIndex = 13;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(635, 8);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(145, 31);
            this.lbl_Address.TabIndex = 15;
            this.lbl_Address.Text = "ADDRESS";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(311, 8);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(153, 31);
            this.lbl_Mobile_No.TabIndex = 14;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(24, 8);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(126, 31);
            this.lbl_Name.TabIndex = 13;
            this.lbl_Name.Text = "NAME";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(786, 4);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(152, 39);
            this.tb_Address.TabIndex = 17;
            // 
            // tlpnl_Customer_Info_1
            // 
            this.tlpnl_Customer_Info_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnl_Customer_Info_1.ColumnCount = 7;
            this.tlpnl_Customer_Info_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.449899F));
            this.tlpnl_Customer_Info_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.94123F));
            this.tlpnl_Customer_Info_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.25039F));
            this.tlpnl_Customer_Info_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72398F));
            this.tlpnl_Customer_Info_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.93907F));
            this.tlpnl_Customer_Info_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24999F));
            this.tlpnl_Customer_Info_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.44545F));
            this.tlpnl_Customer_Info_1.Controls.Add(this.dtp_Date, 5, 0);
            this.tlpnl_Customer_Info_1.Controls.Add(this.lbl_Date, 4, 0);
            this.tlpnl_Customer_Info_1.Controls.Add(this.tb_ID, 2, 0);
            this.tlpnl_Customer_Info_1.Controls.Add(this.lbl_ID, 1, 0);
            this.tlpnl_Customer_Info_1.Controls.Add(this.btn_Search, 3, 0);
            this.tlpnl_Customer_Info_1.Location = new System.Drawing.Point(6, 21);
            this.tlpnl_Customer_Info_1.Name = "tlpnl_Customer_Info_1";
            this.tlpnl_Customer_Info_1.RowCount = 1;
            this.tlpnl_Customer_Info_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnl_Customer_Info_1.Size = new System.Drawing.Size(966, 49);
            this.tlpnl_Customer_Info_1.TabIndex = 0;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(708, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(189, 39);
            this.dtp_Date.TabIndex = 12;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(604, 8);
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
            this.tb_ID.Location = new System.Drawing.Point(199, 5);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(189, 39);
            this.tb_ID.TabIndex = 12;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(107, 8);
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
            this.btn_Search.Location = new System.Drawing.Point(398, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 37);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gpb_Order_Details
            // 
            this.gpb_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_Order_Details.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpb_Order_Details.Controls.Add(this.dgv_Order_Details);
            this.gpb_Order_Details.Controls.Add(this.panel1);
            this.gpb_Order_Details.Controls.Add(this.tlpnl_Order_Details);
            this.gpb_Order_Details.Location = new System.Drawing.Point(12, 245);
            this.gpb_Order_Details.Name = "gpb_Order_Details";
            this.gpb_Order_Details.Size = new System.Drawing.Size(978, 415);
            this.gpb_Order_Details.TabIndex = 12;
            this.gpb_Order_Details.TabStop = false;
            this.gpb_Order_Details.Text = "Order Details";
            // 
            // dgv_Order_Details
            // 
            this.dgv_Order_Details.AllowUserToAddRows = false;
            this.dgv_Order_Details.AllowUserToDeleteRows = false;
            this.dgv_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Order_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order_Details.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgv_Order_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Order_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Order_Details.Location = new System.Drawing.Point(6, 193);
            this.dgv_Order_Details.Name = "dgv_Order_Details";
            this.dgv_Order_Details.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order_Details.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Order_Details.RowHeadersVisible = false;
            this.dgv_Order_Details.RowHeadersWidth = 51;
            this.dgv_Order_Details.RowTemplate.Height = 24;
            this.dgv_Order_Details.Size = new System.Drawing.Size(780, 216);
            this.dgv_Order_Details.TabIndex = 3;
            this.dgv_Order_Details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_Details_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tb_Total);
            this.panel1.Controls.Add(this.lbl_Total);
            this.panel1.Controls.Add(this.btn_View_Product);
            this.panel1.Location = new System.Drawing.Point(792, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 219);
            this.panel1.TabIndex = 1;
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(9, 61);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(162, 39);
            this.tb_Total.TabIndex = 27;
            this.tb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(3, 3);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(174, 43);
            this.lbl_Total.TabIndex = 26;
            this.lbl_Total.Text = "Total";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_View_Product
            // 
            this.btn_View_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_View_Product.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Product.Location = new System.Drawing.Point(0, 173);
            this.btn_View_Product.Name = "btn_View_Product";
            this.btn_View_Product.Size = new System.Drawing.Size(177, 43);
            this.btn_View_Product.TabIndex = 23;
            this.btn_View_Product.Text = "View Product";
            this.btn_View_Product.UseVisualStyleBackColor = true;
            // 
            // tlpnl_Order_Details
            // 
            this.tlpnl_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnl_Order_Details.ColumnCount = 7;
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.966874F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.84058F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.15114F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35611F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01035F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Glass_Type, 5, 1);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Colour, 4, 1);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Material_Type, 3, 1);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Product, 2, 1);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Category, 1, 1);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Glass_Type, 5, 0);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Colour, 4, 0);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Material_Type, 3, 0);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Product, 2, 0);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Category, 1, 0);
            this.tlpnl_Order_Details.Controls.Add(this.btn_Add, 6, 3);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Pricce, 5, 2);
            this.tlpnl_Order_Details.Controls.Add(this.tb_Price, 5, 3);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Quantity, 4, 2);
            this.tlpnl_Order_Details.Controls.Add(this.tb_Quantity, 4, 3);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Width, 3, 2);
            this.tlpnl_Order_Details.Controls.Add(this.tb_Width, 3, 3);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Height, 2, 2);
            this.tlpnl_Order_Details.Controls.Add(this.tb_Height, 2, 3);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Track, 1, 2);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Track, 1, 3);
            this.tlpnl_Order_Details.Location = new System.Drawing.Point(6, 21);
            this.tlpnl_Order_Details.Name = "tlpnl_Order_Details";
            this.tlpnl_Order_Details.RowCount = 4;
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.67917F));
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.38037F));
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.8589F));
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.44785F));
            this.tlpnl_Order_Details.Size = new System.Drawing.Size(966, 163);
            this.tlpnl_Order_Details.TabIndex = 0;
            // 
            // cmb_Glass_Type
            // 
            this.cmb_Glass_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Glass_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Glass_Type.FormattingEnabled = true;
            this.cmb_Glass_Type.Location = new System.Drawing.Point(731, 42);
            this.cmb_Glass_Type.Name = "cmb_Glass_Type";
            this.cmb_Glass_Type.Size = new System.Drawing.Size(139, 39);
            this.cmb_Glass_Type.TabIndex = 13;
            // 
            // cmb_Colour
            // 
            this.cmb_Colour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Colour.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Colour.FormattingEnabled = true;
            this.cmb_Colour.Location = new System.Drawing.Point(573, 42);
            this.cmb_Colour.Name = "cmb_Colour";
            this.cmb_Colour.Size = new System.Drawing.Size(152, 39);
            this.cmb_Colour.TabIndex = 14;
            // 
            // cmb_Material_Type
            // 
            this.cmb_Material_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Material_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Material_Type.FormattingEnabled = true;
            this.cmb_Material_Type.Items.AddRange(new object[] {
            "Jindal",
            "Non Jindal"});
            this.cmb_Material_Type.Location = new System.Drawing.Point(388, 42);
            this.cmb_Material_Type.Name = "cmb_Material_Type";
            this.cmb_Material_Type.Size = new System.Drawing.Size(179, 39);
            this.cmb_Material_Type.TabIndex = 15;
            // 
            // cmb_Product
            // 
            this.cmb_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Product.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Location = new System.Drawing.Point(204, 42);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(178, 39);
            this.cmb_Product.TabIndex = 16;
            this.cmb_Product.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_SelectedIndexChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Category.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(22, 42);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(176, 39);
            this.cmb_Category.TabIndex = 17;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_Glass_Type
            // 
            this.lbl_Glass_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Glass_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Glass_Type.Location = new System.Drawing.Point(731, 4);
            this.lbl_Glass_Type.Name = "lbl_Glass_Type";
            this.lbl_Glass_Type.Size = new System.Drawing.Size(139, 31);
            this.lbl_Glass_Type.TabIndex = 17;
            this.lbl_Glass_Type.Text = "Glass Type";
            this.lbl_Glass_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Colour.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Colour.Location = new System.Drawing.Point(573, 4);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(152, 31);
            this.lbl_Colour.TabIndex = 16;
            this.lbl_Colour.Text = "Colour";
            this.lbl_Colour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Material_Type
            // 
            this.lbl_Material_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Material_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Material_Type.Location = new System.Drawing.Point(388, 4);
            this.lbl_Material_Type.Name = "lbl_Material_Type";
            this.lbl_Material_Type.Size = new System.Drawing.Size(179, 31);
            this.lbl_Material_Type.TabIndex = 15;
            this.lbl_Material_Type.Text = "Material Type";
            this.lbl_Material_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Product
            // 
            this.lbl_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(204, 4);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(178, 31);
            this.lbl_Product.TabIndex = 15;
            this.lbl_Product.Text = "Product";
            this.lbl_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(22, 4);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(176, 31);
            this.lbl_Category.TabIndex = 14;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(876, 117);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 43);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Pricce
            // 
            this.lbl_Pricce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pricce.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pricce.Location = new System.Drawing.Point(731, 82);
            this.lbl_Pricce.Name = "lbl_Pricce";
            this.lbl_Pricce.Size = new System.Drawing.Size(139, 31);
            this.lbl_Pricce.TabIndex = 21;
            this.lbl_Pricce.Text = "Price";
            this.lbl_Pricce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Price
            // 
            this.tb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(731, 119);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(139, 39);
            this.tb_Price.TabIndex = 15;
            this.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(573, 82);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(152, 31);
            this.lbl_Quantity.TabIndex = 20;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(573, 119);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(152, 39);
            this.tb_Quantity.TabIndex = 14;
            this.tb_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Width
            // 
            this.lbl_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Width.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Width.Location = new System.Drawing.Point(388, 82);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(179, 31);
            this.lbl_Width.TabIndex = 18;
            this.lbl_Width.Text = "Width";
            this.lbl_Width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Width
            // 
            this.tb_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Width.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Width.Location = new System.Drawing.Point(388, 119);
            this.tb_Width.Name = "tb_Width";
            this.tb_Width.Size = new System.Drawing.Size(179, 39);
            this.tb_Width.TabIndex = 16;
            this.tb_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Height
            // 
            this.lbl_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Height.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.Location = new System.Drawing.Point(204, 82);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(178, 31);
            this.lbl_Height.TabIndex = 19;
            this.lbl_Height.Text = "Height";
            this.lbl_Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Height
            // 
            this.tb_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Height.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Height.Location = new System.Drawing.Point(204, 119);
            this.tb_Height.Name = "tb_Height";
            this.tb_Height.Size = new System.Drawing.Size(178, 39);
            this.tb_Height.TabIndex = 17;
            this.tb_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Track
            // 
            this.lbl_Track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Track.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Track.Location = new System.Drawing.Point(22, 82);
            this.lbl_Track.Name = "lbl_Track";
            this.lbl_Track.Size = new System.Drawing.Size(176, 31);
            this.lbl_Track.TabIndex = 25;
            this.lbl_Track.Text = "Track";
            this.lbl_Track.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Track
            // 
            this.cmb_Track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Track.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Track.FormattingEnabled = true;
            this.cmb_Track.Location = new System.Drawing.Point(22, 118);
            this.cmb_Track.Name = "cmb_Track";
            this.cmb_Track.Size = new System.Drawing.Size(176, 39);
            this.cmb_Track.TabIndex = 26;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(96, 11);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(187, 43);
            this.btn_Refresh.TabIndex = 24;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Next.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(738, 11);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(187, 43);
            this.btn_Next.TabIndex = 25;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Update_Order);
            this.panel2.Controls.Add(this.btn_Next);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 666);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 66);
            this.panel2.TabIndex = 26;
            // 
            // btn_Update_Order
            // 
            this.btn_Update_Order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update_Order.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Order.Location = new System.Drawing.Point(408, 12);
            this.btn_Update_Order.Name = "btn_Update_Order";
            this.btn_Update_Order.Size = new System.Drawing.Size(187, 43);
            this.btn_Update_Order.TabIndex = 26;
            this.btn_Update_Order.Text = "Update";
            this.btn_Update_Order.UseVisualStyleBackColor = true;
            this.btn_Update_Order.Visible = false;
            // 
            // pnl_Radio_Button
            // 
            this.pnl_Radio_Button.Controls.Add(this.lbl_Order_ID);
            this.pnl_Radio_Button.Controls.Add(this.lbl);
            this.pnl_Radio_Button.Controls.Add(this.rbtn_Old_Customer);
            this.pnl_Radio_Button.Controls.Add(this.rbtn_New_Customer);
            this.pnl_Radio_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Radio_Button.Location = new System.Drawing.Point(0, 77);
            this.pnl_Radio_Button.Name = "pnl_Radio_Button";
            this.pnl_Radio_Button.Size = new System.Drawing.Size(1002, 31);
            this.pnl_Radio_Button.TabIndex = 27;
            // 
            // lbl_Order_ID
            // 
            this.lbl_Order_ID.AutoSize = true;
            this.lbl_Order_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_ID.Location = new System.Drawing.Point(126, 2);
            this.lbl_Order_ID.Name = "lbl_Order_ID";
            this.lbl_Order_ID.Size = new System.Drawing.Size(37, 27);
            this.lbl_Order_ID.TabIndex = 5;
            this.lbl_Order_ID.Text = "ID";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(3, 2);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(125, 27);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Order ID :- ";
            // 
            // rbtn_Old_Customer
            // 
            this.rbtn_Old_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Old_Customer.AutoSize = true;
            this.rbtn_Old_Customer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Old_Customer.Location = new System.Drawing.Point(538, 2);
            this.rbtn_Old_Customer.Name = "rbtn_Old_Customer";
            this.rbtn_Old_Customer.Size = new System.Drawing.Size(151, 29);
            this.rbtn_Old_Customer.TabIndex = 1;
            this.rbtn_Old_Customer.TabStop = true;
            this.rbtn_Old_Customer.Text = "Old Customer";
            this.rbtn_Old_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Old_Customer.UseVisualStyleBackColor = true;
            this.rbtn_Old_Customer.CheckedChanged += new System.EventHandler(this.rbtn_Old_Customer_CheckedChanged);
            // 
            // rbtn_New_Customer
            // 
            this.rbtn_New_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_New_Customer.AutoSize = true;
            this.rbtn_New_Customer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_New_Customer.Location = new System.Drawing.Point(270, 2);
            this.rbtn_New_Customer.Name = "rbtn_New_Customer";
            this.rbtn_New_Customer.Size = new System.Drawing.Size(160, 29);
            this.rbtn_New_Customer.TabIndex = 0;
            this.rbtn_New_Customer.TabStop = true;
            this.rbtn_New_Customer.Text = "New Customer";
            this.rbtn_New_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_New_Customer.UseVisualStyleBackColor = true;
            // 
            // frm_Accept_New_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Radio_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gpb_Order_Details);
            this.Controls.Add(this.gpb_Customer_Information);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Accept_New_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accept New Order";
            this.Load += new System.EventHandler(this.frm_Accept_New_Order_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gpb_Customer_Information.ResumeLayout(false);
            this.tlpbl_Customer_Info_2.ResumeLayout(false);
            this.tlpbl_Customer_Info_2.PerformLayout();
            this.tlpnl_Customer_Info_1.ResumeLayout(false);
            this.tlpnl_Customer_Info_1.PerformLayout();
            this.gpb_Order_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Details)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpnl_Order_Details.ResumeLayout(false);
            this.tlpnl_Order_Details.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_Radio_Button.ResumeLayout(false);
            this.pnl_Radio_Button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gpb_Customer_Information;
        private System.Windows.Forms.TableLayoutPanel tlpnl_Customer_Info_1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TableLayoutPanel tlpbl_Customer_Info_2;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.GroupBox gpb_Order_Details;
        private System.Windows.Forms.TableLayoutPanel tlpnl_Order_Details;
        private System.Windows.Forms.Label lbl_Material_Type;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Pricce;
        private System.Windows.Forms.Label lbl_Glass_Type;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Width;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Height;
        private System.Windows.Forms.ComboBox cmb_Glass_Type;
        private System.Windows.Forms.ComboBox cmb_Colour;
        private System.Windows.Forms.ComboBox cmb_Material_Type;
        private System.Windows.Forms.ComboBox cmb_Product;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_View_Product;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Radio_Button;
        private System.Windows.Forms.RadioButton rbtn_New_Customer;
        private System.Windows.Forms.RadioButton rbtn_Old_Customer;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update_Order;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Track;
        private System.Windows.Forms.ComboBox cmb_Track;
        private System.Windows.Forms.DataGridView dgv_Order_Details;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Order_ID;
        private System.Windows.Forms.Label lbl;
    }
}