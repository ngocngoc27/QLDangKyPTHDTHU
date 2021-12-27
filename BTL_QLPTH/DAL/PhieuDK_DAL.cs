using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class PhieuDK_DAL : DataProvider
    {
        public DataTable loadPhieuDK()
        {
            string sqlString = @"select * from PhieuDangKy";
            return GetData(sqlString);
        }
        public bool Insert(PhieuDK_DTO x)
        {
            if (GetData("select * from PhieuDangKy where SoPhieuDK = '" + x.SoPhieuDK + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into PhieuDangKy values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',N'{7}')",
                x.SoPhieuDK, x.NgayDangKy, x.TietBD, x.SoTiet, x.MaPhong, x.ID_HP, x.MaCB, x.TinhTrangDK);

            Excute(sql);
            return true;
        }
        public void Update(PhieuDK_DTO x)
        {
            string sql = string.Format("update PhieuDangKy set SoPhieuDK ='{0}', NgayDangKy ='{1}', TietBD ='{2}', SoTiet ='{3}', MaPhong = '{4}', ID_HP = '{5}', MaCB = '{6}', TinhTrangDK = N'{7}' where SoPhieuDK = '{0}'",
                x.SoPhieuDK, x.NgayDangKy, x.TietBD, x.SoTiet, x.MaPhong, x.ID_HP, x.MaCB, x.TinhTrangDK);
            Excute(sql);
        }
        public void Delete(string ma)
        {
            Excute("delete from PhieuDangKy where SoPhieuDK = '" + ma + "'");
        }
        public DataTable Search(string x)
        {
            string sqlString = string.Format("select * from PhieuDangKy where SoPhieuDK like N'%{0}%' or NgayDangKy like N'%{0}%' or MaPhong like N'%{0}%'", x);
            return GetData(sqlString);
        }
    }
}
