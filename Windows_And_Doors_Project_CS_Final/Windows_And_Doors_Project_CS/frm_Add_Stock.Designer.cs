namespace Windows_And_Doors_Project_CS
{
    partial class frm_Add_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Stock));
            this.gpb_Order_Details = new System.Windows.Forms.GroupBox();
            this.dgv_Remove = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Paid = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Paid = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.dgv_Order_Details = new System.Windows.Forms.DataGridView();
            this.tlpnl_Order_Details = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Available = new System.Windows.Forms.TextBox();
            this.cmb_Colour = new System.Windows.Forms.ComboBox();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.lbl_Material_Type = new System.Windows.Forms.Label();
            this.cmb_Material_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Track = new System.Windows.Forms.Label();
            this.cmb_Track = new System.Windows.Forms.ComboBox();
            this.lbl_Purchase_Prize = new System.Windows.Forms.Label();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.gb_Select_Product_Distributor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.cmb_Distributor = new System.Windows.Forms.ComboBox();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.cmb_Material = new System.Windows.Forms.ComboBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Order_Details = new System.Windows.Forms.GroupBox();
            this.tbllpnl_Order_Details = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gpb_Order_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Remove)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Details)).BeginInit();
            this.tlpnl_Order_Details.SuspendLayout();
            this.gb_Select_Product_Distributor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.gb_Order_Details.SuspendLayout();
            this.tbllpnl_Order_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Order_Details
            // 
            this.gpb_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_Order_Details.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpb_Order_Details.Controls.Add(this.dgv_Remove);
            this.gpb_Order_Details.Controls.Add(this.tableLayoutPanel3);
            this.gpb_Order_Details.Controls.Add(this.dgv_Order_Details);
            this.gpb_Order_Details.Controls.Add(this.tlpnl_Order_Details);
            this.gpb_Order_Details.Location = new System.Drawing.Point(12, 279);
            this.gpb_Order_Details.Name = "gpb_Order_Details";
            this.gpb_Order_Details.Size = new System.Drawing.Size(978, 355);
            this.gpb_Order_Details.TabIndex = 22;
            this.gpb_Order_Details.TabStop = false;
            this.gpb_Order_Details.Text = "Order Details";
            // 
            // dgv_Remove
            // 
            this.dgv_Remove.AllowUserToAddRows = false;
            this.dgv_Remove.AllowUserToDeleteRows = false;
            this.dgv_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Remove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Remove.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgv_Remove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Remove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Remove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Remove.Location = new System.Drawing.Point(877, 183);
            this.dgv_Remove.MinimumSize = new System.Drawing.Size(95, 100);
            this.dgv_Remove.Name = "dgv_Remove";
            this.dgv_Remove.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Remove.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Remove.RowHeadersVisible = false;
            this.dgv_Remove.RowHeadersWidth = 51;
            this.dgv_Remove.RowTemplate.Height = 24;
            this.dgv_Remove.Size = new System.Drawing.Size(95, 114);
            this.dgv_Remove.TabIndex = 4;
            this.dgv_Remove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Remove_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.42236F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21532F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49482F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.52588F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.6294F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.9441F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.tb_Paid, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Total, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Paid, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Total, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 297);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(966, 52);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tb_Paid
            // 
            this.tb_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Paid.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid.Location = new System.Drawing.Point(648, 6);
            this.tb_Paid.Name = "tb_Paid";
            this.tb_Paid.Size = new System.Drawing.Size(176, 39);
            this.tb_Paid.TabIndex = 24;
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(239, 6);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(162, 39);
            this.tb_Total.TabIndex = 25;
            // 
            // lbl_Paid
            // 
            this.lbl_Paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Paid.AutoSize = true;
            this.lbl_Paid.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid.Location = new System.Drawing.Point(552, 9);
            this.lbl_Paid.Name = "lbl_Paid";
            this.lbl_Paid.Size = new System.Drawing.Size(65, 33);
            this.lbl_Paid.TabIndex = 16;
            this.lbl_Paid.Text = "Paid";
            this.lbl_Paid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(142, 9);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(71, 33);
            this.lbl_Total.TabIndex = 14;
            this.lbl_Total.Text = "Total";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Order_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order_Details.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Order_Details.Location = new System.Drawing.Point(6, 184);
            this.dgv_Order_Details.Name = "dgv_Order_Details";
            this.dgv_Order_Details.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order_Details.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Order_Details.RowHeadersVisible = false;
            this.dgv_Order_Details.RowHeadersWidth = 51;
            this.dgv_Order_Details.RowTemplate.Height = 24;
            this.dgv_Order_Details.Size = new System.Drawing.Size(872, 113);
            this.dgv_Order_Details.TabIndex = 2;
            this.dgv_Order_Details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_Details_CellClick);
            // 
            // tlpnl_Order_Details
            // 
            this.tlpnl_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnl_Order_Details.ColumnCount = 6;
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.322939F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.33769F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.33769F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.33769F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.33769F));
            this.tlpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.326293F));
            this.tlpnl_Order_Details.Controls.Add(this.btn_Add, 4, 3);
            this.tlpnl_Order_Details.Controls.Add(this.tb_Available, 2, 1);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Colour, 3, 1);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Colour, 3, 0);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Size, 4, 0);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Available, 2, 0);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Material_Type, 1, 0);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Material_Type, 1, 1);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Track, 1, 2);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Track, 1, 3);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Purchase_Prize, 3, 2);
            this.tlpnl_Order_Details.Controls.Add(this.tb_Purchase_Price, 3, 3);
            this.tlpnl_Order_Details.Controls.Add(this.lbl_Quantity, 2, 2);
            this.tlpnl_Order_Details.Controls.Add(this.tb_Quantity, 2, 3);
            this.tlpnl_Order_Details.Controls.Add(this.cmb_Size, 4, 1);
            this.tlpnl_Order_Details.Location = new System.Drawing.Point(6, 21);
            this.tlpnl_Order_Details.Name = "tlpnl_Order_Details";
            this.tlpnl_Order_Details.RowCount = 4;
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34653F));
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.0248F));
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.57775F));
            this.tlpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.05093F));
            this.tlpnl_Order_Details.Size = new System.Drawing.Size(966, 156);
            this.tlpnl_Order_Details.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(734, 112);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(138, 41);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Available
            // 
            this.tb_Available.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Available.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Available.Location = new System.Drawing.Point(269, 40);
            this.tb_Available.Name = "tb_Available";
            this.tb_Available.Size = new System.Drawing.Size(209, 39);
            this.tb_Available.TabIndex = 23;
            // 
            // cmb_Colour
            // 
            this.cmb_Colour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Colour.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Colour.FormattingEnabled = true;
            this.cmb_Colour.Location = new System.Drawing.Point(484, 40);
            this.cmb_Colour.Name = "cmb_Colour";
            this.cmb_Colour.Size = new System.Drawing.Size(209, 39);
            this.cmb_Colour.TabIndex = 17;
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Colour.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Colour.Location = new System.Drawing.Point(484, 3);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(209, 31);
            this.lbl_Colour.TabIndex = 14;
            this.lbl_Colour.Text = "Colour";
            this.lbl_Colour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Size
            // 
            this.lbl_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Size.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(699, 3);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(209, 31);
            this.lbl_Size.TabIndex = 16;
            this.lbl_Size.Text = "Size";
            this.lbl_Size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Available
            // 
            this.lbl_Available.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Available.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Available.Location = new System.Drawing.Point(269, 3);
            this.lbl_Available.Name = "lbl_Available";
            this.lbl_Available.Size = new System.Drawing.Size(209, 31);
            this.lbl_Available.TabIndex = 15;
            this.lbl_Available.Text = "Available";
            this.lbl_Available.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Material_Type
            // 
            this.lbl_Material_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Material_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Material_Type.Location = new System.Drawing.Point(54, 3);
            this.lbl_Material_Type.Name = "lbl_Material_Type";
            this.lbl_Material_Type.Size = new System.Drawing.Size(209, 31);
            this.lbl_Material_Type.TabIndex = 15;
            this.lbl_Material_Type.Text = "Material Type";
            this.lbl_Material_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Material_Type
            // 
            this.cmb_Material_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Material_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Material_Type.FormattingEnabled = true;
            this.cmb_Material_Type.Location = new System.Drawing.Point(54, 40);
            this.cmb_Material_Type.Name = "cmb_Material_Type";
            this.cmb_Material_Type.Size = new System.Drawing.Size(209, 39);
            this.cmb_Material_Type.TabIndex = 15;
            // 
            // lbl_Track
            // 
            this.lbl_Track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Track.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Track.Location = new System.Drawing.Point(54, 77);
            this.lbl_Track.Name = "lbl_Track";
            this.lbl_Track.Size = new System.Drawing.Size(209, 31);
            this.lbl_Track.TabIndex = 19;
            this.lbl_Track.Text = "Track";
            this.lbl_Track.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Track
            // 
            this.cmb_Track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Track.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Track.FormattingEnabled = true;
            this.cmb_Track.Location = new System.Drawing.Point(54, 112);
            this.cmb_Track.Name = "cmb_Track";
            this.cmb_Track.Size = new System.Drawing.Size(209, 39);
            this.cmb_Track.TabIndex = 24;
            // 
            // lbl_Purchase_Prize
            // 
            this.lbl_Purchase_Prize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Purchase_Prize.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Prize.Location = new System.Drawing.Point(484, 77);
            this.lbl_Purchase_Prize.Name = "lbl_Purchase_Prize";
            this.lbl_Purchase_Prize.Size = new System.Drawing.Size(209, 31);
            this.lbl_Purchase_Prize.TabIndex = 18;
            this.lbl_Purchase_Prize.Text = "Purchase Price";
            this.lbl_Purchase_Prize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(484, 113);
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(209, 39);
            this.tb_Purchase_Price.TabIndex = 16;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(269, 77);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(209, 31);
            this.lbl_Quantity.TabIndex = 20;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(269, 113);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(209, 39);
            this.tb_Quantity.TabIndex = 14;
            // 
            // cmb_Size
            // 
            this.cmb_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Size.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(699, 40);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(209, 39);
            this.cmb_Size.TabIndex = 25;
            // 
            // gb_Select_Product_Distributor
            // 
            this.gb_Select_Product_Distributor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Select_Product_Distributor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Select_Product_Distributor.Controls.Add(this.tableLayoutPanel2);
            this.gb_Select_Product_Distributor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Select_Product_Distributor.Location = new System.Drawing.Point(12, 184);
            this.gb_Select_Product_Distributor.Name = "gb_Select_Product_Distributor";
            this.gb_Select_Product_Distributor.Size = new System.Drawing.Size(978, 89);
            this.gb_Select_Product_Distributor.TabIndex = 20;
            this.gb_Select_Product_Distributor.TabStop = false;
            this.gb_Select_Product_Distributor.Text = "Select Product Distributor";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.90683F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.11594F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.69772F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.73499F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.97723F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Distributor_Name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Distributor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Material, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Material, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_New, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(966, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(73, 9);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(138, 33);
            this.lbl_Distributor_Name.TabIndex = 16;
            this.lbl_Distributor_Name.Text = "Distributor";
            this.lbl_Distributor_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Distributor
            // 
            this.cmb_Distributor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Distributor.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distributor.FormattingEnabled = true;
            this.cmb_Distributor.Location = new System.Drawing.Point(217, 6);
            this.cmb_Distributor.Name = "cmb_Distributor";
            this.cmb_Distributor.Size = new System.Drawing.Size(169, 39);
            this.cmb_Distributor.TabIndex = 23;
            this.cmb_Distributor.SelectedIndexChanged += new System.EventHandler(this.cmb_Distributor_SelectedIndexChanged);
            // 
            // lbl_Material
            // 
            this.lbl_Material.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Material.Location = new System.Drawing.Point(523, 9);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(109, 33);
            this.lbl_Material.TabIndex = 14;
            this.lbl_Material.Text = "Material";
            this.lbl_Material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Material
            // 
            this.cmb_Material.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Material.FormattingEnabled = true;
            this.cmb_Material.Location = new System.Drawing.Point(657, 6);
            this.cmb_Material.Name = "cmb_Material";
            this.cmb_Material.Size = new System.Drawing.Size(158, 39);
            this.cmb_Material.TabIndex = 24;
            this.cmb_Material.SelectedIndexChanged += new System.EventHandler(this.cmb_Material_SelectedIndexChanged);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_New.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(828, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(127, 43);
            this.btn_New.TabIndex = 28;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
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
            this.pnl_Header.TabIndex = 18;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(927, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 41);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(317, 14);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(316, 51);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add New Stock";
            // 
            // gb_Order_Details
            // 
            this.gb_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Order_Details.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Order_Details.Controls.Add(this.tbllpnl_Order_Details);
            this.gb_Order_Details.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Order_Details.Location = new System.Drawing.Point(12, 89);
            this.gb_Order_Details.Name = "gb_Order_Details";
            this.gb_Order_Details.Size = new System.Drawing.Size(978, 89);
            this.gb_Order_Details.TabIndex = 19;
            this.gb_Order_Details.TabStop = false;
            this.gb_Order_Details.Text = "Order Details";
            // 
            // tbllpnl_Order_Details
            // 
            this.tbllpnl_Order_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllpnl_Order_Details.ColumnCount = 7;
            this.tbllpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.109731F));
            this.tbllpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83644F));
            this.tbllpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.21946F));
            this.tbllpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.35404F));
            this.tbllpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.56108F));
            this.tbllpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35611F));
            this.tbllpnl_Order_Details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.45963F));
            this.tbllpnl_Order_Details.Controls.Add(this.lbl_Date, 4, 0);
            this.tbllpnl_Order_Details.Controls.Add(this.tb_date, 5, 0);
            this.tbllpnl_Order_Details.Controls.Add(this.tb_ID, 2, 0);
            this.tbllpnl_Order_Details.Controls.Add(this.lbl_ID, 1, 0);
            this.tbllpnl_Order_Details.Controls.Add(this.btn_Search, 3, 0);
            this.tbllpnl_Order_Details.Location = new System.Drawing.Point(6, 26);
            this.tbllpnl_Order_Details.Name = "tbllpnl_Order_Details";
            this.tbllpnl_Order_Details.RowCount = 1;
            this.tbllpnl_Order_Details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllpnl_Order_Details.Size = new System.Drawing.Size(966, 52);
            this.tbllpnl_Order_Details.TabIndex = 0;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(549, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(67, 33);
            this.lbl_Date.TabIndex = 16;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_date
            // 
            this.tb_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_date.Enabled = false;
            this.tb_date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.Location = new System.Drawing.Point(651, 6);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(152, 39);
            this.tb_date.TabIndex = 15;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(215, 6);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(170, 39);
            this.tb_ID.TabIndex = 13;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(128, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(43, 33);
            this.lbl_ID.TabIndex = 14;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(391, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(123, 37);
            this.btn_Search.TabIndex = 27;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(87, 10);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(187, 43);
            this.btn_Refresh.TabIndex = 26;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 669);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 63);
            this.panel1.TabIndex = 21;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(729, 10);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(187, 43);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.gpb_Order_Details);
            this.Controls.Add(this.gb_Select_Product_Distributor);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.gb_Order_Details);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Add_Stock";
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.gpb_Order_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Remove)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_Details)).EndInit();
            this.tlpnl_Order_Details.ResumeLayout(false);
            this.tlpnl_Order_Details.PerformLayout();
            this.gb_Select_Product_Distributor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Order_Details.ResumeLayout(false);
            this.tbllpnl_Order_Details.ResumeLayout(false);
            this.tbllpnl_Order_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Order_Details;
        private System.Windows.Forms.DataGridView dgv_Remove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb_Paid;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Paid;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.DataGridView dgv_Order_Details;
        private System.Windows.Forms.TableLayoutPanel tlpnl_Order_Details;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Available;
        private System.Windows.Forms.ComboBox cmb_Colour;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.Label lbl_Material_Type;
        private System.Windows.Forms.ComboBox cmb_Material_Type;
        private System.Windows.Forms.Label lbl_Track;
        private System.Windows.Forms.ComboBox cmb_Track;
        private System.Windows.Forms.Label lbl_Purchase_Prize;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.GroupBox gb_Select_Product_Distributor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.ComboBox cmb_Distributor;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.ComboBox cmb_Material;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Order_Details;
        private System.Windows.Forms.TableLayoutPanel tbllpnl_Order_Details;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Save;
    }
}