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
    public partial class frmCommerce : Form
    {
        BaoHiemTDT.Config.TDT tdt = new Config.TDT();

        public frmCommerce()
        {
            InitializeComponent();
        }

        private void btnSinhKy_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblSinhKy.Text;
            tdt.openPay();
        }

 
        private void btnTuKy_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTuKy.Text;
            tdt.openPay();
        }
        private void btnTronDoi_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTronDoi.Text;
            tdt.openPay();
        }

        private void btnHonHop_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblHonHop.Text;
            tdt.openPay();
        }
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblHangHoa.Text;
            tdt.openPay();
        }

        private void btnChayNo_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblChayNo.Text;
            tdt.openPay();
        }

        private void btnTaiSan_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTaiSan.Text;
            tdt.openPay();
        }

        private void btnXeCoGioi_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblXeCoGioi.Text;
            tdt.openPay();
        }

        private void btnSucKhoe_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblSucKhoe.Text;
            tdt.openPay();
        }

        private void btnYTe_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblYTe.Text;
            tdt.openPay();
        }

        private void btnChamSoc_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblChamSoc.Text;
            tdt.openPay();
        }

        private void btnTaiNan_Click(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.bh = lblTaiNan.Text;
            tdt.openPay();
        }


        private void btnComQLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCommerce_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        

       

       

        

        
    }
}
