using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH;
using System.Data;
namespace BLL_QLBH
{
    public class BLL_HDBH
    {
        DAL_HDBH HDBH = new DAL_HDBH();

        public DataTable Select_HDBH()
        {
            return HDBH.Select_HDBH();
        }
        public int Insert_HDBH(int Maban, int Tongtien, string TinhTrang, string Ngaylaphd)
        {
            return HDBH.Insert_HDBH(Maban, Tongtien, TinhTrang, Ngaylaphd);
        }
        public int Update_HDBH(int Mahd, string TinhTrang)
        {
            return HDBH.Update_HDBH(Mahd, TinhTrang);
        }
        public int UpdateTT_HDBH(int MaHD, int TongTien)
        {
            return HDBH.UpdateTT_HDBH(MaHD, TongTien);
        }
    }
}
