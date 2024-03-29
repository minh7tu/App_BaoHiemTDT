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
using BaoHiemTDT.Config;
using System.Data.SqlClient;

namespace BaoHiemTDT.Feature
{
    public partial class frmLogin : Form
    {
        Thread th;
        string username ;

        public frmLogin()
        {
            InitializeComponent();
        }

        public string getUsername()
        {
            username = txtTaiKhoan.Text;
            return username;
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
            username = txtTaiKhoan.Text;//Gán username bằng textbox tài khoản
            //Kiểm tra kết nối
            try
            {
                TDT.Connect();

            }
            catch
            {
                MessageBox.Show("Máy chủ đang quá tải.Vui lòng thử lại sau.");
            }
            //Khai báo câu lệnh truy vấn sql đọc thông tin tài khoản trong database

            string dangnhap = " select * FROM TAIKHOAN where TenTK = '" + txtTaiKhoan.Text + "' and MatKhau = '" + txtMatKhau.Text + "'";
            SqlCommand scd = new SqlCommand(dangnhap, TDT.connect);
            SqlDataReader sdr = scd.ExecuteReader();
            if (sdr.Read())//Đọc dữ liệu trong database
            {
                this.Close_Open();
                TDT.Disconect();
            }
            else {
                MessageBox.Show("Tài khoản hoặc mật khẩu bạn nhập đã sai. Vui lòng nhập lại");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
            /*if (txtTaiKhoan.Text == "minhtu" && txtMatKhau.Text == "123")
            {
                this.Close_Open();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bạn nhập đã sai.Vui lòng nhập lại");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }*/
           
        }

        private void Close_Open()
        {
            this.Close();
            th = new Thread(openNewFrom);
            th.Start();
        }

        private void openNewFrom()
        {
          
            Application.Run(new frmMaster(username));
            
        }

        private void Close_Open1()
        {
            this.Close();
            th = new Thread(openNewFrom1);
            th.Start();
        }

        private void Close_Open2()
        {
            this.Close();
            th = new Thread(openNewFrom2);
            th.Start();
        }

        private void openNewFrom2()
        {
            Application.Run(new frmForgotPassword());
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

        private void liblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close_Open2();
        }

        private void lilblThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        //An Hien mat khau
        private void ckbLHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLHienMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '•';
            }
        }
    }
}
