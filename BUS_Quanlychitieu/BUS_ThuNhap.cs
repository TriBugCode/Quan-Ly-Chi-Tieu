using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BUS_Quanlychitieu.BUS_ThuNhap;

namespace BUS_Quanlychitieu
{
    public class BUS_ThuNhap
    {
        internal class DAL_ThuNhap 
        {
            private DAL_ThuNhap dalthunhap = new DAL_ThuNhap();
            public DataTable getthunhap()
            {
                return dalthunhap.getthunhap();
            }
            public bool Insertthunhap(DTO_thunhap mathunhap)
            {
                return dalthunhap.Insertthunhap(mathunhap);
            }

            public bool Updatethunhap(DTO_thunhap mathunhap)
            {
                return dalthunhap.Updatethunhap(mathunhap);
            }

            public bool Deletethunhap(int mathunhap)
            {
                return dalthunhap.Deletethunhap(mathunhap);
            }

            public DataTable Searchthunhap(int mathunhap)
            {
                return dalthunhap.Searchthunhap(mathunhap);
            }
           public class DTO_thunhap 
            {

            }
        }
    }
}
