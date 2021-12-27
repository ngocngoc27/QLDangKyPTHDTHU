using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class MatKhau_DAL: DataProvider
    {
        public void ChangePassWord(NguoiDung_DTO _tv)
        {
            string sql = string.Format("update TaiKhoan set MatKhau = '{0}' where TenTaiKhoan = '{1}'", _tv.MatKhau, _tv.TenTaiKhoan);
            Excute(sql);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            string sql = string.Format("select* from TaiKhoan where MatKhau = '{0}' and TenTaiKhoan = '{1}'", _mkc, _tdn);
            if (GetData(sql).Rows.Count > 0)
                return true;
            return false;
        }
    }
}
