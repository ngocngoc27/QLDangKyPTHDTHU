using BTL_QLPTH.DAL;
using BTL_QLPTH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLPTH.BUS
{
    class PhongTH_BUS
    {
        PhongTH_DAL data = new PhongTH_DAL();
        public DataTable GetList()
        {
            return data.loadPhongTH();
        }
        public int Them(PhongTH_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaPhong))
                return 0;
            if (!data.Insert(x))
                return -1;
            return 1;
        }
        public bool Sua(PhongTH_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaPhong))
                return false;
            data.Update(x);
            return true;
        }
        public void Xoa(string ma)
        {
            data.Delete(ma);
        }
        public DataTable TimKiem(string _timkiem)
        {
            return data.Search(_timkiem);
        }
    }
}
