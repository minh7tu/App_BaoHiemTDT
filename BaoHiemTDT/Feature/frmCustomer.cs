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
        public static string sdt;

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
            cbbTenGT.Enabled = false;
            txtSo.Enabled = false;
            txtNgayCap.Enabled = false;
            txtNoiCap.Enabled = false;
            
            BaoHiemTDT.Config.TDT.Connect();
            try
            {

                string sodt = "select SDT from TAIKHOAN where TenTK='" + frmMaster.tk.ToString() + "'";
                SqlCommand scd0 = new SqlCommand(sodt, BaoHiemTDT.Config.TDT.connect);
                SqlDataReader data0 = scd0.ExecuteReader();
                if (data0.Read())
                    txtSDT.Text = data0["SDT"].ToString();

                sdt = txtSDT.Text;

                BaoHiemTDT.Config.TDT.Disconect();
                BaoHiemTDT.Config.TDT.Connect();
                string tkn = "select * from KHACHHANG where KHACHHANG.SDT='" + txtSDT.Text + "'";
                SqlCommand scd = new SqlCommand(tkn, BaoHiemTDT.Config.TDT.connect);
                SqlDataReader dt = scd.ExecuteReader();
                if (dt.Read())
                {
                    txtHoTen.Text = dt["HoTen"].ToString();
                    txtGioiTinh.Text = dt["GioiTinh"].ToString();
                    txtNgaySinh.Text = dt["NgaySinh"].ToString();
                    txtEmail.Text = dt["Email"].ToString();
                    txtDiaChi.Text = dt["DiaChi"].ToString();
                   
                    
                }
                //BaoHiemTDT.Config.TDT.Disconect();

                BaoHiemTDT.Config.TDT.Connect();
                string giayto = "select * from GIAYTO where SDT='" + txtSDT.Text + "'";
                SqlCommand scd1 = new SqlCommand(giayto, BaoHiemTDT.Config.TDT.connect);
                SqlDataReader data1 = scd1.ExecuteReader();
                if (data1.Read())
                {
                    cbbTenGT.Text = data1["TenGT"].ToString();
                    txtSo.Text = data1["MaGT"].ToString();
                    txtNgayCap.Text = data1["NgayCap"].ToString();
                    txtNoiCap.Text = data1["NoiCap"].ToString();
                }
                //BaoHiemTDT.Config.TDT.Disconect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BaoHiemTDT.Config.TDT.Disconect();
           


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
            txtSo.Enabled = true;
            txtNgayCap.Enabled = true;
            txtNoiCap.Enabled = true;
        
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Viết câu lệnh update dữ liệu
            BaoHiemTDT.Config.TDT.Connect();
            
            //khai báo câu lệnh cập nhật dữ liệu cập nhập thông tin bảng khách hàng
            string updateInfo = "update KHACHHANG set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" + txtGioiTinh.Text + "',Email='" + txtEmail.Text + "',";
            updateInfo += "DiaChi='" + txtDiaChi.Text + "' where SDT='" + frmCustomer.sdt + "'";

            SqlCommand scd = new SqlCommand(updateInfo, BaoHiemTDT.Config.TDT.connect);
            scd.ExecuteNonQuery();
            BaoHiemTDT.Config.TDT.Disconect();
            
            BaoHiemTDT.Config.TDT.Connect();

            string updateGT = "update GIAYTO set MaGT='" + txtSo.Text + "',TenGT='" + cbbTenGT.Text + "',NoiCap=N'" + txtNoiCap.Text + "'";
            updateGT += "Where SDT='" + frmCustomer.sdt + "'";

            SqlCommand scd1 = new SqlCommand(updateGT, BaoHiemTDT.Config.TDT.connect);
            scd1.ExecuteNonQuery();
           
            //Ẩn nút lưu
            btnSave.Visible = false;
            //Chỉ cho phép đọc dữ liệu
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtHoTen.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            cbbTenGT.Enabled = false;
            txtSo.Enabled = false;
            txtNgayCap.Enabled = false;
            txtNoiCap.Enabled = false;



        }
    }
}
