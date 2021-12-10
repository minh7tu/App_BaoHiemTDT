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
    }
}
