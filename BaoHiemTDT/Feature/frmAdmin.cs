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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        //Hien Thi thong tin len datagridview
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            txtAHoTen.Enabled = false;
            txtASdt.Enabled = false;
            txtANgaySinh.Enabled = false;
            txtAGioiTinh.Enabled = false;
            txtAEmail.Enabled = false;
            txtADiaChi.Enabled = false;
            txtATaiKhoan.Enabled = false;
            txtAPhanLoai.Enabled = false;

            

            BaoHiemTDT.Config.TDT.Connect();

            String sql = "Select HoTen,KHACHHANG.SDT,GioiTinh,NgaySinh,Email,DiaChi,TenTK,PhanLoai from KHACHHANG,TAIKHOAN where TAIKHOAN.SDT = KHACHHANG.SDT ";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, BaoHiemTDT.Config.TDT.connect);
            dap.Fill(ds);
            //Gan du lieu len dgv
            dgvQuanLy.DataSource = ds.Tables[0];
            dgvQuanLy.Refresh();
            

         
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtAHoTen.Enabled = true;
            txtASdt.Enabled = true;
            txtANgaySinh.Enabled = true;
            txtAGioiTinh.Enabled = true;
            txtAEmail.Enabled = true;
            txtADiaChi.Enabled = true;
            txtATaiKhoan.Enabled = true;
            txtAPhanLoai.Enabled = true;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtAHoTen.Clear();
            txtASdt.Clear();
            txtANgaySinh.Clear();
            txtAGioiTinh.Clear();
            txtAEmail.Clear();
            txtADiaChi.Clear();
            txtATaiKhoan.Clear();
            txtAPhanLoai.Clear();


        }

        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLy.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvQuanLy.CurrentRow.Selected = true;
                txtAHoTen.Text = dgvQuanLy.Rows[e.RowIndex].Cells["HoTen"].FormattedValue.ToString();
                txtASdt.Text = dgvQuanLy.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
                txtAGioiTinh.Text = dgvQuanLy.Rows[e.RowIndex].Cells["GioiTinh"].FormattedValue.ToString();
                txtANgaySinh.Text = dgvQuanLy.Rows[e.RowIndex].Cells["NgaySinh"].FormattedValue.ToString();
                txtADiaChi.Text = dgvQuanLy.Rows[e.RowIndex].Cells["DiaChi"].FormattedValue.ToString();
                txtAEmail.Text = dgvQuanLy.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                txtAPhanLoai.Text = dgvQuanLy.Rows[e.RowIndex].Cells["PhanLoai"].FormattedValue.ToString();
                txtATaiKhoan.Text = dgvQuanLy.Rows[e.RowIndex].Cells["TenTK"].FormattedValue.ToString();
            }


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sdt = null;
            BaoHiemTDT.Config.TDT.Connect();
            string sdtt = "select SDT from TAIKHOAN where TenTK='" + BaoHiemTDT.Master.frmMaster.tk + "'";
            SqlCommand scd11 = new SqlCommand(sdtt, BaoHiemTDT.Config.TDT.connect);
            SqlDataReader data = scd11.ExecuteReader();

            if (data.Read())
                sdt = data["SDT"].ToString();


            BaoHiemTDT.Config.TDT.Connect();
            string updateAccout = "update TAIKHOAN set TenTK='" + txtATaiKhoan.Text + "',PhanLoai='" + txtAPhanLoai.Text + "' where SDT ='" + sdt + "'";
            SqlCommand scd = new SqlCommand(updateAccout, BaoHiemTDT.Config.TDT.connect);
            scd.ExecuteNonQuery();
            BaoHiemTDT.Config.TDT.Disconect();

            //BaoHiemTDT.Config.TDT.Connect();
            //string updateCustom = "update KHACHHANG set HoTen=N'" + txtAHoTen.Text + "',GioiTinh='" + txtAGioiTinh.Text + "',Email='" + txtAEmail.Text + "',DiaChi='" + txtADiaChi.Text + "'";
            //updateCustom += "where SDT='" + sdt + "'";
            //SqlCommand scd12 = new SqlCommand(updateCustom, BaoHiemTDT.Config.TDT.connect);
            //scd12.ExecuteNonQuery();
            //BaoHiemTDT.Config.TDT.Disconect();

            txtAHoTen.Enabled = false;
            txtASdt.Enabled = false;
            txtANgaySinh.Enabled = false;
            txtAGioiTinh.Enabled = false;
            txtAEmail.Enabled = false;
            txtADiaChi.Enabled = false;
            txtATaiKhoan.Enabled = false;
            txtAPhanLoai.Enabled = false;
        }  
    }
}
