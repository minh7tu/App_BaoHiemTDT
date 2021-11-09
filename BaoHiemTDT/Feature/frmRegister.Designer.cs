
namespace BaoHiemTDT.Feature
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegisterTK = new System.Windows.Forms.Label();
            this.lblRegisterMK = new System.Windows.Forms.Label();
            this.lblRepeatMK = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.txtRegisMK = new System.Windows.Forms.TextBox();
            this.txtRegisTK = new System.Windows.Forms.TextBox();
            this.txtReregismk = new System.Windows.Forms.TextBox();
            this.txtRegisSDT = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblThoat = new System.Windows.Forms.Label();
            this.ckbHienMK = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng kí tài khoản";
            // 
            // lblRegisterTK
            // 
            this.lblRegisterTK.AutoSize = true;
            this.lblRegisterTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTK.Location = new System.Drawing.Point(181, 271);
            this.lblRegisterTK.Name = "lblRegisterTK";
            this.lblRegisterTK.Size = new System.Drawing.Size(83, 19);
            this.lblRegisterTK.TabIndex = 2;
            this.lblRegisterTK.Text = "Tài khoản :";
            // 
            // lblRegisterMK
            // 
            this.lblRegisterMK.AutoSize = true;
            this.lblRegisterMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterMK.Location = new System.Drawing.Point(181, 314);
            this.lblRegisterMK.Name = "lblRegisterMK";
            this.lblRegisterMK.Size = new System.Drawing.Size(80, 19);
            this.lblRegisterMK.TabIndex = 2;
            this.lblRegisterMK.Text = "Mật khẩu :";
            // 
            // lblRepeatMK
            // 
            this.lblRepeatMK.AutoSize = true;
            this.lblRepeatMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatMK.Location = new System.Drawing.Point(181, 361);
            this.lblRepeatMK.Name = "lblRepeatMK";
            this.lblRepeatMK.Size = new System.Drawing.Size(134, 19);
            this.lblRepeatMK.TabIndex = 2;
            this.lblRepeatMK.Text = "Nhập lại mật khẩu:";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.Location = new System.Drawing.Point(181, 408);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(104, 19);
            this.lblSoDT.TabIndex = 2;
            this.lblSoDT.Text = "Số điện thoại:";
            // 
            // txtRegisMK
            // 
            this.txtRegisMK.Location = new System.Drawing.Point(327, 314);
            this.txtRegisMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisMK.Name = "txtRegisMK";
            this.txtRegisMK.PasswordChar = '•';
            this.txtRegisMK.Size = new System.Drawing.Size(211, 22);
            this.txtRegisMK.TabIndex = 2;
            this.txtRegisMK.Text = "Nhập mật khẩu";
            this.txtRegisMK.Enter += new System.EventHandler(this.txtRegisMK_Enter);
            this.txtRegisMK.Leave += new System.EventHandler(this.txtRegisMK_Leave);
            // 
            // txtRegisTK
            // 
            this.txtRegisTK.Location = new System.Drawing.Point(327, 268);
            this.txtRegisTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisTK.Name = "txtRegisTK";
            this.txtRegisTK.Size = new System.Drawing.Size(211, 22);
            this.txtRegisTK.TabIndex = 1;
            this.txtRegisTK.Text = "Nhập tài khoản";
            this.txtRegisTK.Enter += new System.EventHandler(this.txtRegisTK_Enter);
            this.txtRegisTK.Leave += new System.EventHandler(this.txtRegisTK_Leave);
            // 
            // txtReregismk
            // 
            this.txtReregismk.Location = new System.Drawing.Point(327, 361);
            this.txtReregismk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReregismk.Name = "txtReregismk";
            this.txtReregismk.PasswordChar = '•';
            this.txtReregismk.Size = new System.Drawing.Size(211, 22);
            this.txtReregismk.TabIndex = 3;
            this.txtReregismk.Text = "Nhập lại mật khẩu";
            this.txtReregismk.Enter += new System.EventHandler(this.txtReregisMK_Enter);
            this.txtReregismk.Leave += new System.EventHandler(this.txtReregismk_Leave);
            // 
            // txtRegisSDT
            // 
            this.txtRegisSDT.Location = new System.Drawing.Point(327, 408);
            this.txtRegisSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisSDT.Name = "txtRegisSDT";
            this.txtRegisSDT.Size = new System.Drawing.Size(211, 22);
            this.txtRegisSDT.TabIndex = 4;
            this.txtRegisSDT.Text = "Nhập số điện thoại";
            this.txtRegisSDT.Enter += new System.EventHandler(this.txtRegisSDT_Enter);
            this.txtRegisSDT.Leave += new System.EventHandler(this.txtRegisSDT_Leave);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(327, 471);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(136, 50);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(749, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Location = new System.Drawing.Point(364, 538);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(45, 17);
            this.lblThoat.TabIndex = 6;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // ckbHienMK
            // 
            this.ckbHienMK.AutoSize = true;
            this.ckbHienMK.Location = new System.Drawing.Point(417, 445);
            this.ckbHienMK.Name = "ckbHienMK";
            this.ckbHienMK.Size = new System.Drawing.Size(121, 21);
            this.ckbHienMK.TabIndex = 7;
            this.ckbHienMK.Text = "Hiện mật khẩu";
            this.ckbHienMK.UseVisualStyleBackColor = true;
            this.ckbHienMK.CheckedChanged += new System.EventHandler(this.ckbHienMK_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaoHiemTDT.Properties.Resources.logo_login1;
            this.pictureBox1.Location = new System.Drawing.Point(241, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.ckbHienMK);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtRegisSDT);
            this.Controls.Add(this.txtReregismk);
            this.Controls.Add(this.txtRegisTK);
            this.Controls.Add(this.txtRegisMK);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.lblRepeatMK);
            this.Controls.Add(this.lblRegisterMK);
            this.Controls.Add(this.lblRegisterTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegisterTK;
        private System.Windows.Forms.Label lblRegisterMK;
        private System.Windows.Forms.Label lblRepeatMK;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.TextBox txtRegisMK;
        private System.Windows.Forms.TextBox txtRegisTK;
        private System.Windows.Forms.TextBox txtReregismk;
        private System.Windows.Forms.TextBox txtRegisSDT;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.CheckBox ckbHienMK;
    }
}