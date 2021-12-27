using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class PhieuTK_DAL :DataProvider
    {
        public DataTable loadPhieuTK()
        {
            string sqlString = @"select * from PhieuThongKe";
            return GetData(sqlString);
        }
        public bool Insert(PhieuTK_DTO x)
        {
            if (GetData("select * from PhieuThongKe where SoPhieuTK = '" + x.SoPhieuTK + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into PhieuThongKe values('{0}','{1}',N'{2}','{3}','{4}')",
                x.SoPhieuTK, x.NgayLap, x.GhiChu, x.MaCB, x.MaMT);

            Excute(sql);
            return true;
        }
        public void Update(PhieuTK_DTO x)
        {
            string sql = string.Format("update PhieuThongKe set SoPhieuTK = '{0}', NgayLap = '{1}', GhiChu = N'{2}', MaCB = '{3}', MaMT = '{4}' where SoPhieuTK = '{0}'",
                x.SoPhieuTK, x.NgayLap, x.GhiChu, x.MaCB, x.MaMT);
            Excute(sql);
        }
        public void Delete(string ma)
        {
            Excute("delete from PhieuThongKe where SoPhieuTK = '" + ma + "'");
        }
        public DataTable Search(string x)
        {
            string sqlString = string.Format("select * from PhieuThongKe where SoPhieuTK like N'%{0}%' or MaCB like N'%{0}%' or MaMT like N'%{0}%' or NgayLap like '%{0}%'", x);
            return GetData(sqlString);
        }
    }
}
