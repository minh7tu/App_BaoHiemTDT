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
            this.lblForgetTK.Location = new System.Drawing.Point(196, 267);
            this.lblForgetTK.Name = "lblForgetTK";
            this.lblForgetTK.Size = new System.Drawing.Size(71, 17);
            this.lblForgetTK.TabIndex = 2;
            this.lblForgetTK.Text = "Tài khoản";
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
            this.lblForgetSDT.Location = new System.Drawing.Point(196, 308);
            this.lblForgetSDT.Name = "lblForgetSDT";
            this.lblForgetSDT.Size = new System.Drawing.Size(91, 17);
            this.lblForgetSDT.TabIndex = 2;
            this.lblForgetSDT.Text = "Số điện thoại";
            // 
            // txtForgetTK
            // 
            this.txtForgetTK.Location = new System.Drawing.Point(315, 262);
            this.txtForgetTK.Name = "txtForgetTK";
            this.txtForgetTK.Size = new System.Drawing.Size(177, 22);
            this.txtForgetTK.TabIndex = 3;
            // 
            // txtForgetSDT
            // 
            this.txtForgetSDT.Location = new System.Drawing.Point(315, 303);
            this.txtForgetSDT.Name = "txtForgetSDT";
            this.txtForgetSDT.Size = new System.Drawing.Size(177, 22);
            this.txtForgetSDT.TabIndex = 4;
            // 
            // btnForgetCheck
            // 
            this.btnForgetCheck.Location = new System.Drawing.Point(315, 350);
            this.btnForgetCheck.Name = "btnForgetCheck";
            this.btnForgetCheck.Size = new System.Drawing.Size(108, 39);
            this.btnForgetCheck.TabIndex = 5;
            this.btnForgetCheck.Text = "Kiểm tra";
            this.btnForgetCheck.UseVisualStyleBackColor = true;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(731, 525);
            this.Controls.Add(this.btnForgetCheck);
            this.Controls.Add(this.txtForgetSDT);
            this.Controls.Add(this.txtForgetTK);
            this.Controls.Add(this.lblForgetSDT);
            this.Controls.Add(this.lblForgetTK);
            this.Controls.Add(this.lblQuenMK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmForgotPassword";
            this.Text = "frmForgotPassword";
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
    }
}