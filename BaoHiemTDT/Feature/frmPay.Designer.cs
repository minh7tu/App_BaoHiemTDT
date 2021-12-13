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
            this.lblHuy = new System.Windows.Forms.Label();
            this.lblSoThe = new System.Windows.Forms.Label();
            this.txtPSthe = new System.Windows.Forms.TextBox();
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
            this.cbbPTenNH.Location = new System.Drawing.Point(296, 252);
            this.cbbPTenNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPTenNH.Name = "cbbPTenNH";
            this.cbbPTenNH.Size = new System.Drawing.Size(165, 24);
            this.cbbPTenNH.TabIndex = 1;
            this.cbbPTenNH.SelectedIndexChanged += new System.EventHandler(this.cbbPTenNH_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "CÔNG TY BẢO HIỂM TDT";
            // 
            // lblPTenNH
            // 
            this.lblPTenNH.AutoSize = true;
            this.lblPTenNH.Location = new System.Drawing.Point(135, 252);
            this.lblPTenNH.Name = "lblPTenNH";
            this.lblPTenNH.Size = new System.Drawing.Size(109, 17);
            this.lblPTenNH.TabIndex = 2;
            this.lblPTenNH.Text = "Tên ngân hàng:";
            // 
            // lblPStk
            // 
            this.lblPStk.AutoSize = true;
            this.lblPStk.Location = new System.Drawing.Point(135, 375);
            this.lblPStk.Name = "lblPStk";
            this.lblPStk.Size = new System.Drawing.Size(91, 17);
            this.lblPStk.TabIndex = 2;
            this.lblPStk.Text = "Số tài khoản:";
            // 
            // txtPStk
            // 
            this.txtPStk.Location = new System.Drawing.Point(296, 370);
            this.txtPStk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPStk.Name = "txtPStk";
            this.txtPStk.Size = new System.Drawing.Size(165, 22);
            this.txtPStk.TabIndex = 4;
            this.txtPStk.TextChanged += new System.EventHandler(this.txtPStk_TextChanged);
            // 
            // btnPThanhToan
            // 
            this.btnPThanhToan.Location = new System.Drawing.Point(217, 456);
            this.btnPThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPThanhToan.Name = "btnPThanhToan";
            this.btnPThanhToan.Size = new System.Drawing.Size(136, 42);
            this.btnPThanhToan.TabIndex = 5;
            this.btnPThanhToan.Text = "Thanh toán";
            this.btnPThanhToan.UseVisualStyleBackColor = true;
            this.btnPThanhToan.Click += new System.EventHandler(this.btnPThanhToan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(217, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 100);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblHuy
            // 
            this.lblHuy.AutoSize = true;
            this.lblHuy.Location = new System.Drawing.Point(272, 500);
            this.lblHuy.Name = "lblHuy";
            this.lblHuy.Size = new System.Drawing.Size(33, 17);
            this.lblHuy.TabIndex = 21;
            this.lblHuy.Text = "Hủy";
            this.lblHuy.Click += new System.EventHandler(this.lblHuy_Click);
            // 
            // lblSoThe
            // 
            this.lblSoThe.AutoSize = true;
            this.lblSoThe.Location = new System.Drawing.Point(135, 315);
            this.lblSoThe.Name = "lblSoThe";
            this.lblSoThe.Size = new System.Drawing.Size(53, 17);
            this.lblSoThe.TabIndex = 2;
            this.lblSoThe.Text = "Số thẻ:";
            // 
            // txtPSthe
            // 
            this.txtPSthe.Location = new System.Drawing.Point(296, 310);
            this.txtPSthe.Name = "txtPSthe";
            this.txtPSthe.Size = new System.Drawing.Size(165, 22);
            this.txtPSthe.TabIndex = 23;
            this.txtPSthe.TextChanged += new System.EventHandler(this.txtPSthe_TextChanged);
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(624, 526);
            this.Controls.Add(this.txtPSthe);
            this.Controls.Add(this.lblHuy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPThanhToan);
            this.Controls.Add(this.txtPStk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSoThe);
            this.Controls.Add(this.lblPStk);
            this.Controls.Add(this.lblPTenNH);
            this.Controls.Add(this.cbbPTenNH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblHuy;
        private System.Windows.Forms.Label lblSoThe;
        private System.Windows.Forms.TextBox txtPSthe;
    }
}