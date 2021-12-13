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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

      
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.Connect();
            String sql = "Select * from KHACHHANG";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, BaoHiemTDT.Config.TDT.connect);
            dap.Fill(ds); 
            //Gan du lieu len dgv
            dgvQuanLy.DataSource = ds.Tables[0];
            dgvQuanLy.Refresh();
        }
    }
}
