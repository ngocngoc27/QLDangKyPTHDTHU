using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class PhongTH_DAL:DataProvider
    {
        public DataTable loadPhongTH()
        {
            string sqlString = @"select * from PhongThucHanh";
            return GetData(sqlString);
        }
        public bool Insert(PhongTH_DTO x)
        {
            if (GetData("select * from PhongThucHanh where MaPhong = '" + x.MaPhong + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into PhongThucHanh values('{0}',N'{1}',N'{2}','{3}')",
                x.MaPhong, x.ViTri, x.TinhTrangPhong, x.SoLuongMay);

            Excute(sql);
            return true;
        }
        public void Update(PhongTH_DTO x)
        {
            string sql = string.Format("update PhongThucHanh set MaPhong = '{0}', ViTri = N'{1}', TinhTrangPhong = N'{2}', SoLuongMay = '{3}' where MaPhong = '{0}'",
                x.MaPhong, x.ViTri, x.TinhTrangPhong, x.SoLuongMay);
            Excute(sql);
        }
        public void Delete(string ma)
        {
            Excute("delete from PhongThucHanh where MaPhong = '" + ma + "'");
        }
        public DataTable Search(string x)
        {
            string sqlString = string.Format("select * from PhongThucHanh where MaPhong like N'%{0}%'", x);
            return GetData(sqlString);
        }
    }
}
