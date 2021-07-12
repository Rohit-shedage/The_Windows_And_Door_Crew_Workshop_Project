namespace Windows_And_Doors_Project_CS
{
    partial class frm_Add_Material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Material));
            this.gb_New_Materials = new System.Windows.Forms.GroupBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.cmb_Distributor = new System.Windows.Forms.ComboBox();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.tb_Material = new System.Windows.Forms.TextBox();
            this.lbl_Material_Group = new System.Windows.Forms.Label();
            this.cmb_Material_Group = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_New_Materials.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_New_Materials
            // 
            this.gb_New_Materials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_New_Materials.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gb_New_Materials.Controls.Add(this.btn_Save);
            this.gb_New_Materials.Controls.Add(this.lbl_Material_Group);
            this.gb_New_Materials.Controls.Add(this.cmb_Material_Group);
            this.gb_New_Materials.Controls.Add(this.tb_Material);
            this.gb_New_Materials.Controls.Add(this.lbl_Material);
            this.gb_New_Materials.Controls.Add(this.lbl_Distributor_Name);
            this.gb_New_Materials.Controls.Add(this.cmb_Distributor);
            this.gb_New_Materials.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_New_Materials.Location = new System.Drawing.Point(0, 89);
            this.gb_New_Materials.Name = "gb_New_Materials";
            this.gb_New_Materials.Size = new System.Drawing.Size(504, 298);
            this.gb_New_Materials.TabIndex = 0;
            this.gb_New_Materials.TabStop = false;
            this.gb_New_Materials.Text = "New Material";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Header.Controls.Add(this.btn_Close);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(507, 83);
            this.pnl_Header.TabIndex = 15;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(458, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 37);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(101, 18);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(250, 46);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add Materials";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(41, 119);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(138, 33);
            this.lbl_Distributor_Name.TabIndex = 24;
            this.lbl_Distributor_Name.Text = "Distributor";
            this.lbl_Distributor_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Distributor
            // 
            this.cmb_Distributor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Distributor.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distributor.FormattingEnabled = true;
            this.cmb_Distributor.Location = new System.Drawing.Point(279, 113);
            this.cmb_Distributor.Name = "cmb_Distributor";
            this.cmb_Distributor.Size = new System.Drawing.Size(188, 39);
            this.cmb_Distributor.TabIndex = 25;
            // 
            // lbl_Material
            // 
            this.lbl_Material.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Material.Location = new System.Drawing.Point(41, 42);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(109, 33);
            this.lbl_Material.TabIndex = 26;
            this.lbl_Material.Text = "Material";
            this.lbl_Material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Material
            // 
            this.tb_Material.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Material.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Material.Location = new System.Drawing.Point(279, 40);
            this.tb_Material.Name = "tb_Material";
            this.tb_Material.Size = new System.Drawing.Size(188, 39);
            this.tb_Material.TabIndex = 27;
            // 
            // lbl_Material_Group
            // 
            this.lbl_Material_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Material_Group.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Material_Group.Location = new System.Drawing.Point(12, 191);
            this.lbl_Material_Group.Name = "lbl_Material_Group";
            this.lbl_Material_Group.Size = new System.Drawing.Size(209, 31);
            this.lbl_Material_Group.TabIndex = 28;
            this.lbl_Material_Group.Text = "Material Type";
            this.lbl_Material_Group.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Material_Group
            // 
            this.cmb_Material_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Material_Group.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Material_Group.FormattingEnabled = true;
            this.cmb_Material_Group.Location = new System.Drawing.Point(279, 183);
            this.cmb_Material_Group.Name = "cmb_Material_Group";
            this.cmb_Material_Group.Size = new System.Drawing.Size(188, 39);
            this.cmb_Material_Group.TabIndex = 29;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(143, 244);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(187, 43);
            this.btn_Save.TabIndex = 30;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // frm_Add_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 388);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.gb_New_Materials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Material";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Material";
            this.TopMost = true;
            this.gb_New_Materials.ResumeLayout(false);
            this.gb_New_Materials.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_New_Materials;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.ComboBox cmb_Distributor;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.TextBox tb_Material;
        private System.Windows.Forms.Label lbl_Material_Group;
        private System.Windows.Forms.ComboBox cmb_Material_Group;
        private System.Windows.Forms.Button btn_Save;
    }
}