using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BaoHiemTDT.Master;

namespace BaoHiemTDT.Feature
{
    public partial class frmCustomer : Form
    {

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtHoTen.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;

            txtHoTen.Text = frmMaster.tk;
            
            //BaoHiemTDT.Config.TDT.Connect();
            //try
            //{
                
            //    SqlCommand scd = new SqlCommand(tk,BaoHiemTDT.Config.TDT.connect);
            //    SqlDataReader data = scd.ExecuteReader();

            //    if (data.Read())
            //    {
            //        txtSDT.Text = data[0].ToString();
            //        txtHoTen.Text = data[1].ToString();
            //        txtGioiTinh.Text = data[2].ToString();
            //        txtNgaySinh.Text = data[3].ToString();
            //        txtEmail.Text = data[4].ToString();
            //        txtDiaChi.Text = data[5].ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //BaoHiemTDT.Config.TDT.Disconect();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Hiển thị nút lưu
            btnSave.Visible = true;
            //Cho phép chỉnh sửa thông tin
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtSDT.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Viết câu lệnh update dữ liệu

            //Ẩn nút lưu
            btnSave.Visible = false;
            //Chỉ cho phép đọc dữ liệu
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtHoTen.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
        }
    }
}
