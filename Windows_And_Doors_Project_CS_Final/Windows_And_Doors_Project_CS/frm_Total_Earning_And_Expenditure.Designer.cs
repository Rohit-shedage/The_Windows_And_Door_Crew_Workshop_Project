namespace Windows_And_Doors_Project_CS
{
    partial class frm_Total_Earning_And_Expenditure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Total_Earning_And_Expenditure));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Total_Earning_And_Expenditure = new System.Windows.Forms.GroupBox();
            this.tblpnl_Total_Profit = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_Display = new System.Windows.Forms.ComboBox();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.lbl_Total_Profit = new System.Windows.Forms.Label();
            this.tb_Total_Profit = new System.Windows.Forms.TextBox();
            this.lbl_Total_Expenditure = new System.Windows.Forms.Label();
            this.tb_Expenditure = new System.Windows.Forms.TextBox();
            this.lbl_Total_Earning = new System.Windows.Forms.Label();
            this.tb_Earning = new System.Windows.Forms.TextBox();
            this.pnl_Header.SuspendLayout();
            this.gb_Total_Earning_And_Expenditure.SuspendLayout();
            this.tblpnl_Total_Profit.SuspendLayout();
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
            this.pnl_Header.TabIndex = 35;
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
            this.lbl_Header.Location = new System.Drawing.Point(207, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(552, 49);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Total Earning And Expenditure";
            // 
            // gb_Total_Earning_And_Expenditure
            // 
            this.gb_Total_Earning_And_Expenditure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Total_Earning_And_Expenditure.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Total_Earning_And_Expenditure.Controls.Add(this.tblpnl_Total_Profit);
            this.gb_Total_Earning_And_Expenditure.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Total_Earning_And_Expenditure.Location = new System.Drawing.Point(12, 101);
            this.gb_Total_Earning_And_Expenditure.Name = "gb_Total_Earning_And_Expenditure";
            this.gb_Total_Earning_And_Expenditure.Size = new System.Drawing.Size(978, 573);
            this.gb_Total_Earning_And_Expenditure.TabIndex = 36;
            this.gb_Total_Earning_And_Expenditure.TabStop = false;
            this.gb_Total_Earning_And_Expenditure.Text = "Total Earning And Expenditure";
            // 
            // tblpnl_Total_Profit
            // 
            this.tblpnl_Total_Profit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnl_Total_Profit.ColumnCount = 7;
            this.tblpnl_Total_Profit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.59636F));
            this.tblpnl_Total_Profit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.814817F));
            this.tblpnl_Total_Profit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.35148F));
            this.tblpnl_Total_Profit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.465347F));
            this.tblpnl_Total_Profit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.18645F));
            this.tblpnl_Total_Profit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.812698F));
            this.tblpnl_Total_Profit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5953F));
            this.tblpnl_Total_Profit.Controls.Add(this.cmb_Display, 4, 1);
            this.tblpnl_Total_Profit.Controls.Add(this.lbl_Display, 2, 1);
            this.tblpnl_Total_Profit.Controls.Add(this.lbl_Total_Profit, 2, 4);
            this.tblpnl_Total_Profit.Controls.Add(this.tb_Total_Profit, 4, 4);
            this.tblpnl_Total_Profit.Controls.Add(this.lbl_Total_Expenditure, 2, 3);
            this.tblpnl_Total_Profit.Controls.Add(this.tb_Expenditure, 4, 3);
            this.tblpnl_Total_Profit.Controls.Add(this.lbl_Total_Earning, 2, 2);
            this.tblpnl_Total_Profit.Controls.Add(this.tb_Earning, 4, 2);
            this.tblpnl_Total_Profit.Location = new System.Drawing.Point(75, 40);
            this.tblpnl_Total_Profit.Name = "tblpnl_Total_Profit";
            this.tblpnl_Total_Profit.RowCount = 6;
            this.tblpnl_Total_Profit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.005442F));
            this.tblpnl_Total_Profit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.49626F));
            this.tblpnl_Total_Profit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.49626F));
            this.tblpnl_Total_Profit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.49626F));
            this.tblpnl_Total_Profit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.49626F));
            this.tblpnl_Total_Profit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0095F));
            this.tblpnl_Total_Profit.Size = new System.Drawing.Size(808, 510);
            this.tblpnl_Total_Profit.TabIndex = 1;
            // 
            // cmb_Display
            // 
            this.cmb_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Display.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Display.FormattingEnabled = true;
            this.cmb_Display.Location = new System.Drawing.Point(400, 76);
            this.cmb_Display.Name = "cmb_Display";
            this.cmb_Display.Size = new System.Drawing.Size(254, 39);
            this.cmb_Display.TabIndex = 35;
            // 
            // lbl_Display
            // 
            this.lbl_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Display.Location = new System.Drawing.Point(151, 80);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(215, 33);
            this.lbl_Display.TabIndex = 34;
            this.lbl_Display.Text = "Display";
            this.lbl_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Total_Profit
            // 
            this.lbl_Total_Profit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Profit.AutoSize = true;
            this.lbl_Total_Profit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Profit.Location = new System.Drawing.Point(151, 392);
            this.lbl_Total_Profit.Name = "lbl_Total_Profit";
            this.lbl_Total_Profit.Size = new System.Drawing.Size(215, 33);
            this.lbl_Total_Profit.TabIndex = 37;
            this.lbl_Total_Profit.Text = "Total Profit";
            this.lbl_Total_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Total_Profit
            // 
            this.tb_Total_Profit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total_Profit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Profit.Location = new System.Drawing.Point(400, 389);
            this.tb_Total_Profit.Name = "tb_Total_Profit";
            this.tb_Total_Profit.Size = new System.Drawing.Size(254, 39);
            this.tb_Total_Profit.TabIndex = 40;
           
            // 
            // lbl_Total_Expenditure
            // 
            this.lbl_Total_Expenditure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Expenditure.AutoSize = true;
            this.lbl_Total_Expenditure.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Expenditure.Location = new System.Drawing.Point(151, 288);
            this.lbl_Total_Expenditure.Name = "lbl_Total_Expenditure";
            this.lbl_Total_Expenditure.Size = new System.Drawing.Size(215, 33);
            this.lbl_Total_Expenditure.TabIndex = 36;
            this.lbl_Total_Expenditure.Text = "Total Expenditure";
            this.lbl_Total_Expenditure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Expenditure
            // 
            this.tb_Expenditure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Expenditure.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expenditure.Location = new System.Drawing.Point(400, 285);
            this.tb_Expenditure.Name = "tb_Expenditure";
            this.tb_Expenditure.Size = new System.Drawing.Size(254, 39);
            this.tb_Expenditure.TabIndex = 39;
           
            // 
            // lbl_Total_Earning
            // 
            this.lbl_Total_Earning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Earning.AutoSize = true;
            this.lbl_Total_Earning.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Earning.Location = new System.Drawing.Point(151, 184);
            this.lbl_Total_Earning.Name = "lbl_Total_Earning";
            this.lbl_Total_Earning.Size = new System.Drawing.Size(215, 33);
            this.lbl_Total_Earning.TabIndex = 35;
            this.lbl_Total_Earning.Text = "Total Earning";
            this.lbl_Total_Earning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Earning
            // 
            this.tb_Earning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Earning.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Earning.Location = new System.Drawing.Point(400, 181);
            this.tb_Earning.Name = "tb_Earning";
            this.tb_Earning.Size = new System.Drawing.Size(254, 39);
            this.tb_Earning.TabIndex = 38;
           
            // 
            // frm_Total_Earning_And_Expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 732);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Total_Earning_And_Expenditure);
            this.Controls.Add(this.pnl_Header);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Total_Earning_And_Expenditure";
            this.Text = "Total Earning And Expenditure";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Total_Earning_And_Expenditure.ResumeLayout(false);
            this.tblpnl_Total_Profit.ResumeLayout(false);
            this.tblpnl_Total_Profit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Total_Earning_And_Expenditure;
        private System.Windows.Forms.TableLayoutPanel tblpnl_Total_Profit;
        private System.Windows.Forms.Label lbl_Total_Earning;
        private System.Windows.Forms.Label lbl_Total_Expenditure;
        private System.Windows.Forms.Label lbl_Total_Profit;
        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.ComboBox cmb_Display;
        private System.Windows.Forms.TextBox tb_Earning;
        private System.Windows.Forms.TextBox tb_Expenditure;
        private System.Windows.Forms.TextBox tb_Total_Profit;
    }
}