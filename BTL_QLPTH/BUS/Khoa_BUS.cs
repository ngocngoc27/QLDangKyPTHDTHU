using BTL_QLPTH.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.BUS
{
    class Khoa_BUS
    {
        Khoa_DAL khoa = new Khoa_DAL();
        public DataTable GetList()
        {
            return khoa.loadKhoa();
        }
        public DataTable TimKiem(string _timkiem)
        {
            return khoa.Search(_timkiem);
        }
    }
}
