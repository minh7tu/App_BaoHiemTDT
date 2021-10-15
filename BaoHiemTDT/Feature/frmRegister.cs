using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaoHiemTDT.Feature
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        //Placeholder cho textbox
        private void frmRegister_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void txtRegisMKa_Enter(object sender, EventArgs e)
        {
            if (txtRegisMKa.Text == "Nhập lại mật khẩu")
            {
                txtRegisMKa.Text = "";

                txtRegisMKa.ForeColor = Color.Black;
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

        private void txtRegisEmail_Enter(object sender, EventArgs e)
        {
            if (txtRegisEmail.Text == "Nhập vào Email")
            {
                txtRegisEmail.Text = "";

                txtRegisEmail.ForeColor = Color.Black;
            }
        }

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

        private void txtRegisMKa_Leave(object sender, EventArgs e)
        {
            if (txtRegisMKa.Text == "")
            {
                txtRegisMKa.Text = "Nhập vào mật khẩu";

                txtRegisMKa.ForeColor = Color.Silver;
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

        private void txtRegisEmail_Leave(object sender, EventArgs e)
        {
            if (txtRegisEmail.Text == "")
            {
                txtRegisEmail.Text = "Nhập vào Email";

                txtRegisEmail.ForeColor = Color.Silver;
            }
        }
    }
}
