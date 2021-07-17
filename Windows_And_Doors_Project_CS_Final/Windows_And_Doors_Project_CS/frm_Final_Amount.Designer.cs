namespace Windows_And_Doors_Project_CS
{
    partial class frm_Final_Amount
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
            this.lbl_Delivery_Date = new System.Windows.Forms.Label();
            this.lbl_Remaining = new System.Windows.Forms.Label();
            this.lbl_Advance = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Installation = new System.Windows.Forms.Label();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.tb_Remaining = new System.Windows.Forms.TextBox();
            this.tb_Advance = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.dtp_Delivery_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Discount = new System.Windows.Forms.ComboBox();
            this.cmb_Installation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Delivery_Date
            // 
            this.lbl_Delivery_Date.AutoSize = true;
            this.lbl_Delivery_Date.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Delivery_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Delivery_Date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delivery_Date.Location = new System.Drawing.Point(41, 53);
            this.lbl_Delivery_Date.Name = "lbl_Delivery_Date";
            this.lbl_Delivery_Date.Size = new System.Drawing.Size(179, 34);
            this.lbl_Delivery_Date.TabIndex = 0;
            this.lbl_Delivery_Date.Text = "Delivery Date";
            // 
            // lbl_Remaining
            // 
            this.lbl_Remaining.AutoSize = true;
            this.lbl_Remaining.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Remaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Remaining.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining.Location = new System.Drawing.Point(815, 33);
            this.lbl_Remaining.Name = "lbl_Remaining";
            this.lbl_Remaining.Size = new System.Drawing.Size(142, 34);
            this.lbl_Remaining.TabIndex = 1;
            this.lbl_Remaining.Text = "Remaining";
            // 
            // lbl_Advance
            // 
            this.lbl_Advance.AutoSize = true;
            this.lbl_Advance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Advance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Advance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Advance.Location = new System.Drawing.Point(234, 33);
            this.lbl_Advance.Name = "lbl_Advance";
            this.lbl_Advance.Size = new System.Drawing.Size(119, 34);
            this.lbl_Advance.TabIndex = 2;
            this.lbl_Advance.Text = "Advance";
            this.lbl_Advance.Click += new System.EventHandler(this.lbl_Advance_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(848, 39);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(75, 34);
            this.lbl_Total.TabIndex = 3;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Installation
            // 
            this.lbl_Installation.AutoSize = true;
            this.lbl_Installation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Installation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Installation.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Installation.Location = new System.Drawing.Point(32, 28);
            this.lbl_Installation.Name = "lbl_Installation";
            this.lbl_Installation.Size = new System.Drawing.Size(143, 34);
            this.lbl_Installation.TabIndex = 4;
            this.lbl_Installation.Text = "Installation";
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_GST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_GST.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(675, 39);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(73, 34);
            this.lbl_GST.TabIndex = 5;
            this.lbl_GST.Text = "GST";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Discount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(32, 129);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(121, 34);
            this.lbl_Discount.TabIndex = 6;
            this.lbl_Discount.Text = "Discount";
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.Font = new System.Drawing.Font("Yu Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(335, 519);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(187, 43);
            this.btn_Back.TabIndex = 26;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Confirm.Font = new System.Drawing.Font("Yu Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(609, 519);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(187, 43);
            this.btn_Confirm.TabIndex = 27;
            this.btn_Confirm.Text = "CONFIRM";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // tb_Remaining
            // 
            this.tb_Remaining.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Remaining.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remaining.Location = new System.Drawing.Point(713, 107);
            this.tb_Remaining.Name = "tb_Remaining";
            this.tb_Remaining.Size = new System.Drawing.Size(330, 39);
            this.tb_Remaining.TabIndex = 28;
            // 
            // tb_Advance
            // 
            this.tb_Advance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Advance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Advance.Location = new System.Drawing.Point(125, 107);
            this.tb_Advance.Name = "tb_Advance";
            this.tb_Advance.Size = new System.Drawing.Size(330, 39);
            this.tb_Advance.TabIndex = 29;
            this.tb_Advance.TextChanged += new System.EventHandler(this.tb_Advance_TextChanged);
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(716, 109);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(330, 39);
            this.tb_Total.TabIndex = 30;
            this.tb_Total.TextChanged += new System.EventHandler(this.tb_Total_TextChanged);
            // 
            // tb_GST
            // 
            this.tb_GST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(805, 35);
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(330, 39);
            this.tb_GST.TabIndex = 31;
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            // 
            // dtp_Delivery_Date
            // 
            this.dtp_Delivery_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Delivery_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Delivery_Date.Location = new System.Drawing.Point(240, 35);
            this.dtp_Delivery_Date.Name = "dtp_Delivery_Date";
            this.dtp_Delivery_Date.Size = new System.Drawing.Size(330, 39);
            this.dtp_Delivery_Date.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_GST);
            this.groupBox1.Controls.Add(this.tb_GST);
            this.groupBox1.Controls.Add(this.dtp_Delivery_Date);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 100);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_Discount);
            this.groupBox2.Controls.Add(this.cmb_Installation);
            this.groupBox2.Controls.Add(this.lbl_Discount);
            this.groupBox2.Controls.Add(this.lbl_Total);
            this.groupBox2.Controls.Add(this.tb_Total);
            this.groupBox2.Controls.Add(this.lbl_Installation);
            this.groupBox2.Location = new System.Drawing.Point(9, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1147, 199);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // cmb_Discount
            // 
            this.cmb_Discount.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cmb_Discount.FormattingEnabled = true;
            this.cmb_Discount.Items.AddRange(new object[] {
            "0%",
            "10%",
            "15%",
            "20%"});
            this.cmb_Discount.Location = new System.Drawing.Point(256, 128);
            this.cmb_Discount.Name = "cmb_Discount";
            this.cmb_Discount.Size = new System.Drawing.Size(180, 39);
            this.cmb_Discount.TabIndex = 32;
            this.cmb_Discount.SelectedIndexChanged += new System.EventHandler(this.cmb_Discount_SelectedIndexChanged);
            // 
            // cmb_Installation
            // 
            this.cmb_Installation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Installation.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cmb_Installation.FormattingEnabled = true;
            this.cmb_Installation.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmb_Installation.Location = new System.Drawing.Point(256, 28);
            this.cmb_Installation.Name = "cmb_Installation";
            this.cmb_Installation.Size = new System.Drawing.Size(180, 39);
            this.cmb_Installation.TabIndex = 31;
            this.cmb_Installation.SelectedIndexChanged += new System.EventHandler(this.cmb_Installation_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Advance);
            this.groupBox3.Controls.Add(this.tb_Remaining);
            this.groupBox3.Controls.Add(this.tb_Advance);
            this.groupBox3.Controls.Add(this.lbl_Remaining);
            this.groupBox3.Location = new System.Drawing.Point(12, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1147, 177);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // frm_Final_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 583);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Delivery_Date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Final_Amount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Final_Amount";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Final_Amount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Delivery_Date;
        private System.Windows.Forms.Label lbl_Remaining;
        private System.Windows.Forms.Label lbl_Advance;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Installation;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox tb_Remaining;
        private System.Windows.Forms.TextBox tb_Advance;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.DateTimePicker dtp_Delivery_Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_Discount;
        private System.Windows.Forms.ComboBox cmb_Installation;
    }
}