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
    class CanBo_BUS
    {
        CanBo_DAL cb = new CanBo_DAL();
        public DataTable GetList()
        {
            return cb.loadCanBo();
        }
        public int Them(CanBo_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaCB))
                return 0;
            if (!cb.Insert(x))
                return -1;
            return 1;
        }
        public bool Sua(CanBo_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaCB))
                return false;
            cb.Update(x);
            return true;
        }
        public void Xoa(string ma)
        {
            cb.Delete(ma);
        }
        public DataTable TimKiem(string _timkiem)
        {
            return cb.Search(_timkiem);
        }
    }
}
