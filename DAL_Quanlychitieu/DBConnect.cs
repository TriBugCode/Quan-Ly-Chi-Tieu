using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Quanlychitieu
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=quanlychitieu;Integrated Security=True;");
        //protected SqlConnection _conn = new SqlConnection(@"Data Source=172.16.27.160;Initial Catalog=SOF205_QLBanHang;User ID=sa;Password=ditmemay;TrustServerCertificate=True");
        //static string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
        //protected  SqlConnection _conn = new SqlConnection(@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=""A:\E#(DATA - NTFS 1)\APTECH\FPOLY\SP2017\DUANMAUC#\C#TEMPLATEPROJECT\TEMPLATEPROJECT1_QLBANHANG\QLBANHANG1.MDF"";Integrated Security=True;");
        //protected SqlConnection _conn = new SqlConnection(strConnection);

    }
}
