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
    class PhieuTK_BUS
    {
        PhieuTK_DAL data = new PhieuTK_DAL();
        public DataTable GetList()
        {
            return data.loadPhieuTK();
        }
        public int Them(PhieuTK_DTO x)
        {
            if (string.IsNullOrEmpty(x.SoPhieuTK))
                return 0;
            if (!data.Insert(x))
                return -1;
            return 1;
        }
        public bool Sua(PhieuTK_DTO x)
        {
            if (string.IsNullOrEmpty(x.SoPhieuTK))
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
