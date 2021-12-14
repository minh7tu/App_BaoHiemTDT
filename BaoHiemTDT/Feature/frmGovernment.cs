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
    public partial class frmGovernment : Form
    {
        BaoHiemTDT.Config.TDT tdt = new Config.TDT();

        public frmGovernment()
        {
            InitializeComponent();
        }

        private void frmGovernment_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnComQLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrongNuoc_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTrongNuoc.Text;
            tdt.openPay();
        }

        private void btnQuocTe_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblQuocTe.Text;
            tdt.openPay();
        }

        private void btnBaoViet_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblBaoViet.Text;
            tdt.openPay();
        }

        private void btnPVi_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblPVi.Text;
            tdt.openPay();
        }

        private void btnAli_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblAli.Text;
            tdt.openPay();
        }

        private void btnChamSocSK_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblChamSocSK.Text;
            tdt.openPay();
        }

        private void btnBatBuoc_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblBatBuoc.Text;
            tdt.openPay();
        }

        private void btnTuNguyen_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTuNguyen.Text;
            tdt.openPay();
        }

        
    }
}
