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

        private void btnComQLai_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTuKy_Click(object sender, EventArgs e)
        {

        }

       

        

        
    }
}
