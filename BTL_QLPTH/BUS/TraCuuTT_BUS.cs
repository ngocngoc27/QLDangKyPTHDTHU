using BTL_QLPTH.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.BUS
{
    class TraCuuTT_BUS
    {
        TraCuuTT_DAL data = new TraCuuTT_DAL();
        public DataTable GetList()
        {
            return data.loadTTDangKy();
        }
        public DataTable GetList2()
        {
            return data.loadTTThongKe();
        }
        public DataTable TimKiem(string _timkiem, string x)
        {
            return data.Search(_timkiem, x);
        }
        public DataTable TimKiem2(string _timkiem, string x)
        {
            return data.Search2(_timkiem, x);
        }
    }
}
