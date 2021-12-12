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
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lblPStk.Visible = false;
            txtPStk.Visible = false;
            btnPThanhToan.Visible = false;
        }

        private void cbbPTenNH_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPStk.Visible = true;
            txtPStk.Visible = true;
        }

        

        
    }
}
