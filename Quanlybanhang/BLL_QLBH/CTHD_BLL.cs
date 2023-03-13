using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH;
using System.Data;
namespace BLL_QLBH
{
    public class CTHD_BLL
    {
        DAL_CTHD CTHD = new DAL_CTHD();

        public DataTable Select_CTHD()
        {
            return CTHD.Select_CTHD();
        }
        public int Insert_CTHD(int MaHD, string MaMH, int SL)
        {
            return CTHD.Insert_CTHD(MaHD, MaMH, SL);
        }
        public int Delect_CTHD(int MaHD, string MaMH)
        {
            return CTHD.Delect_CTHD(MaHD, MaMH);
        }
    }
}
