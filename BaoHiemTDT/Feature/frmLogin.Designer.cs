
namespace Login
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.icoMatKhau = new System.Windows.Forms.PictureBox();
            this.icoTaiKhoan = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblQuenMK = new System.Windows.Forms.LinkLabel();
            this.lblDangKy = new System.Windows.Forms.LinkLabel();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icoMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTaiKhoan.Location = new System.Drawing.Point(290, 268);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(243, 38);
            this.txtTaiKhoan.TabIndex = 4;
            this.txtTaiKhoan.Text = " Tài khoản";
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(290, 362);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(243, 38);
            this.txtMatKhau.TabIndex = 6;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // icoMatKhau
            // 
            this.icoMatKhau.Image = global::Login.Properties.Resources._lock;
            this.icoMatKhau.Location = new System.Drawing.Point(228, 343);
            this.icoMatKhau.Name = "icoMatKhau";
            this.icoMatKhau.Size = new System.Drawing.Size(56, 53);
            this.icoMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoMatKhau.TabIndex = 5;
            this.icoMatKhau.TabStop = false;
            // 
            // icoTaiKhoan
            // 
            this.icoTaiKhoan.Image = global::Login.Properties.Resources.user_icon_150670;
            this.icoTaiKhoan.Location = new System.Drawing.Point(228, 253);
            this.icoTaiKhoan.Name = "icoTaiKhoan";
            this.icoTaiKhoan.Size = new System.Drawing.Size(56, 47);
            this.icoTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoTaiKhoan.TabIndex = 2;
            this.icoTaiKhoan.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.cÔNG_TY_CỔ_PHẦN_BẢO_HIỂM;
            this.pictureBox1.Location = new System.Drawing.Point(180, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(312, 488);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(151, 46);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.LinkColor = System.Drawing.Color.Black;
            this.lblQuenMK.Location = new System.Drawing.Point(236, 427);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(117, 17);
            this.lblQuenMK.TabIndex = 8;
            this.lblQuenMK.TabStop = true;
            this.lblQuenMK.Text = "Quên mật khẩu ?";
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.LinkColor = System.Drawing.Color.Black;
            this.lblDangKy.Location = new System.Drawing.Point(236, 456);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(95, 17);
            this.lblDangKy.TabIndex = 9;
            this.lblDangKy.TabStop = true;
            this.lblDangKy.Text = "Tạo tài khoản";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(357, 553);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(45, 17);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "Thoát";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblDangKy);
            this.Controls.Add(this.lblQuenMK);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.icoMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.icoTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.icoMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icoTaiKhoan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.PictureBox icoMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel lblQuenMK;
        private System.Windows.Forms.LinkLabel lblDangKy;
        private System.Windows.Forms.Label lblExit;
    }
}

