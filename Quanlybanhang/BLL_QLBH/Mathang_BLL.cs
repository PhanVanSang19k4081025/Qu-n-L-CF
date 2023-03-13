using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH;
using System.Data;
namespace BLL_QLBH
{
    public class Mathang_BLL
    {
        DAL_Mathang MH = new DAL_Mathang();

        public DataTable SelectALL_Mathang()
        {
            return MH.SelectALL_Mathang();
        }
        public DataTable SelectWhere_Mathang(string MaDanhMuc)
        {
            return MH.SelectWhere_Mathang(MaDanhMuc);
        }
    }
}
