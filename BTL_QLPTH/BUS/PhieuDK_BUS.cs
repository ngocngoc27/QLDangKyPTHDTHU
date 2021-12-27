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
    class PhieuDK_BUS
    {
        PhieuDK_DAL data = new PhieuDK_DAL();
        public DataTable GetList()
        {
            return data.loadPhieuDK();
        }
        public int Them(PhieuDK_DTO x)
        {
            if (string.IsNullOrEmpty(x.SoPhieuDK))
                return 0;
            if (!data.Insert(x))
                return -1;
            return 1;
        }
        public bool Sua(PhieuDK_DTO x)
        {
            if (string.IsNullOrEmpty(x.SoPhieuDK))
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
