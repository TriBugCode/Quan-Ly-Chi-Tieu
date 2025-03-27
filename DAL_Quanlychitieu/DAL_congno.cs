using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Quanlychitieu;

namespace DAL_Quanlychitieu
{
    public class DAL_congno
    {
        private SqlConnection _conn;

        public DataTable getKhach()
        {

            /* //Direct sql query
             SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblKhach", _conn);
             DataTable dtKhach = new DataTable();
             da.Fill(dtKhach);
             return dtKhach;
             */
            //Store Procedure
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachKhach";
                cmd.Connection = _conn;
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }

        public bool insertcongno(DTO_congno cn)
        {
            //using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntoCongNoNCC";
                cmd.Parameters.AddWithValue("macongno", cn.MaCongNo);
                cmd.Parameters.AddWithValue("Nhacungcap", cn.NhaCungCap);
                cmd.Parameters.AddWithValue("sotienno", cn.SoTienNo);
                cmd.Parameters.AddWithValue("ngaydenhanthanhtoan", cn.NgayDenHanThanhToan);
                cmd.Parameters.AddWithValue("trangthai", cn.TrangThai)  ;
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public bool UpdateKhach(DTO_congno cn)
        {
            //using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoCongNoNCC";
                cmd.Parameters.AddWithValue("macongno", cn.MaCongNo);cmd.Parameters.AddWithValue("Nhacungcap", cn.NhaCungCap);
                cmd.Parameters.AddWithValue("sotienno", cn.SoTienNo);
                cmd.Parameters.AddWithValue("ngaydenhanthanhtoan", cn.NgayDenHanThanhToan);
                cmd.Parameters.AddWithValue("trangthai", cn.TrangThai);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public bool DeleteKhach(int MaCongNo)
        {
            // using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromtblKhach";
                cmd.Parameters.AddWithValue("macongno", MaCongNo);
                cmd.Connection = _conn;
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public DataTable SearchKhach(int MaCongNo)
        {
            // using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchKhach";
                cmd.Parameters.AddWithValue("macongno", MaCongNo);
                cmd.Connection = _conn;
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }

    }

}
