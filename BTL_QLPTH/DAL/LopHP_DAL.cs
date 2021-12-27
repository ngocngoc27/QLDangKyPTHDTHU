using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.DAL
{
    class LopHP_DAL : DataProvider
    {
        public DataTable loadLopHP()
        {
            string sqlString = @"select * from LopHP";
            return GetData(sqlString);
        }
        public bool Insert(LopHP_DTO x)
        {
            if (GetData("select * from LopHP where ID_HP = '" + x.ID_HP + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into LopHP values('{0}','{1}',N'{2}','{3}','{4}','{5}')",
               x.ID_HP, x.MaHP, x.TenHP, x.SoTC, x.HocKi, x.NienKhoa);

            Excute(sql);
            return true;
        }
        public void Update(LopHP_DTO x)
        {
            string sql = string.Format("update LopHP set ID_HP = '{0}', MaHP = '{1}', TenHP = N'{2}', SoTC = '{3}', HocKi = '{4}', NienKhoa = '{5}' where ID_HP = '{0}'",
                x.ID_HP, x.MaHP, x.TenHP, x.SoTC, x.HocKi, x.NienKhoa);
            Excute(sql);
        }
        public void Delete(string ma)
        {
            Excute("delete from LopHP where ID_HP = '" + ma + "'");
        }
        public DataTable Search(string x)
        {
            string sqlString = string.Format("select * from LopHP where ID_HP like '%{0}%' or MaHP like '%{0}%' or TenHP like N'%{0}%' or HocKi like '%{0}%' or SoTC like '%{0}%' or NienKhoa like '%{0}%'", x);
            return GetData(sqlString);
        }
    }
}
