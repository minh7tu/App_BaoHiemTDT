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
    public partial class frmCustomer : Form
    {

        string user;

        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(string username)
        {
            InitializeComponent();
            user = username;
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

            BaoHiemTDT.Config.TDT.Connect();
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
