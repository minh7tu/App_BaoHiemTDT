using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BaoHiemTDT.Config
{
    class TDT
    {
        public static SqlConnection connect;

        public TDT()
        { 
        
        }

        public void Connect()
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data\BaoHiemTDT.mdf;Integrated Security=True";
            connect = new SqlConnection(str);
            connect.Open();
        }

        public void Close()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
                connect.Dispose();//Giải phóng tài nguyên
                connect = null;
            }
        }
    }
}
