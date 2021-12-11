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
        }

       

       
    }
}
