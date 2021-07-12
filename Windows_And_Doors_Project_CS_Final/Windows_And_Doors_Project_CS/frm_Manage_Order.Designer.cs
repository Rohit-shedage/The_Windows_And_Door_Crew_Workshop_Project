namespace Windows_And_Doors_Project_CS
{
    partial class frm_Manage_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manage_Order));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Search_Customer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dgv_Mark_As_Completed = new System.Windows.Forms.DataGridView();
            this.gb_View = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Sort_By = new System.Windows.Forms.Label();
            this.cmb_Sort_By = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Update_Order = new System.Windows.Forms.Button();
            this.btn_Accept_Money = new System.Windows.Forms.Button();
            this.btn_Cancel_Order = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Mark_As_Completed = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.gb_Search_Customer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mark_As_Completed)).BeginInit();
            this.gb_View.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.pnl_Header.TabIndex = 11;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(915, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 43);
            this.btn_Close.TabIndex = 1;
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
            this.lbl_Header.Size = new System.Drawing.Size(267, 49);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Manage Order";
            // 
            // gb_Search_Customer
            // 
            this.gb_Search_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Search_Customer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_Search_Customer.Controls.Add(this.tableLayoutPanel1);
            this.gb_Search_Customer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Search_Customer.Location = new System.Drawing.Point(12, 98);
            this.gb_Search_Customer.Name = "gb_Search_Customer";
            this.gb_Search_Customer.Size = new System.Drawing.Size(978, 100);
            this.gb_Search_Customer.TabIndex = 12;
            this.gb_Search_Customer.TabStop = false;
            this.gb_Search_Customer.Text = "Search Customer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.006198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.75495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.8658F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00863F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_ID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(759, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(145, 50);
            this.btn_Search.TabIndex = 27;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(474, 11);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 33);
            this.lbl_Name.TabIndex = 16;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(574, 8);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(174, 39);
            this.tb_Name.TabIndex = 15;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(166, 8);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(174, 39);
            this.tb_ID.TabIndex = 13;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(84, 11);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(43, 33);
            this.lbl_ID.TabIndex = 14;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Mark_As_Completed
            // 
            this.dgv_Mark_As_Completed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Mark_As_Completed.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Mark_As_Completed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mark_As_Completed.Location = new System.Drawing.Point(17, 122);
            this.dgv_Mark_As_Completed.Name = "dgv_Mark_As_Completed";
            this.dgv_Mark_As_Completed.RowHeadersWidth = 51;
            this.dgv_Mark_As_Completed.RowTemplate.Height = 24;
            this.dgv_Mark_As_Completed.Size = new System.Drawing.Size(946, 273);
            this.dgv_Mark_As_Completed.TabIndex = 13;
            // 
            // gb_View
            // 
            this.gb_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_View.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gb_View.Controls.Add(this.tableLayoutPanel2);
            this.gb_View.Controls.Add(this.dgv_Mark_As_Completed);
            this.gb_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_View.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_View.Location = new System.Drawing.Point(12, 204);
            this.gb_View.Name = "gb_View";
            this.gb_View.Size = new System.Drawing.Size(978, 414);
            this.gb_View.TabIndex = 14;
            this.gb_View.TabStop = false;
            this.gb_View.Text = "View";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.821404F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.472061F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.21869F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.008924F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.22008F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40621F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.473199F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.37944F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Sort_By, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Sort_By, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Clear, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(946, 57);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // lbl_Sort_By
            // 
            this.lbl_Sort_By.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sort_By.AutoSize = true;
            this.lbl_Sort_By.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sort_By.Location = new System.Drawing.Point(217, 12);
            this.lbl_Sort_By.Name = "lbl_Sort_By";
            this.lbl_Sort_By.Size = new System.Drawing.Size(101, 33);
            this.lbl_Sort_By.TabIndex = 15;
            this.lbl_Sort_By.Text = "Sort By";
            this.lbl_Sort_By.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Sort_By
            // 
            this.cmb_Sort_By.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sort_By.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sort_By.FormattingEnabled = true;
            this.cmb_Sort_By.Location = new System.Drawing.Point(404, 9);
            this.cmb_Sort_By.Name = "cmb_Sort_By";
            this.cmb_Sort_By.Size = new System.Drawing.Size(223, 39);
            this.cmb_Sort_By.TabIndex = 30;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(644, 6);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(127, 44);
            this.btn_Clear.TabIndex = 31;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 66);
            this.panel2.TabIndex = 27;
            // 
            // btn_Update_Order
            // 
            this.btn_Update_Order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update_Order.AutoSize = true;
            this.btn_Update_Order.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Order.Location = new System.Drawing.Point(283, 8);
            this.btn_Update_Order.Name = "btn_Update_Order";
            this.btn_Update_Order.Size = new System.Drawing.Size(175, 43);
            this.btn_Update_Order.TabIndex = 26;
            this.btn_Update_Order.Text = "Update Order";
            this.btn_Update_Order.UseVisualStyleBackColor = true;
            this.btn_Update_Order.Click += new System.EventHandler(this.btn_Update_Order_Click);
            // 
            // btn_Accept_Money
            // 
            this.btn_Accept_Money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Accept_Money.AutoSize = true;
            this.btn_Accept_Money.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accept_Money.Location = new System.Drawing.Point(489, 8);
            this.btn_Accept_Money.Name = "btn_Accept_Money";
            this.btn_Accept_Money.Size = new System.Drawing.Size(187, 43);
            this.btn_Accept_Money.TabIndex = 25;
            this.btn_Accept_Money.Text = "Accept Money";
            this.btn_Accept_Money.UseVisualStyleBackColor = true;
            this.btn_Accept_Money.Click += new System.EventHandler(this.btn_Accept_Money_Click);
            // 
            // btn_Cancel_Order
            // 
            this.btn_Cancel_Order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel_Order.AutoSize = true;
            this.btn_Cancel_Order.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Order.Location = new System.Drawing.Point(71, 8);
            this.btn_Cancel_Order.Name = "btn_Cancel_Order";
            this.btn_Cancel_Order.Size = new System.Drawing.Size(185, 43);
            this.btn_Cancel_Order.TabIndex = 24;
            this.btn_Cancel_Order.Text = "Cancel Order";
            this.btn_Cancel_Order.UseVisualStyleBackColor = true;
            this.btn_Cancel_Order.Click += new System.EventHandler(this.btn_Cancel_Order_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.325301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.28112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.18474F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.38554F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.71084F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.911647F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Update_Order, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Accept_Money, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Cancel_Order, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Mark_As_Completed, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 640);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(996, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_Mark_As_Completed
            // 
            this.btn_Mark_As_Completed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Mark_As_Completed.AutoSize = true;
            this.btn_Mark_As_Completed.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mark_As_Completed.Location = new System.Drawing.Point(705, 8);
            this.btn_Mark_As_Completed.Name = "btn_Mark_As_Completed";
            this.btn_Mark_As_Completed.Size = new System.Drawing.Size(243, 43);
            this.btn_Mark_As_Completed.TabIndex = 27;
            this.btn_Mark_As_Completed.Text = "Mark as Completed";
            this.btn_Mark_As_Completed.UseVisualStyleBackColor = true;
            // 
            // frm_Manage_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 703);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Search_Customer);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.gb_View);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "frm_Manage_Order";
            this.Text = "frm_Mark_As_Completed";
            this.Load += new System.EventHandler(this.frm_Manage_Order_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Search_Customer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mark_As_Completed)).EndInit();
            this.gb_View.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Search_Customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Mark_As_Completed;
        private System.Windows.Forms.GroupBox gb_View;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Sort_By;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cmb_Sort_By;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Update_Order;
        private System.Windows.Forms.Button btn_Accept_Money;
        private System.Windows.Forms.Button btn_Cancel_Order;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Mark_As_Completed;
    }
}