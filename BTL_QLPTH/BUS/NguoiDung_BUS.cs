using BTL_QLPTH.DAL;
using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.BUS
{
    class NguoiDung_BUS
    {
        NguoiDung_DAL data = new NguoiDung_DAL();
        public bool DangNhap(string tk, string mk)
        {
            if (data.login(tk, mk) == true)
                return true;
            return false;
        }
        public int Them(NguoiDung_DTO x)
        {
            if (string.IsNullOrEmpty(x.TenTaiKhoan))
                return 0;
            if (!data.Insert(x))
                return -1;
            return 1;
        }
    }
}
