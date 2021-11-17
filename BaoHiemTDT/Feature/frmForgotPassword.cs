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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void liblForgetExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
