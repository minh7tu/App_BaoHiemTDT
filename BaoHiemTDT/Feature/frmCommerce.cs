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
        public frmCommerce()
        {
            InitializeComponent();
        }

        private void btnSinhKy_Click(object sender, EventArgs e)
        {
            frmContract sinhky = new frmContract();
            sinhky.ShowDialog();
        }

 
        private void btnTuKy_Click(object sender, EventArgs e)
        {
            frmContract tuky = new frmContract();
            tuky.ShowDialog();
        }
        private void btnTronDoi_Click(object sender, EventArgs e)
        {
            frmContract trondoi = new frmContract();
            trondoi.ShowDialog();
        }

        private void btnHonHop_Click(object sender, EventArgs e)
        {
            frmContract honhop = new frmContract();
            honhop.ShowDialog();
        }
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmContract hanghoa = new frmContract();
            hanghoa.ShowDialog();
        }

        private void btnChayNo_Click(object sender, EventArgs e)
        {
            frmContract chayno = new frmContract();
            chayno.ShowDialog();
        }

        private void btnTaiSan_Click(object sender, EventArgs e)
        {
            frmContract taisan = new frmContract();
            taisan.ShowDialog();
        }

        private void btnXeCoGioi_Click(object sender, EventArgs e)
        {
            frmContract xecogioi = new frmContract();
            xecogioi.ShowDialog();
        }

        private void btnSucKhoe_Click(object sender, EventArgs e)
        {
            frmContract suckhoe = new frmContract();
            suckhoe.ShowDialog();
        }

        private void btnYTe_Click(object sender, EventArgs e)
        {
            frmContract yte = new frmContract();
            yte.ShowDialog();
        }

        private void btnChamSoc_Click(object sender, EventArgs e)
        {
            frmContract chamsoc = new frmContract();
            chamsoc.ShowDialog();
        }

        private void btnTaiNan_Click(object sender, EventArgs e)
        {
            frmContract tainan = new frmContract();
            tainan.ShowDialog();
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
