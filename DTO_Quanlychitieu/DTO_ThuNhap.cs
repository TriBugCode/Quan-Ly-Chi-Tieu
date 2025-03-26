using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quanlychitieu
{
    public class DTO_ThuNhap
    {
             /*
            private int mathunhap;
            private  DateTime ngayghinhan;
            private int manguoidung;
            private decimal sotien;
            private string ghiChu;
            */
            public int mathunhap
            {
                get
                {
                    return mathunhap;
                }
                set
                {
                mathunhap = value;
                }
            }
            public DateTime NgayGhiNhan
        {
                get
                {
                    return NgayGhiNhan;
                }
                set
                {
                NgayGhiNhan = value;
                }
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
            public decimal SoTien
        {
                get
                {
                    return SoTien;
                }
                set
                {
                SoTien = value;
                }
            }
            public string GhiChu
        {
                get
                {
                    return GhiChu;
                }
                set
                {
                GhiChu = value;
                }
            }
            
            

        public class ThuNhap
        {
            public int MaThuNhap { get; set; }
            public DateTime NgayGhiNhan { get; set; }
            public int MaNguoiDung { get; set; }
            public decimal SoTien { get; set; }
            public string GhiChu { get; set; }
        }


        public DTO_ThuNhap(int mathunhap, DateTime NgayGhiNhan, int MaNguoiDung, decimal SoTien, string GhiChu)
            {
                this.mathunhap = mathunhap;
                this.NgayGhiNhan = NgayGhiNhan;
                this.MaNguoiDung = MaNguoiDung;
                this.SoTien = SoTien;
                this.GhiChu = GhiChu;
                
            }
           
        }
    
}
