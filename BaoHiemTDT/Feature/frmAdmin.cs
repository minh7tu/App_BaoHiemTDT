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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            BaoHiemTDT.Config.TDT.Connect();
            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BaoHiem\BaoHiemTDT\BaoHiemTDT\Data\BaoHiemTDT.mdf;Integrated Security=True";
            con.Open();*/
            string sql = "Select * from KHACHHANG";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql,BaoHiemTDT.Config.TDT.connect);
            dap.Fill(ds);

            //Gan du lieu len Datagrid
            dgvQuanLy.DataSource = ds.Tables[0];
            dgvQuanLy.Refresh();

        }
    }
}
