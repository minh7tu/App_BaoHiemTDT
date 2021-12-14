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
    public partial class frmAsset : Form
    {
        BaoHiemTDT.Config.TDT tdt = new Config.TDT();

        public frmAsset()
        {
            InitializeComponent();
        }

        private void frmAsset_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnComQLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChayNoBatBuoc_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblchaynobatbuoc.Text;
            tdt.openPay();
        }

        private void btnHoaHoanVaRuiro_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblHoaHoanVaRuiRo.Text;
            tdt.openPay();
        }

        private void btnRuiRoTaiSan_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblRuiroTaiSan.Text;
            tdt.openPay();
        }

        private void btnGianDoanKinhDoanh_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblGianDoanKinhDoanh.Text;
            tdt.openPay();
        }

        private void btnRuiDoCongNghiep_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblRuiRoCongNghiep.Text;
            tdt.openPay();
        }

        private void btnTaiKhoanTrucTuyen_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTaiKhoanTrucTuyen.Text;
            tdt.openPay();
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblThuongHieu.Text;
            tdt.openPay();
        }

        private void btnTromCap_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTromCap.Text;
            tdt.openPay();
        }

      
    }
}
