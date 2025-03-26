using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Quanlychitieu
{
    public class DAL_Hang : DBConnect
    {
        public DataTable getthunhap()
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThuNhap", _conn);
                DataTable dtthunhap = new DataTable();
                da.Fill(dtthunhap);
                return dtthunhap;
            }
        public bool Inserthunhap(DTO_ThuNhap mathunhap)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("InsertDataIntoThuNhap", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThuNhap", mathunhap.MaThuNhap);
                cmd.Parameters.AddWithValue("@NgayGhiNhan", mathunhap.NgayGhiNhan);
                cmd.Parameters.AddWithValue("@SoTien", mathunhap.SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", mathunhap.GhiChu);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                // Handle exception
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool Updatethunhap(DTO_ThuNhap mathunhap)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateDataIntoThuNhap", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThuNhap", mathunhap.MaThuNhap);
                cmd.Parameters.AddWithValue("@NgayGhiNhan", mathunhap.NgayGhiNhan);
                cmd.Parameters.AddWithValue("@SoTien", mathunhap.SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", mathunhap.GhiChu);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                // Handle exception
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool Deletethunhap(int mathunhap)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteDataFromThuNhap", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThuNhap", mathunhap);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                // Handle exception
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable Searchthunhap(int mathunhap)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThuNhap WHERE MaThuNhap LIKE '%' + @MaThuNhap + '%'", _conn);
            da.SelectCommand.Parameters.AddWithValue("@MaThuNhap", mathunhap);
            DataTable dtthunhap = new DataTable();
            da.Fill(dtthunhap);
            return dtthunhap;
        }
    
        public class DTO_ThuNhap
        {
            public int MaThuNhap { get; set; }
            public DateTime NgayGhiNhan { get; set; }
            public int MaNguoiDung { get; set; }
            public decimal SoTien { get; set; }
            public string GhiChu { get; set; }
        }

    }
}
