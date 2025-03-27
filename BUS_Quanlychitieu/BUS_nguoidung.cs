using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Quanlychitieu
{
    internal class BUS_nguoidung
    {
        public class DTO_nguoidung 
        { }
        public class DAL_nguoidung
        {
            DAL_nguoidung dalnguoidung = new DAL_nguoidung();
            public bool nguoidungDangNhap(DTO_nguoidung nd)
            {
                return dalnguoidung.nguoidungDangNhap(nd);
            }
            public DataTable getnguoidung()
            {
                return dalnguoidung.getnguoidung();
            }
            public bool insertnguoidung(DTO_nguoidung nd)
            {
                return dalnguoidung.insertnguoidung(nd);
            }
            public bool UpdateNhanVien(DTO_nguoidung Nv)
            {
                return dalnguoidung.UpdateNhanVien(Nv);
            }
            public bool Deletenguoidung(int manguoidung)
            {
                return dalnguoidung.Deletenguoidung(manguoidung);
            }
            public DataTable Searchnguoidung(int manguoidung)
            {
                return dalnguoidung.Searchnguoidung(manguoidung);
            }
            /*public bool NhanVienDangNhap(string email, string matKhau)
            {
                return dalNhanVien.NhanVienDangNhap(email, matKhau);
            }*/


            //tra ve vai tro nhan vien dua vao email dang nhap
            public DataTable VaiTronguoidung(int manguoidung)
            {
                return dalnguoidung.VaiTronguoidung(manguoidung);
            }
            public bool UpdateMatKhau(string email, string matKhauCu, string matKhauMoi)
            {
                return dalnguoidung.UpdateMatKhau(email, matKhauCu, matKhauMoi);
            }
            public bool nguoidungQuenMatKhau(string email)
            {
                return dalnguoidung.nguoidungQuenMatKhau(email);
            }
            public bool TaoMatKhau(string email, string matKhauMoi)
            {
                return dalnguoidung.TaoMatKhau(email, matKhauMoi);
            }
            public string encryption(string password)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] encrypt;
                UTF8Encoding encode = new UTF8Encoding();
                //encrypt the given password string into Encrypted data  
                encrypt = md5.ComputeHash(encode.GetBytes(password));
                StringBuilder encryptdata = new StringBuilder();
                //Create a new string by using the encrypted data  
                for (int i = 0; i < encrypt.Length; i++)
                {
                    encryptdata.Append(encrypt[i].ToString());
                }
                return encryptdata.ToString();
            }

        }
    }
}
