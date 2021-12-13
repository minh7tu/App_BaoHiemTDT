namespace BaoHiemTDT.Feature
{
    partial class frmForgotPassword
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
            this.lblQuenMK = new System.Windows.Forms.Label();
            this.lblForgetTK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblForgetSDT = new System.Windows.Forms.Label();
            this.txtForgetTK = new System.Windows.Forms.TextBox();
            this.txtForgetSDT = new System.Windows.Forms.TextBox();
            this.btnForgetCheck = new System.Windows.Forms.Button();
            this.liblForgetExit = new System.Windows.Forms.LinkLabel();
            this.lblGetPW = new System.Windows.Forms.Label();
            this.lblRegetPW = new System.Windows.Forms.Label();
            this.txtForgetMK = new System.Windows.Forms.TextBox();
            this.txtReforgetMK = new System.Windows.Forms.TextBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblCheckTK = new System.Windows.Forms.Label();
            this.lblCheckSDT = new System.Windows.Forms.Label();
            this.ckbHienThi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMK.Location = new System.Drawing.Point(277, 202);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(183, 33);
            this.lblQuenMK.TabIndex = 1;
            this.lblQuenMK.Text = "Quên mật khẩu";
            // 
            // lblForgetTK
            // 
            this.lblForgetTK.AutoSize = true;
            this.lblForgetTK.Location = new System.Drawing.Point(196, 262);
            this.lblForgetTK.Name = "lblForgetTK";
            this.lblForgetTK.Size = new System.Drawing.Size(75, 17);
            this.lblForgetTK.TabIndex = 2;
            this.lblForgetTK.Text = "Tài khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaoHiemTDT.Properties.Resources.logo_login;
            this.pictureBox1.Location = new System.Drawing.Point(199, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblForgetSDT
            // 
            this.lblForgetSDT.AutoSize = true;
            this.lblForgetSDT.Location = new System.Drawing.Point(196, 306);
            this.lblForgetSDT.Name = "lblForgetSDT";
            this.lblForgetSDT.Size = new System.Drawing.Size(95, 17);
            this.lblForgetSDT.TabIndex = 2;
            this.lblForgetSDT.Text = "Số điện thoại:";
            // 
            // txtForgetTK
            // 
            this.txtForgetTK.Location = new System.Drawing.Point(329, 257);
            this.txtForgetTK.Name = "txtForgetTK";
            this.txtForgetTK.Size = new System.Drawing.Size(177, 22);
            this.txtForgetTK.TabIndex = 1;
            this.txtForgetTK.TextChanged += new System.EventHandler(this.txtForgetTK_TextChanged);
            // 
            // txtForgetSDT
            // 
            this.txtForgetSDT.Location = new System.Drawing.Point(329, 301);
            this.txtForgetSDT.Name = "txtForgetSDT";
            this.txtForgetSDT.Size = new System.Drawing.Size(177, 22);
            this.txtForgetSDT.TabIndex = 2;
            this.txtForgetSDT.TextChanged += new System.EventHandler(this.txtForgetSDT_TextChanged);
            // 
            // btnForgetCheck
            // 
            this.btnForgetCheck.Location = new System.Drawing.Point(297, 469);
            this.btnForgetCheck.Name = "btnForgetCheck";
            this.btnForgetCheck.Size = new System.Drawing.Size(108, 27);
            this.btnForgetCheck.TabIndex = 5;
            this.btnForgetCheck.Text = "Lấy mật khẩu";
            this.btnForgetCheck.UseVisualStyleBackColor = true;
            this.btnForgetCheck.Click += new System.EventHandler(this.btnForgetCheck_Click);
            // 
            // liblForgetExit
            // 
            this.liblForgetExit.AutoSize = true;
            this.liblForgetExit.LinkColor = System.Drawing.Color.Black;
            this.liblForgetExit.Location = new System.Drawing.Point(326, 499);
            this.liblForgetExit.Name = "liblForgetExit";
            this.liblForgetExit.Size = new System.Drawing.Size(45, 17);
            this.liblForgetExit.TabIndex = 6;
            this.liblForgetExit.TabStop = true;
            this.liblForgetExit.Text = "Thoát";
            this.liblForgetExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liblForgetExit_LinkClicked);
            // 
            // lblGetPW
            // 
            this.lblGetPW.AutoSize = true;
            this.lblGetPW.Location = new System.Drawing.Point(196, 354);
            this.lblGetPW.Name = "lblGetPW";
            this.lblGetPW.Size = new System.Drawing.Size(96, 17);
            this.lblGetPW.TabIndex = 7;
            this.lblGetPW.Text = "Mật khẩu mới:";
            // 
            // lblRegetPW
            // 
            this.lblRegetPW.AutoSize = true;
            this.lblRegetPW.Location = new System.Drawing.Point(196, 404);
            this.lblRegetPW.Name = "lblRegetPW";
            this.lblRegetPW.Size = new System.Drawing.Size(126, 17);
            this.lblRegetPW.TabIndex = 7;
            this.lblRegetPW.Text = "Nhập lại mật khẩu:";
            // 
            // txtForgetMK
            // 
            this.txtForgetMK.Location = new System.Drawing.Point(329, 349);
            this.txtForgetMK.Name = "txtForgetMK";
            this.txtForgetMK.PasswordChar = '•';
            this.txtForgetMK.Size = new System.Drawing.Size(177, 22);
            this.txtForgetMK.TabIndex = 3;
            // 
            // txtReforgetMK
            // 
            this.txtReforgetMK.Location = new System.Drawing.Point(329, 401);
            this.txtReforgetMK.Name = "txtReforgetMK";
            this.txtReforgetMK.PasswordChar = '•';
            this.txtReforgetMK.Size = new System.Drawing.Size(177, 22);
            this.txtReforgetMK.TabIndex = 4;
            this.txtReforgetMK.TextChanged += new System.EventHandler(this.txtReforgetMK_TextChanged);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(329, 378);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(228, 17);
            this.lblCheck.TabIndex = 8;
            this.lblCheck.Text = "Mật khẩu bạn nhập chưa chính xác";
            // 
            // lblCheckTK
            // 
            this.lblCheckTK.AutoSize = true;
            this.lblCheckTK.Location = new System.Drawing.Point(512, 260);
            this.lblCheckTK.Name = "lblCheckTK";
            this.lblCheckTK.Size = new System.Drawing.Size(160, 17);
            this.lblCheckTK.TabIndex = 9;
            this.lblCheckTK.Text = "Tài khoản không hợp lệ!";
            // 
            // lblCheckSDT
            // 
            this.lblCheckSDT.AutoSize = true;
            this.lblCheckSDT.Location = new System.Drawing.Point(512, 304);
            this.lblCheckSDT.Name = "lblCheckSDT";
            this.lblCheckSDT.Size = new System.Drawing.Size(180, 17);
            this.lblCheckSDT.TabIndex = 10;
            this.lblCheckSDT.Text = "Số điện thoại không hợp lệ!";
            // 
            // ckbHienThi
            // 
            this.ckbHienThi.AutoSize = true;
            this.ckbHienThi.Location = new System.Drawing.Point(329, 430);
            this.ckbHienThi.Name = "ckbHienThi";
            this.ckbHienThi.Size = new System.Drawing.Size(121, 21);
            this.ckbHienThi.TabIndex = 11;
            this.ckbHienThi.Text = "Hiện mật khẩu";
            this.ckbHienThi.UseVisualStyleBackColor = true;
            this.ckbHienThi.CheckedChanged += new System.EventHandler(this.ckbHienThi_CheckedChanged);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(731, 525);
            this.Controls.Add(this.ckbHienThi);
            this.Controls.Add(this.lblCheckSDT);
            this.Controls.Add(this.lblCheckTK);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblRegetPW);
            this.Controls.Add(this.lblGetPW);
            this.Controls.Add(this.liblForgetExit);
            this.Controls.Add(this.btnForgetCheck);
            this.Controls.Add(this.txtReforgetMK);
            this.Controls.Add(this.txtForgetMK);
            this.Controls.Add(this.txtForgetSDT);
            this.Controls.Add(this.txtForgetTK);
            this.Controls.Add(this.lblForgetSDT);
            this.Controls.Add(this.lblForgetTK);
            this.Controls.Add(this.lblQuenMK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuenMK;
        private System.Windows.Forms.Label lblForgetTK;
        private System.Windows.Forms.Label lblForgetSDT;
        private System.Windows.Forms.TextBox txtForgetTK;
        private System.Windows.Forms.TextBox txtForgetSDT;
        private System.Windows.Forms.Button btnForgetCheck;
        private System.Windows.Forms.LinkLabel liblForgetExit;
        private System.Windows.Forms.Label lblGetPW;
        private System.Windows.Forms.Label lblRegetPW;
        private System.Windows.Forms.TextBox txtForgetMK;
        private System.Windows.Forms.TextBox txtReforgetMK;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblCheckTK;
        private System.Windows.Forms.Label lblCheckSDT;
        private System.Windows.Forms.CheckBox ckbHienThi;
    }
}