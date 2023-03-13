using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class Ban_DAL
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        string[] name = { };
        object[] value = { };

        public int Ban_Update(string TrangThai, int Maban)
        {
            name = new string[2];
            value = new object [2];
            name[0] = "@MaBan"; value[0] = Maban;
            name[1] = "@TrangThai"; value[1] = TrangThai;
            return thaotac.SQL_Thuchien("[dbo].[Update_Ban]", name, value, 2);
        }
    }   
}
