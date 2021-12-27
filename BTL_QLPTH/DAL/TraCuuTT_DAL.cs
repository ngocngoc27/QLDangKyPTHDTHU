using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class TraCuuTT_DAL: DataProvider
    {
        public DataTable loadTTDangKy()
        {
            string sqlString = @"select SoPhieuDK, NgayDangKy, TietBD, SoTiet, MaPhong, LopHP.MaHP, LopHP.TenHP, PhieuDangKy.MaCB, CanBo.HoTen, TinhTrangDK
                                 from (PhieuDangKy join LopHP on PhieuDangKy.ID_HP = LopHP.ID_HP) join CanBo on CanBo.MaCB = PhieuDangKy.MaCB ";
            return GetData(sqlString);
        }
        public DataTable loadTTThongKe()
        {
            string sqlString = @"select SoPhieuTK, NgayLap, MayTinh.MaPhong, PhieuThongKe.MaMT, MayTinh.HieuMay, MayTinh.NhaSX, GhiChu, PhieuThongKe.MaCB, CanBo.HoTen
                                 from (PhieuThongKe join MayTinh on PhieuThongKe.MaMT = MayTinh.MaMT) join CanBo on CanBo.MaCB = PhieuThongKe.MaCB";
            return GetData(sqlString);
        }
        public DataTable Search(string _timkiem, string x)
        {
            string sqlString = string.Format(@"select SoPhieuDK, NgayDangKy, TietBD, SoTiet, MaPhong, LopHP.MaHP, LopHP.TenHP, PhieuDangKy.MaCB, CanBo.HoTen, TinhTrangDK
                                               from (PhieuDangKy join LopHP on PhieuDangKy.ID_HP = LopHP.ID_HP) join CanBo on CanBo.MaCB = PhieuDangKy.MaCB
                                               where {0} like N'%{1}%'", x, _timkiem);
            return GetData(sqlString);
        }
        public DataTable Search2(string _timkiem, string x)
        {
            string sqlString = string.Format(@"select SoPhieuTK, NgayLap, MayTinh.MaPhong, PhieuThongKe.MaMT, MayTinh.HieuMay, MayTinh.NhaSX, GhiChu, PhieuThongKe.MaCB, CanBo.HoTen
                                               from (PhieuThongKe join MayTinh on PhieuThongKe.MaMT = MayTinh.MaMT) join CanBo on CanBo.MaCB = PhieuThongKe.MaCB
                                               where {0} like N'%{1}%'", x, _timkiem);
            return GetData(sqlString);
        }
    }
}
