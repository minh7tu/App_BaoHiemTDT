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

            BaoHiemTDT.Config.TDT.Connect();
            String sql = "Select * from KHACHHANG";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, BaoHiemTDT.Config.TDT.connect);
            dap.Fill(ds); 
            //Gan du lieu len dgv
            dgvQuanLy.DataSource = ds.Tables[0];
            dgvQuanLy.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvQuanLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

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
            }
        }

        
    }
}
