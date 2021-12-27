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
    class LopHP_BUS
    {
        LopHP_DAL hp = new LopHP_DAL();
        public DataTable GetList()
        {
            return hp.loadLopHP();
        }
        public int Them(LopHP_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaHP))
                return 0;
            if (!hp.Insert(x))
                return -1;
            return 1;
        }
        public bool Sua(LopHP_DTO x)
        {
            if (string.IsNullOrEmpty(x.MaHP))
                return false;
            hp.Update(x);
            return true;
        }
        public void Xoa(string ma)
        {
            hp.Delete(ma);
        }
        public DataTable TimKiem(string _timkiem)
        {
            return hp.Search(_timkiem);
        }
    }
}
