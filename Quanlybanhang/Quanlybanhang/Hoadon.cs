using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlybanhang
{
    public class Hoadon
    {       
        public int MasoHD;
        public string Mathang;
        public int? Soluong;
        public string Donvitinh;
        public decimal? Dongia;
        public decimal Thanhtien;
        public int tiennuoc;
        public int tongcong;
        public Hoadon(int MSHD, string mh, int? sl, string dvt, decimal? DG,decimal TT, int TN, int TC)
        {         
            this.MasoHD = MSHD;          
            this.Mathang = mh;
            this.Soluong = sl;
            this.Donvitinh = dvt;
            this.Dongia = DG;
            this.Thanhtien = TT;
            this.tiennuoc = TN;
            this.tongcong = TC;
        }
    
    }
}
