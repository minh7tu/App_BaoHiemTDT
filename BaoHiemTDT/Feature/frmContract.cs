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
    public partial class frmContract : Form
    {

        public frmContract()
        {
            InitializeComponent();
        }

        private void btnCTThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCTDongY_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPay pay = new frmPay();
            pay.ShowDialog();
        }

        private void ckbCTDongY_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCTDongY.Checked)
                btnCTDongY.Enabled = true;
            else
                btnCTDongY.Enabled = false;
        }

        private void frmContract_Load(object sender, EventArgs e)
        {
            string sdt = null;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            btnCTDongY.Enabled = false;
            txtCTCccd.Enabled = false;
            txtCTChiPhi.Enabled = false;
            txtCTGioiTinh.Enabled = false;
            txtCTHoTen.Enabled = false;
            txtCTNgayMua.Enabled = false;
            txtCTNgaySinh.Enabled = false;
            txtCTSdt.Enabled = false;
            txtCTTenBH.Enabled = false;
            rtbCTChiTiet.Enabled = false;
            //Ket Noi de hien thi so dien thoai
            BaoHiemTDT.Config.TDT.Connect();

            string sodt = "select SDT from TAIKHOAN where TenTK='" + BaoHiemTDT.Master.frmMaster.tk.ToString() + "'";
            SqlCommand scd0 = new SqlCommand(sodt, BaoHiemTDT.Config.TDT.connect);
            SqlDataReader data0 = scd0.ExecuteReader();
            if (data0.Read())
                sdt = data0["SDT"].ToString();

            BaoHiemTDT.Config.TDT.Disconect();
            //Ket noi de hien thi thong tin co ban cua khach hang

            BaoHiemTDT.Config.TDT.Connect();
            string tk = "select SDT,HoTen,NgaySinh,GioiTinh from KHACHHANG where SDT='" + sdt + "'";
            SqlCommand scd = new SqlCommand(tk, BaoHiemTDT.Config.TDT.connect);
            SqlDataReader data = scd.ExecuteReader();

            if (data.Read())
            {
                txtCTSdt.Text = data["SDT"].ToString();
                txtCTHoTen.Text = data["HoTen"].ToString();
                txtCTNgaySinh.Text = data["NgaySinh"].ToString();
                txtCTGioiTinh.Text = data["GioiTinh"].ToString();
            }
            BaoHiemTDT.Config.TDT.Disconect();
            //Ket noi de hien thi so CCCD
            BaoHiemTDT.Config.TDT.Connect();

            string giayto = "Select MaGT from GIAYTO where SDT='" + txtCTSdt.Text + "'";
            SqlCommand scd1 = new SqlCommand(giayto, BaoHiemTDT.Config.TDT.connect);
            SqlDataReader data1 = scd1.ExecuteReader();

            if (data1.Read())
            {
                txtCTCccd.Text = data1["MaGT"].ToString();
            }
            BaoHiemTDT.Config.TDT.Disconect();
            //Ket noi de hien thi thong tin goi bao hiem
            txtCTTenBH.Text = BaoHiemTDT.Config.TDT.bh;
            txtCTNgayMua.Text = DateTime.Now.Date.ToShortDateString();

        }
       
    }
}
