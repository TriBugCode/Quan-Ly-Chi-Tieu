using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quanlychitieu
{
    public class DTO_nguoidung
    {
        public class nguoidung
        {
        public string HoVaTen { get; set; }
        public int MaNguoiDung { get; set; }
        public int VaiTro { get; set; }
        public string TaiKhoanDangNhap { get; set; }
        public string MatKhau { get; set; }

        }
       
        public int MaNguoiDung
        {
            get
            {
                return MaNguoiDung;
            }
            set
            {
                MaNguoiDung = value;
            }
        }
        public string HoVaTen
        {
            get
            {
                return HoVaTen;
            }
            set
            {
                HoVaTen = value;
            }
        }
        public int VaiTro
        {
            get
            {
                return VaiTro;
            }
            set
            {
                VaiTro = value;
            }
        }
        public string TaiKhoanDangNhap
        {
            get
            {
                return TaiKhoanDangNhap;
            }
            set
            {
                TaiKhoanDangNhap = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return MatKhau;
            }
            set
            {
                MatKhau = value;
            }
        }


        public DTO_nguoidung(string HoVaTen, int MaNguoiDung, int VaiTro, string TaiKhoanDangNhap, string MatKhau)
        {
            this.HoVaTen = HoVaTen;
            this.MaNguoiDung = MaNguoiDung;
            this.VaiTro = VaiTro;
            this.TaiKhoanDangNhap = TaiKhoanDangNhap;
            this.MatKhau = MatKhau;
        }
        public DTO_nguoidung(string HoVaTen, int MaNguoiDung, int VaiTro, string TaiKhoanDangNhap)
        {
            this.HoVaTen = HoVaTen;
            this.MaNguoiDung = MaNguoiDung;
            this.VaiTro = VaiTro;
            this.TaiKhoanDangNhap = TaiKhoanDangNhap;

        }
        
    }
}
