using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class DAL_CTHD
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        string[] name = { };
        object[] value = { };

        public DataTable Select_CTHD()
        {
            return thaotac.SQL_Laydulieu("[dbo].[SelectALL_CTHD]");
        }
        public int Insert_CTHD(int MaHD, string MaMH, int SL)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaHH"; value[1] = MaMH;
            name[2] = "@SL"; value[2] = SL;
            return thaotac.SQL_Thuchien("[dbo].[Insert_CTHD]", name, value, 3);         
        }
        public int Delect_CTHD(int MaHD, string MaMH)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaHH"; value[1] = MaMH;
            return thaotac.SQL_Thuchien("[dbo].[Delete_CTHD]", name, value, 2);
        }

    }
}
