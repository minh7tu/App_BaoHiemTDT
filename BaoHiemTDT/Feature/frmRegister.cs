using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaoHiemTDT.Feature
{
    public partial class frmRegister : Form
    {
        string connectionString ="";
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //placeholder cho các textbox
            //Enter
        private void txtRegisTK_Enter(object sender, EventArgs e)
        {
            if (txtRegisTK.Text == "Nhập tài khoản")
            {
                txtRegisTK.Text = "";

                txtRegisTK.ForeColor = Color.Black;
            }
        }

        private void txtRegisMK_Enter(object sender, EventArgs e)
        {
            if (txtRegisMK.Text == "Nhập mật khẩu")
            {
                txtRegisMK.Text = "";

                txtRegisMK.ForeColor = Color.Black;
            }              
        }                      
                               
        private void txtReregisMK_Enter(object sender, EventArgs e)
        {
            if (txtReregismk.Text == "Nhập lại mật khẩu")
            {
                txtReregismk.Text = "";

                txtReregismk.ForeColor = Color.Black;
            }        
        }

        private void txtRegisSDT_Enter(object sender, EventArgs e)
        {
            if (txtRegisSDT.Text == "Nhập số điện thoại")
            {
                txtRegisSDT.Text = "";

                txtRegisSDT.ForeColor = Color.Black;
            }
        }

       
            //Leave
        private void txtRegisTK_Leave(object sender, EventArgs e)
        {
            if (txtRegisTK.Text == "")
            {
                txtRegisTK.Text = "Nhập tài khoản";

                txtRegisTK.ForeColor = Color.Silver;
            }
        }

        private void txtRegisMK_Leave(object sender, EventArgs e)
        {
            if (txtRegisMK.Text == "")
            {
                txtRegisMK.Text = "Nhập mật khẩu";

                txtRegisMK.ForeColor = Color.Silver;
            }  
        }

        private void txtReregismk_Leave(object sender, EventArgs e)
        {
            if (txtReregismk.Text == "")
            {
                txtReregismk.Text = "Nhập lại mật khẩu";

                txtReregismk.ForeColor = Color.Silver;
            }     
        }

        private void txtRegisSDT_Leave(object sender, EventArgs e)
        {
            if (txtRegisSDT.Text == "")
            {
                txtRegisSDT.Text = "Nhập số điện thoại";

                txtRegisSDT.ForeColor = Color.Silver;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
        //An Hien mat khau
        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked)
            {
                txtRegisMK.PasswordChar = '\0';
                txtReregismk.PasswordChar = '\0';
            }
            else
            {
                txtRegisMK.PasswordChar = '•';
                txtReregismk.PasswordChar = '•'; 
            }
        }


    }
}
