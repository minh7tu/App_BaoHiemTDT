using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            
            lblSoThe.Visible = false;
            txtPSthe.Visible = false;
         
        }

        private void cbbPTenNH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPSthe.Visible = true;
            lblSoThe.Visible = true;

            
        }

        private void lblHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPSthe_TextChanged(object sender, EventArgs e)
        {
            if (txtPSthe.Text == "")
            {
                txtPStk.Visible = false;
                lblPStk.Visible = false;
            }
            else
            {
                txtPStk.Visible = true;
                lblPStk.Visible = true;
            }
        }  

        private void txtPStk_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPStk.Text == "")
            {
                btnPThanhToan.Visible = false;
            }
            else {
                btnPThanhToan.Visible = true;
            }
        }
      
        private void btnPThanhToan_Click(object sender, EventArgs e)
        {   
             MessageBox.Show("Thanh toán thành công!Giao dịch của bạn sẽ được lưu vào dữ liệu!");
             this.Close(); 
           
        }
        

       
    }
}
