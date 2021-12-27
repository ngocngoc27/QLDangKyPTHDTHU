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
    class MayTinh_BUS
    {
        MayTinh_DAL data = new MayTinh_DAL();
        public DataTable GetList()
        {
            return data.loadMayTinh();
        }
        public int Them(MayTinh_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaMT))
                return 0;
            if (!data.Insert(x))
                return -1;
            return 1;
        }
        public bool Sua(MayTinh_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaMT))
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
