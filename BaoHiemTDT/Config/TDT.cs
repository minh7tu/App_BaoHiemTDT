using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaoHiemTDT.Config
{
    class TDT
    {
        public static SqlConnection connect;

        public TDT()
        { 
        
        }

        public static void Connect()
        {
            //Dai
            //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BaoHiem\BaoHiemTDT\BaoHiemTDT\Data\BaoHiemTDT.mdf;Integrated Security=True";
            //Thuyet
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\BaoHiemTDT\BaoHiemTDT\Data\BaoHiemTDT.mdf;Integrated Security=True";
            //Tu
            //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BaoHiem\BaoHiemTDT\BaoHiemTDT\Data\BaoHiemTDT.mdf;Integrated Security=True";
       
            connect = new SqlConnection(str);
            connect.Open();
        }

        public static void Disconect()
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
