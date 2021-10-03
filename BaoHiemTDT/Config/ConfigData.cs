using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BaoHiemTDT.Config
{
    class ConfigData
    {
        public ConfigData()
        { 
        
        }

        public void Open()
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\BaoHiemTDT\BaoHiemTDT\Data\BaoHiemTDT.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
        }

        public void Close()
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\BaoHiemTDT\BaoHiemTDT\Data\BaoHiemTDT.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Close();
        }
    }
}
