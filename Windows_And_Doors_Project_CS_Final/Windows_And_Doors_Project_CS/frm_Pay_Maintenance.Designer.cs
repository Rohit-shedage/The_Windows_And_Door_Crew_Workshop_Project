namespace Windows_And_Doors_Project_CS
{
    partial class frm_Pay_Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pay_Maintenance));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Maintenance = new System.Windows.Forms.GroupBox();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.gb_To_Be_Paid = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_To_Be_Paid_Total = new System.Windows.Forms.Label();
            this.tb_To_Be_Paid_Total = new System.Windows.Forms.TextBox();
            this.btn_Pay_All = new System.Windows.Forms.Button();
            this.dgv_To_Be_Paid = new System.Windows.Forms.DataGridView();
            this.gb_Recently_Paid = new System.Windows.Forms.GroupBox();
            this.dgv_Recently_Paid = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.pnl_Header.SuspendLayout();
            this.gb_Maintenance.SuspendLayout();
            this.gb_To_Be_Paid.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_To_Be_Paid)).BeginInit();
            this.gb_Recently_Paid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recently_Paid)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.pnl_Header.TabIndex = 31;
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
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(317, 14);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(312, 49);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Pay Maintenance";
            // 
            // gb_Maintenance
            // 
            this.gb_Maintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Maintenance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Maintenance.Controls.Add(this.tableLayoutPanel1);
            this.gb_Maintenance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Maintenance.Location = new System.Drawing.Point(12, 89);
            this.gb_Maintenance.Name = "gb_Maintenance";
            this.gb_Maintenance.Size = new System.Drawing.Size(978, 125);
            this.gb_Maintenance.TabIndex = 32;
            this.gb_Maintenance.TabStop = false;
            this.gb_Maintenance.Text = "Maintenance";
            // 
            // btn_Pay
            // 
            this.btn_Pay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.Location = new System.Drawing.Point(729, 55);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(125, 46);
            this.btn_Pay.TabIndex = 27;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = false;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(563, 9);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(71, 33);
            this.lbl_Total.TabIndex = 16;
            this.lbl_Total.Text = "Total";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(495, 58);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(207, 39);
            this.tb_Total.TabIndex = 15;
            // 
            // lbl_Month
            // 
            this.lbl_Month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Month.Location = new System.Drawing.Point(146, 9);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(90, 33);
            this.lbl_Month.TabIndex = 14;
            this.lbl_Month.Text = "Month";
            this.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Month
            // 
            this.cmb_Month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Month.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Location = new System.Drawing.Point(88, 58);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(207, 39);
            this.cmb_Month.TabIndex = 31;
            // 
            // gb_To_Be_Paid
            // 
            this.gb_To_Be_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_To_Be_Paid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_To_Be_Paid.Controls.Add(this.tableLayoutPanel2);
            this.gb_To_Be_Paid.Controls.Add(this.dgv_To_Be_Paid);
            this.gb_To_Be_Paid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_To_Be_Paid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_To_Be_Paid.Location = new System.Drawing.Point(3, 3);
            this.gb_To_Be_Paid.Name = "gb_To_Be_Paid";
            this.gb_To_Be_Paid.Size = new System.Drawing.Size(483, 465);
            this.gb_To_Be_Paid.TabIndex = 33;
            this.gb_To_Be_Paid.TabStop = false;
            this.gb_To_Be_Paid.Text = "To Be Paid";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.08772F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.2193F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.85088F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.4386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.96491F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_To_Be_Paid_Total, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_To_Be_Paid_Total, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Pay_All, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 407);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_To_Be_Paid_Total
            // 
            this.lbl_To_Be_Paid_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_To_Be_Paid_Total.AutoSize = true;
            this.lbl_To_Be_Paid_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To_Be_Paid_Total.Location = new System.Drawing.Point(66, 4);
            this.lbl_To_Be_Paid_Total.Name = "lbl_To_Be_Paid_Total";
            this.lbl_To_Be_Paid_Total.Size = new System.Drawing.Size(71, 33);
            this.lbl_To_Be_Paid_Total.TabIndex = 17;
            this.lbl_To_Be_Paid_Total.Text = "Total";
            this.lbl_To_Be_Paid_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_To_Be_Paid_Total
            // 
            this.tb_To_Be_Paid_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_To_Be_Paid_Total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_To_Be_Paid_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_To_Be_Paid_Total.Location = new System.Drawing.Point(162, 3);
            this.tb_To_Be_Paid_Total.Name = "tb_To_Be_Paid_Total";
            this.tb_To_Be_Paid_Total.Size = new System.Drawing.Size(120, 39);
            this.tb_To_Be_Paid_Total.TabIndex = 18;
            // 
            // btn_Pay_All
            // 
            this.btn_Pay_All.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pay_All.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Pay_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay_All.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay_All.Location = new System.Drawing.Point(288, 3);
            this.btn_Pay_All.Name = "btn_Pay_All";
            this.btn_Pay_All.Size = new System.Drawing.Size(109, 36);
            this.btn_Pay_All.TabIndex = 28;
            this.btn_Pay_All.Text = "Pay All";
            this.btn_Pay_All.UseVisualStyleBackColor = false;
            // 
            // dgv_To_Be_Paid
            // 
            this.dgv_To_Be_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_To_Be_Paid.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_To_Be_Paid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_To_Be_Paid.Location = new System.Drawing.Point(16, 26);
            this.dgv_To_Be_Paid.Name = "dgv_To_Be_Paid";
            this.dgv_To_Be_Paid.RowHeadersWidth = 51;
            this.dgv_To_Be_Paid.RowTemplate.Height = 24;
            this.dgv_To_Be_Paid.Size = new System.Drawing.Size(451, 353);
            this.dgv_To_Be_Paid.TabIndex = 0;
            // 
            // gb_Recently_Paid
            // 
            this.gb_Recently_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Recently_Paid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Recently_Paid.Controls.Add(this.dgv_Recently_Paid);
            this.gb_Recently_Paid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Recently_Paid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Recently_Paid.Location = new System.Drawing.Point(492, 3);
            this.gb_Recently_Paid.Name = "gb_Recently_Paid";
            this.gb_Recently_Paid.Size = new System.Drawing.Size(483, 465);
            this.gb_Recently_Paid.TabIndex = 34;
            this.gb_Recently_Paid.TabStop = false;
            this.gb_Recently_Paid.Text = "Recently Paid";
            // 
            // dgv_Recently_Paid
            // 
            this.dgv_Recently_Paid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Recently_Paid.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_Recently_Paid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recently_Paid.Location = new System.Drawing.Point(16, 26);
            this.dgv_Recently_Paid.Name = "dgv_Recently_Paid";
            this.dgv_Recently_Paid.RowHeadersWidth = 51;
            this.dgv_Recently_Paid.RowTemplate.Height = 24;
            this.dgv_Recently_Paid.Size = new System.Drawing.Size(451, 433);
            this.dgv_Recently_Paid.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitter2.Location = new System.Drawing.Point(0, 83);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 649);
            this.splitter2.TabIndex = 35;
            this.splitter2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gb_To_Be_Paid, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gb_Recently_Paid, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 220);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 471);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.84656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08282F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.84656F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Month, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Month, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Pay, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Total, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Year, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Year, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Year
            // 
            this.lbl_Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Location = new System.Drawing.Point(362, 9);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(65, 33);
            this.lbl_Year.TabIndex = 32;
            this.lbl_Year.Text = "Year";
            this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Year
            // 
            this.cmb_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Year.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Location = new System.Drawing.Point(301, 58);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(188, 39);
            this.cmb_Year.TabIndex = 33;
            // 
            // frm_Pay_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.gb_Maintenance);
            this.Controls.Add(this.pnl_Header);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Pay_Maintenance";
            this.Text = "frm_Pay_Maintenance";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Maintenance.ResumeLayout(false);
            this.gb_To_Be_Paid.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_To_Be_Paid)).EndInit();
            this.gb_Recently_Paid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recently_Paid)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Maintenance;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.GroupBox gb_To_Be_Paid;
        private System.Windows.Forms.DataGridView dgv_To_Be_Paid;
        private System.Windows.Forms.GroupBox gb_Recently_Paid;
        private System.Windows.Forms.DataGridView dgv_Recently_Paid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_To_Be_Paid_Total;
        private System.Windows.Forms.TextBox tb_To_Be_Paid_Total;
        private System.Windows.Forms.Button btn_Pay_All;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.ComboBox cmb_Year;
    }
}