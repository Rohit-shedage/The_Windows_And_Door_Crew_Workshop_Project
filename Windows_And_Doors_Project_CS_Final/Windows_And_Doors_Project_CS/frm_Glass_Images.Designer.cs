namespace Windows_And_Doors_Project_CS
{
    partial class frm_Glass_Images
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
            this.pnl_Header_Glass_Images = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Header_Glass_Images.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header_Glass_Images
            // 
            this.pnl_Header_Glass_Images.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_Header_Glass_Images.Controls.Add(this.lbl_Header);
            this.pnl_Header_Glass_Images.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header_Glass_Images.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header_Glass_Images.Name = "pnl_Header_Glass_Images";
            this.pnl_Header_Glass_Images.Size = new System.Drawing.Size(932, 111);
            this.pnl_Header_Glass_Images.TabIndex = 2;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(343, 41);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(228, 41);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Glass Images";
            // 
            // frm_Glass_Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 698);
            this.Controls.Add(this.pnl_Header_Glass_Images);
            this.Name = "frm_Glass_Images";
            this.Text = "Glass Images";
            this.pnl_Header_Glass_Images.ResumeLayout(false);
            this.pnl_Header_Glass_Images.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header_Glass_Images;
        private System.Windows.Forms.Label lbl_Header;
    }
}