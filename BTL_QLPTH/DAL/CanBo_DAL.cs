using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class CanBo_DAL : DataProvider
    {
        public DataTable loadCanBo()
        {
            string sqlString = @"select * from CanBo";
            return GetData(sqlString);
        }
        public bool Insert(CanBo_DTO x)
        {
            if (GetData("select * from CanBo where MaCB = '" + x.MaCB + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into CanBo values('{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}','{6}','{7}','{8}')",
                x.MaCB, x.HoTen, x.GioiTinh, x.NamSinh, x.ChucVu, x.DiaChi, x.SDT, x.Email, x.MaKhoa);

            Excute(sql);
            return true;
        }
        public void Update(CanBo_DTO x)
        {
            string sql = string.Format("update CanBo set MaCB = '{0}', HoTen = N'{1}', GioiTinh = N'{2}', NamSinh = N'{3}', ChucVu = N'{4}', DiaChi = N'{5}', SDT = '{6}', Email = '{7}', MaKhoa = '{8}' where MaCB = '{0}'",
                x.MaCB, x.HoTen, x.GioiTinh, x.NamSinh, x.ChucVu, x.DiaChi, x.SDT, x.Email, x.MaKhoa);
            Excute(sql);
        }
        public void Delete(string ma)
        {
            Excute("delete from CanBo where MaCB = '" + ma + "'");
        }
        public DataTable Search(string x)
        {
            string sqlString = string.Format("select * from CanBo where MaCB like N'%{0}%' or HoTen like N'%{0}%' or MaKhoa like '%{0}%'", x);
            return GetData(sqlString);
        } 
    }
}
