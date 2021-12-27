using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class Khoa_DAL : DataProvider
    {
        public DataTable loadKhoa()
        {
            string sqlString = @"select * from Khoa";
            return GetData(sqlString);
        }
        public DataTable Search(string x)
        {
            string sqlString = string.Format("select * from Khoa where MaKhoa like N'%{0}%' or TenKhoa like N'%{0}%'", x);
            return GetData(sqlString);
        }
    }
}
