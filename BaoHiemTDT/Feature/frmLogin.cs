﻿using BaoHiemTDT.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BaoHiemTDT.Feature
{
    public partial class frmLogin : Form
    {
        Thread th;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Tài khoản")
            {
                txtTaiKhoan.Text = "";

                txtTaiKhoan.ForeColor = Color.Black;
            }

        }
        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "Tài khoản";

                txtTaiKhoan.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";

                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";

                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                this.Close_Open();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bạn nhập đã sai.Vui lòng nhập lại");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
            
        }

        private void Close_Open()
        {
            this.Close();
            th = new Thread(openNewFrom);
            th.Start();
        }

        private void openNewFrom()
        {
            
                Application.Run(new frmMaster());
            
        }

        private void Close_Open1()
        {
            this.Close();
            th = new Thread(openNewFrom1);
            th.Start();
        }

        private void openNewFrom1()
        {
            Application.Run(new frmRegister());
        }

        private void liblTaoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close_Open1();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
