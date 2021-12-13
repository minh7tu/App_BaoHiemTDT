using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaoHiemTDT.Config;
using System.Data.SqlClient;

namespace BaoHiemTDT.Feature
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();

        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            lblCheck.Visible = false;
            lblCheckTK.Visible = false;
            lblCheckSDT.Visible = false;



        }

        private void liblForgetExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }


        private void btnForgetCheck_Click(object sender, EventArgs e)
        {
      
                //Mo ket noi
                BaoHiemTDT.Config.TDT.Connect();
                string capnhat = "UPDATE TAIKHOAN set MatKhau = '" + txtForgetMK.Text + "' where TenTK='" + txtForgetTK.Text + "'and SDT='" + txtForgetSDT.Text + "'";
                SqlCommand scmd = new SqlCommand(capnhat, BaoHiemTDT.Config.TDT.connect);
                scmd.ExecuteNonQuery();
                BaoHiemTDT.Config.TDT.Disconect();
                MessageBox.Show("Cập nhật mật khẩu thành công!");
                new frmLogin().Show();
                this.Hide();
  
        }

        private void txtReforgetMK_TextChanged(object sender, EventArgs e)
        {
            if (txtReforgetMK.Text != txtForgetMK.Text)
            {
                lblCheck.Visible = true;
                lblCheck.ForeColor = Color.Red;

            }
            else
            {
                lblCheck.Visible = false;
                
            }
        }

        private void txtForgetTK_TextChanged(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.Connect();
            string kttk = "select TenTK from TAIKHOAN where TenTK = '" + txtForgetTK.Text +"'";
            SqlCommand scd = new SqlCommand(kttk,BaoHiemTDT.Config.TDT.connect);
            SqlDataReader sdr = scd.ExecuteReader();
            if (sdr.Read())
            {
                lblCheckTK.Visible = false;

            }
            else {
                lblCheckTK.Visible = true;
                lblCheckTK.ForeColor = Color.Red;
            }
            BaoHiemTDT.Config.TDT.Disconect();
            
        }

        private void txtForgetSDT_TextChanged(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.Connect();
            string ktsdt = "select SDT from TAIKHOAN where SDT = '" + txtForgetSDT.Text + "'";
            SqlCommand scd = new SqlCommand(ktsdt, BaoHiemTDT.Config.TDT.connect);
            SqlDataReader sdr = scd.ExecuteReader();
            if (sdr.Read())
            {
                lblCheckSDT.Visible = false;

            }
            else
            {
                lblCheckSDT.Visible = true;
                lblCheckSDT.ForeColor = Color.Red;
            }
            BaoHiemTDT.Config.TDT.Disconect();
        }

        private void ckbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThi.Checked)
            {
                txtForgetMK.PasswordChar = '\0';
                txtReforgetMK.PasswordChar = '\0';
            }
            else
            {
                txtForgetMK.PasswordChar = '•';
                txtReforgetMK.PasswordChar = '•';
            }
        }
    }
}
