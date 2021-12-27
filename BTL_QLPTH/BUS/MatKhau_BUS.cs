using BTL_QLPTH.DAL;
using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.BUS
{
    class MatKhau_BUS
    {
        MatKhau_DAL data = new MatKhau_DAL();
        public void DoiMatKhau(NguoiDung_DTO x)
        {
            data.ChangePassWord(x);
        }
        public bool CheckExist(string tenDN, string MKC)
        {
            return data.CheckExist(tenDN, MKC);
        }
    }
}
