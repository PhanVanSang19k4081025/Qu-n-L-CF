using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class DAL_HDBH
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        string[] name = { };
        object[] value = { };

        public DataTable Select_HDBH()
        {
            return thaotac.SQL_Laydulieu("[dbo].[SelectALL_HDBH]");
        }
        public int Insert_HDBH(int Maban, int Tongtien, string TinhTrang, string Ngaylaphd)        
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaBan"; value[0] = Maban;
            name[1] = "@TongTien"; value[1] = Tongtien;
            name[2] = "@TinhTrang"; value[2] = TinhTrang;
            name[3] = "@NgaylapHD "; value[3] = Ngaylaphd;
            return thaotac.SQL_Thuchien("[dbo].[Insert_HDBH]", name, value, 4);
        }
        public int Update_HDBH(int Mahd, string TinhTrang)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHD"; value[0] = Mahd;
            name[1] = "@TinhTrang"; value[1] = TinhTrang;
            return thaotac.SQL_Thuchien("[dbo].[Update_HDBH]", name, value, 2);
        }
        public int UpdateTT_HDBH(int MaHD, int TongTien)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@TongTien"; value[1] = TongTien;
            return thaotac.SQL_Thuchien("[dbo].[UpdateTT_HDBH]", name, value, 2);
        }


    }
}
