using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class MayTinh_DAL: DataProvider
    {
        public DataTable loadMayTinh()
        {
            string sqlString = @"select * from MayTinh";
            return GetData(sqlString);
        }
        public bool Insert(MayTinh_DTO x)
        {
            if (GetData("select * from MayTinh where MaMT = '" + x.MaMT + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into MayTinh values('{0}','{1}',N'{2}',N'{3}','{4}')",
                x.MaMT, x.HieuMay, x.NhaSX, x.TinhTrangMay, x.MaPhong);

            Excute(sql);
            return true;
        }
        public void Update(MayTinh_DTO x)
        {
            string sql = string.Format("update MayTinh set MaMT = '{0}', HieuMay = '{1}', NhaSX = N'{2}', TinhTrangMay = N'{3}', MaPhong = '{4}' where MaMT = '{0}'",
                x.MaMT, x.HieuMay, x.NhaSX, x.TinhTrangMay, x.MaPhong);
            Excute(sql);
        }
        public void Delete(string ma)
        {
            Excute("Delete from MayTinh where MaMT = '" + ma + "'");
        }
        public DataTable Search(string x)
        {
            string sqlString = string.Format("select * from MayTinh where MaMT like N'%{0}%' or MaPhong like N'%{0}%'", x);
            return GetData(sqlString);
        }
    }
}
