using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using DTO_Quanlychitieu;

namespace DAL_Quanlychitieu
{
    public class DAL_nguoidung
    {
        private SqlConnection _conn; // Khai báo biến kết nối

        

        public DataTable getnguoidung()
        {
            /*
            //Direct sql query
            SqlDataAdapter da = new SqlDataAdapter("SELECT email, tenNv, diachi,vaitro, tinhtrang FROM tblNhanVien", _conn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
            */
            //Store Procedure
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachND]";
                cmd.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

        }
        public bool insertNhanVien(
            DTO_nguoidung nd)
        {
            /*
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO tblNhanVien(email,TenNv, diaChi, vaiTro,tinhtrang) " +
                    "VALUES ('{0}', '{1}','{2}',{3},{4})", nv.EmailNV, nv.TenNhanVien,nv.DiaChi,nv.VaiTro,nv.TinhTrang);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);
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
            return false;*/
            //using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertDataIntoNguoidung]";
                cmd.Parameters.AddWithValue("Hovaten", nd.HoVaTen);
                cmd.Parameters.AddWithValue("manguoidung", nd.MaNguoiDung);
                cmd.Parameters.AddWithValue("taikhoandangnhap", nd.TaiKhoanDangNhap);
                cmd.Parameters.AddWithValue("vaiTro", nd.VaiTro);cmd.Parameters.AddWithValue("matkhau", nd.MatKhau);
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
        public bool Updatenguoidung(DTO_nguoidung nd)
        {
            //using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoNguoiDung";
                cmd.Parameters.AddWithValue("Hovaten", nd.HoVaTen);
                cmd.Parameters.AddWithValue("manguoidung", nd.MaNguoiDung);
                cmd.Parameters.AddWithValue("taikhoandangnhap", nd.TaiKhoanDangNhap);
                cmd.Parameters.AddWithValue("vaiTro", nd.VaiTro);
                cmd.Parameters.AddWithValue("matkhau", nd.MatKhau);
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

        public bool Deletenguoidung(int manguoidung)
        {
            // using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteDataFromNguoiDung]";
                cmd.Parameters.AddWithValue("manguoidung", manguoidung);
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
        public DataTable Searchnguoidung(string taikhoannguoidung)
        {
            // using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchNhanVien]";
                cmd.Parameters.AddWithValue("taikhoandangnhap", taikhoannguoidung);
                cmd.Connection = _conn;
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }
