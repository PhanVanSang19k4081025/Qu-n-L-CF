using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH;
namespace BLL_QLBH
{
    public class Ban_BLL
    {
        Ban_DAL Ban = new Ban_DAL();

        public int Ban_Update(string TrangThai, int Maban)
        {
            return Ban.Ban_Update(TrangThai, Maban);
        }
    }
}
