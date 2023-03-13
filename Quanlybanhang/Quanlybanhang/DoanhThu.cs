using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Quanlybanhang
{
    public partial class DoanhThu : UserControl
    {
        string caulenhsql = null;
        string chuoiketnoi = @"Data Source=ADMIN\SANG15;Initial Catalog=QuanlyQuanCafe;Integrated Security=True";
        public DataTable datatable;

        SqlConnection cn;
        SqlDataAdapter sql;       
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void butDT_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(chuoiketnoi);
            caulenhsql = "select NgayLapHD ,COUNT(MaHoaDon) as [Tổng số hoá đơn], sum(TongTien) as [Tổng doanh thu] from HOADONBANHANG where NgayLapHD = N'"+dtpDoanhthu.Value.Date.ToShortDateString()+"' group by NgayLapHD ";
            sql = new SqlDataAdapter(caulenhsql, cn);

            datatable = new DataTable();
            sql.Fill(datatable);

            dataGridViewDT.DataSource = datatable;

            cn.Close();
            cn.Dispose();

        }
    }
}
