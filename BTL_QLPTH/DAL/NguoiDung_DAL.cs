using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class NguoiDung_DAL:DataProvider
    {
        public bool login(string tk, string mk)
        {
            if (GetData("select * from TaiKhoan where TenTaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'").Rows.Count > 0)
                return true;
            return false;
        }
        public bool Insert(NguoiDung_DTO x)
        {
            if (GetData("select* from TaiKhoan where TenTaiKhoan = '" + x.TenTaiKhoan + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into TaiKhoan values('{0}','{1}','{2}')",
                x.TenTaiKhoan, x.MatKhau, 1);

            Excute(sql);
            return true;
        }
    }
}
