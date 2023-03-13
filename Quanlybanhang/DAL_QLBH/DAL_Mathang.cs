using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class DAL_Mathang
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        string[] name = { };
        object[] value = { };
        public DataTable SelectALL_Mathang()
        {
            return thaotac.SQL_Laydulieu("[dbo].[SelectALL_MatHang]");
        }
        public DataTable SelectWhere_Mathang(string MaDanhMuc)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaDanhmuc"; value[0] = MaDanhMuc;
            return thaotac.SQL_SelectWhere("[dbo].[SelectWhere_MatHang]", name, value, 1);
        }
    }
}
