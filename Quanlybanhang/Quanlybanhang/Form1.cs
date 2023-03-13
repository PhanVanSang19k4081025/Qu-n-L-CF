using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using BLL_QLBH;
namespace Quanlybanhang
{
    public partial class Form1 : Form
    {
        public static DataTable donghoadon;
        public static DataTable hoadon;     
        public Form1()
        {
            InitializeComponent();
        }
       public static Sudungdichvu sddv = new Sudungdichvu();
       public static Chitiethoadon CTHD = new Chitiethoadon();
       public static DoanhThu dt = new DoanhThu();
       public static Ban_BLL ban = new Ban_BLL();
       public static Mathang_BLL MH = new Mathang_BLL();
       public static CTHD_BLL cthd = new CTHD_BLL();
       public static BLL_HDBH HDBH = new BLL_HDBH();
       public void Form1_Load(object sender, EventArgs e)
        {
            pntHome.Controls.Clear();
            pntHome.Controls.Add(sddv);
            pntHome.Show();
            sddv.cbLoaimon.SelectedIndex = 0;
            pntHoadon.Controls.Clear();
            pntHoadon.Controls.Add(CTHD);
            pntHoadon.Show();
            pntDoanhThu.Controls.Clear();
            pntDoanhThu.Controls.Add(dt);
            pntDoanhThu.Show();
        }             
    }
}
