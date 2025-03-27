using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Quanlychitieu
{
    internal class congno
    {
       public class DAL_congno 
        {
            DAL_congno dalcongno = new DAL_congno();
            public DataTable getKhach()
            {
                return dalcongno.getKhach();
            }
            public bool Insertcongno(DTO_congno khach)
            {
                return dalcongno.Insertcongno(khach);
            }
            public bool Updatecongno(DTO_congno khach)
            {
                return dalcongno.Updatecongno(khach);
            }
            public bool Deletecongno(int MaCongNo)
            {
                return dalcongno.Deletecongno(MaCongNo);
            }
            public DataTable Searchcongno(int MaCongNo)
            {
                return dalcongno.Searchcongno(MaCongNo);
            }
        }
        
        public class DTO_congno 
        { }
    }
}
