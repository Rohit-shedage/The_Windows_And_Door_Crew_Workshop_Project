namespace Windows_And_Doors_Project_CS
{
    partial class frm_Edit_Prices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Edit_Prices));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Current_Selling_Prices = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price_Cost = new System.Windows.Forms.TextBox();
            this.lbl_Current_Selling_Price = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price_Cost = new System.Windows.Forms.Label();
            this.lbl_New_Prices = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_New_Price = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Sub_Name = new System.Windows.Forms.Label();
            this.lbl_Catagory = new System.Windows.Forms.Label();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Catagory = new System.Windows.Forms.ComboBox();
            this.gb_Select = new System.Windows.Forms.GroupBox();
            this.dgv_Edit_Prices = new System.Windows.Forms.DataGridView();
            this.pnl_Header.SuspendLayout();
            this.gb_Search.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_Select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Edit_Prices)).BeginInit();
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
            this.pnl_Header.Size = new System.Drawing.Size(1002, 79);
            this.pnl_Header.TabIndex = 15;
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
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(375, 12);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(229, 51);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Edit Prices";
            // 
            // gb_Search
            // 
            this.gb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Search.Controls.Add(this.tableLayoutPanel2);
            this.gb_Search.Controls.Add(this.tableLayoutPanel1);
            this.gb_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Search.Location = new System.Drawing.Point(12, 85);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Size = new System.Drawing.Size(978, 258);
            this.gb_Search.TabIndex = 16;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "Search";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.180685F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.95313F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.73438F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.994792F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78378F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.842752F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.299754F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Current_Selling_Prices, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Name, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Purchase_Price_Cost, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Current_Selling_Price, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Purchase_Price_Cost, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_New_Prices, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Update, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_New_Price, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(50, 92);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 160);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(20, 6);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(213, 33);
            this.lbl_Name.TabIndex = 31;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Current_Selling_Prices
            // 
            this.tb_Current_Selling_Prices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Current_Selling_Prices.Enabled = false;
            this.tb_Current_Selling_Prices.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Selling_Prices.Location = new System.Drawing.Point(246, 113);
            this.tb_Current_Selling_Prices.Name = "tb_Current_Selling_Prices";
            this.tb_Current_Selling_Prices.Size = new System.Drawing.Size(205, 39);
            this.tb_Current_Selling_Prices.TabIndex = 19;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(239, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(185, 39);
            this.tb_Name.TabIndex = 18;
            // 
            // tb_Purchase_Price_Cost
            // 
            this.tb_Purchase_Price_Cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Purchase_Price_Cost.Enabled = false;
            this.tb_Purchase_Price_Cost.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price_Cost.Location = new System.Drawing.Point(24, 113);
            this.tb_Purchase_Price_Cost.Name = "tb_Purchase_Price_Cost";
            this.tb_Purchase_Price_Cost.Size = new System.Drawing.Size(204, 39);
            this.tb_Purchase_Price_Cost.TabIndex = 20;
            // 
            // lbl_Current_Selling_Price
            // 
            this.lbl_Current_Selling_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Current_Selling_Price.AutoSize = true;
            this.lbl_Current_Selling_Price.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Selling_Price.Location = new System.Drawing.Point(239, 61);
            this.lbl_Current_Selling_Price.Name = "lbl_Current_Selling_Price";
            this.lbl_Current_Selling_Price.Size = new System.Drawing.Size(220, 29);
            this.lbl_Current_Selling_Price.TabIndex = 19;
            this.lbl_Current_Selling_Price.Text = "Current Selling Price";
            this.lbl_Current_Selling_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Purchase_Price_Cost
            // 
            this.lbl_Purchase_Price_Cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Purchase_Price_Cost.AutoSize = true;
            this.lbl_Purchase_Price_Cost.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price_Cost.Location = new System.Drawing.Point(68, 47);
            this.lbl_Purchase_Price_Cost.Name = "lbl_Purchase_Price_Cost";
            this.lbl_Purchase_Price_Cost.Size = new System.Drawing.Size(117, 58);
            this.lbl_Purchase_Price_Cost.TabIndex = 18;
            this.lbl_Purchase_Price_Cost.Text = "Purchase Price/Cost";
            this.lbl_Purchase_Price_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_New_Prices
            // 
            this.lbl_New_Prices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_New_Prices.AutoSize = true;
            this.lbl_New_Prices.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Prices.Location = new System.Drawing.Point(558, 6);
            this.lbl_New_Prices.Name = "lbl_New_Prices";
            this.lbl_New_Prices.Size = new System.Drawing.Size(130, 33);
            this.lbl_New_Prices.TabIndex = 17;
            this.lbl_New_Prices.Text = "New Price";
            this.lbl_New_Prices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_New_Prices.Click += new System.EventHandler(this.lbl_New_Prices_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(551, 113);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 39);
            this.btn_Update.TabIndex = 28;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_New_Price
            // 
            this.tb_New_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_New_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Price.Location = new System.Drawing.Point(547, 56);
            this.tb_New_Price.Name = "tb_New_Price";
            this.tb_New_Price.Size = new System.Drawing.Size(153, 39);
            this.tb_New_Price.TabIndex = 29;
            this.tb_New_Price.TextChanged += new System.EventHandler(this.tb_New_Price_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.006198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.59627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.94203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.75495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.8658F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00863F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Clear, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Sub_Name, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Catagory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Name, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Catagory, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 49);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(761, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(145, 43);
            this.btn_Clear.TabIndex = 27;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Sub_Name
            // 
            this.lbl_Sub_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sub_Name.AutoSize = true;
            this.lbl_Sub_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Name.Location = new System.Drawing.Point(474, 8);
            this.lbl_Sub_Name.Name = "lbl_Sub_Name";
            this.lbl_Sub_Name.Size = new System.Drawing.Size(79, 33);
            this.lbl_Sub_Name.TabIndex = 16;
            this.lbl_Sub_Name.Text = "Name";
            this.lbl_Sub_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Catagory
            // 
            this.lbl_Catagory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Catagory.AutoSize = true;
            this.lbl_Catagory.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catagory.Location = new System.Drawing.Point(61, 8);
            this.lbl_Catagory.Name = "lbl_Catagory";
            this.lbl_Catagory.Size = new System.Drawing.Size(115, 33);
            this.lbl_Catagory.TabIndex = 14;
            this.lbl_Catagory.Text = "Catagory";
            this.lbl_Catagory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Name
            // 
            this.cmb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(574, 5);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(175, 39);
            this.cmb_Name.TabIndex = 28;
            this.cmb_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Name_SelectedIndexChanged);
            // 
            // cmb_Catagory
            // 
            this.cmb_Catagory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Catagory.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catagory.FormattingEnabled = true;
            this.cmb_Catagory.Location = new System.Drawing.Point(192, 5);
            this.cmb_Catagory.Name = "cmb_Catagory";
            this.cmb_Catagory.Size = new System.Drawing.Size(148, 39);
            this.cmb_Catagory.TabIndex = 29;
            this.cmb_Catagory.SelectedIndexChanged += new System.EventHandler(this.cmb_Catagory_SelectedIndexChanged);
            // 
            // gb_Select
            // 
            this.gb_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Select.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Select.Controls.Add(this.dgv_Edit_Prices);
            this.gb_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Select.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Select.Location = new System.Drawing.Point(12, 361);
            this.gb_Select.Name = "gb_Select";
            this.gb_Select.Size = new System.Drawing.Size(978, 330);
            this.gb_Select.TabIndex = 17;
            this.gb_Select.TabStop = false;
            this.gb_Select.Text = "Select";
            // 
            // dgv_Edit_Prices
            // 
            this.dgv_Edit_Prices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Edit_Prices.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Edit_Prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Edit_Prices.Location = new System.Drawing.Point(6, 47);
            this.dgv_Edit_Prices.Name = "dgv_Edit_Prices";
            this.dgv_Edit_Prices.RowHeadersWidth = 51;
            this.dgv_Edit_Prices.RowTemplate.Height = 24;
            this.dgv_Edit_Prices.Size = new System.Drawing.Size(966, 267);
            this.dgv_Edit_Prices.TabIndex = 0;
            this.dgv_Edit_Prices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Edit_Prices_CellClick);
            // 
            // frm_Edit_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Select);
            this.Controls.Add(this.gb_Search);
            this.Controls.Add(this.pnl_Header);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Edit_Prices";
            this.Text = "Edit Prices";
            this.Load += new System.EventHandler(this.frm_Edit_Prices_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Search.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Edit_Prices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_New_Prices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Sub_Name;
        private System.Windows.Forms.Label lbl_Catagory;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.ComboBox cmb_Catagory;
        private System.Windows.Forms.Label lbl_Purchase_Price_Cost;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_New_Price;
        private System.Windows.Forms.Label lbl_Current_Selling_Price;
        private System.Windows.Forms.TextBox tb_Current_Selling_Prices;
        private System.Windows.Forms.TextBox tb_Purchase_Price_Cost;
        private System.Windows.Forms.GroupBox gb_Select;
        private System.Windows.Forms.DataGridView dgv_Edit_Prices;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Name;
    }
}