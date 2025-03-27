using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quanlychitieu
{
    public class DTO_congno
    {
        public class congno
        {
            public int MaCongNo { get; set; }                  // Mã công nợ
            public string NhaCungCap { get; set; }             // Nhà cung cấp
            public decimal SoTienNo { get; set; }              // Số tiền nợ
            public DateTime NgayDenHanThanhToan { get; set; }  // Ngày đến hạn thanh toán
            public string TrangThai { get; set; }
        }



        public int MaCongNo
        {
            get
            {
                return MaCongNo;
            }
            set
            {
                MaCongNo = value;
            }
        }
        public string NhaCungCap
        {
            get
            {
                return NhaCungCap;
            }
            set
            {
                NhaCungCap = value;
            }
        }
        public decimal SoTienNo
        {
            get
            {
                return SoTienNo;
            }
            set
            {
                SoTienNo = value;
            }
        }
        public DateTime NgayDenHanThanhToan
        {
            get
            {
                return NgayDenHanThanhToan;
            }
            set
            {
                NgayDenHanThanhToan = value;
            }
        }
        public string TrangThai
        {
            get
            {
                return TrangThai;
            }
            set
            {
                TrangThai = value;
            }
        }
        public DTO_congno(int maCongNo, string nhaCungCap, decimal soTienNo, DateTime ngayDenHanThanhToan, string trangThai)
        {
            this.MaCongNo = maCongNo;
            this.NhaCungCap = nhaCungCap;
            this.SoTienNo = soTienNo;
            this.NgayDenHanThanhToan = ngayDenHanThanhToan;
            this.TrangThai = trangThai;
        }

    }
}
