namespace BaoHiemTDT.Feature
{
    partial class frmPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPay));
            this.cbbPTenNH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPTenNH = new System.Windows.Forms.Label();
            this.lblPStk = new System.Windows.Forms.Label();
            this.txtPStk = new System.Windows.Forms.TextBox();
            this.btnPThanhToan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbPTenNH
            // 
            this.cbbPTenNH.FormattingEnabled = true;
            this.cbbPTenNH.Items.AddRange(new object[] {
            "Chọn ngân hàng",
            "AgriBank",
            "BIDV",
            "MBBank",
            "TechcomBank",
            "VietcomBank",
            "VietinBank"});
            this.cbbPTenNH.Location = new System.Drawing.Point(222, 205);
            this.cbbPTenNH.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPTenNH.Name = "cbbPTenNH";
            this.cbbPTenNH.Size = new System.Drawing.Size(125, 21);
            this.cbbPTenNH.TabIndex = 1;
            this.cbbPTenNH.SelectedIndexChanged += new System.EventHandler(this.cbbPTenNH_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "CÔNG TY BẢO HIỂM TDT";
            // 
            // lblPTenNH
            // 
            this.lblPTenNH.AutoSize = true;
            this.lblPTenNH.Location = new System.Drawing.Point(101, 205);
            this.lblPTenNH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPTenNH.Name = "lblPTenNH";
            this.lblPTenNH.Size = new System.Drawing.Size(83, 13);
            this.lblPTenNH.TabIndex = 2;
            this.lblPTenNH.Text = "Tên ngân hàng:";
            // 
            // lblPStk
            // 
            this.lblPStk.AutoSize = true;
            this.lblPStk.Location = new System.Drawing.Point(101, 259);
            this.lblPStk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPStk.Name = "lblPStk";
            this.lblPStk.Size = new System.Drawing.Size(70, 13);
            this.lblPStk.TabIndex = 2;
            this.lblPStk.Text = "Số tài khoản:";
            // 
            // txtPStk
            // 
            this.txtPStk.Location = new System.Drawing.Point(222, 257);
            this.txtPStk.Margin = new System.Windows.Forms.Padding(2);
            this.txtPStk.Name = "txtPStk";
            this.txtPStk.Size = new System.Drawing.Size(125, 20);
            this.txtPStk.TabIndex = 4;
            // 
            // btnPThanhToan
            // 
            this.btnPThanhToan.Location = new System.Drawing.Point(173, 323);
            this.btnPThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnPThanhToan.Name = "btnPThanhToan";
            this.btnPThanhToan.Size = new System.Drawing.Size(102, 34);
            this.btnPThanhToan.TabIndex = 5;
            this.btnPThanhToan.Text = "Thanh toán";
            this.btnPThanhToan.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(163, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 81);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(468, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPThanhToan);
            this.Controls.Add(this.txtPStk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPStk);
            this.Controls.Add(this.lblPTenNH);
            this.Controls.Add(this.cbbPTenNH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPTenNH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPTenNH;
        private System.Windows.Forms.Label lblPStk;
        private System.Windows.Forms.TextBox txtPStk;
        private System.Windows.Forms.Button btnPThanhToan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}