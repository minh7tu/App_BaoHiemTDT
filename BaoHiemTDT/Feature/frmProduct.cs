using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaoHiemTDT.Master;

namespace BaoHiemTDT.Feature
{
    public partial class frmProduct : Form
    {

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void btnComInsurance_Click(object sender, EventArgs e)
        {
            frmCommerce com = new frmCommerce();
            com.ShowDialog();
        }

        private void btnStateInsurance_Click(object sender, EventArgs e)
        {
            frmGovernment gov = new frmGovernment();
            gov.ShowDialog();
        }

        private void btnProInsurance_Click(object sender, EventArgs e)
        {
            frmAsset ass = new frmAsset();
            ass.ShowDialog();
        }

        
    }
}
