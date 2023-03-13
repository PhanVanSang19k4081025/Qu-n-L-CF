using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace Quanlybanhang
{
    public partial class Sudungdichvu : UserControl
    {            
        public static Hoadon[] DSHD = new Hoadon[100];       
        public int HDHT = 0;
        public Button Ban;
        public int IDHOADON;
        public int idHd = 1;
        public bool[] trangthaiban = new bool[100];
        public int Soban;
        public int tongtien = 0;
        string chuoiketnoi = @"Data Source=ADMIN\SANG15;Initial Catalog=QuanlyQuanCafe;Integrated Security=True";
        string caulenhsql = null;
        public string MaMH;
        public DataTable datatable;
        public string TenMH;
        SqlConnection cn;
        SqlDataAdapter sql;
        SqlCommand cmd;
        public Sudungdichvu()
        {
            InitializeComponent();
           
        }
        public int k = 1;           
        private void butThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridViewLH.Rows.Count - 1; i++)
            {

                bool rowAlreadyExist = false;             
                if (dataGridViewLH.Rows[i].Selected == true)
                {                 
                    DataGridViewRow row = dataGridViewLH.Rows[i];
                    if (dataGridViewOrder.Rows.Count != 0)
                    {
                        for (int j = 0; j <= dataGridViewOrder.Rows.Count - 1; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dataGridViewOrder.Rows[j].Cells[0].Value.ToString())
                            {                              
                                rowAlreadyExist = false;                              
                                break;
                            }                           
                        }
                        if (rowAlreadyExist == false)
                            dataGridViewOrder.Rows.Add(row.Cells[0].Value.ToString(), 1, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[2].Value.ToString());                                                                                                                              
                       
                    }
                    else
                    {
                        dataGridViewOrder.Rows.Add(row.Cells[0].Value.ToString(),1, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[2].Value.ToString());                                                                                                                                                                            
                    }                   
                    nudTiennuoc.Value += decimal.Parse(row.Cells[2].Value.ToString());
                    nudTongcong.Value += decimal.Parse(row.Cells[2].Value.ToString());                   
                    Hoadon hd = new Hoadon(int.Parse(IDHOADON.ToString()),row.Cells[0].Value.ToString(), 1, row.Cells[1].Value.ToString(), decimal.Parse(row.Cells[2].Value.ToString()),decimal.Parse(row.Cells[2].Value.ToString()),int.Parse(nudTiennuoc.Value.ToString()),int.Parse(nudTongcong.Value.ToString()));
                    DSHD[HDHT] = hd;
                    HDHT = HDHT + 1;
                    cn = new SqlConnection(chuoiketnoi);
                    caulenhsql = "select MaMH from MATHANG where TenMH = N'" + row.Cells[0].Value.ToString() + "'";
                    cn.Open();
                    cmd = new SqlCommand(caulenhsql, cn);
                    MaMH = cmd.ExecuteScalar().ToString();


                    //cn = new SqlConnection(chuoiketnoi);
                    //caulenhsql = "Insert into CHITIETHOADON values('" + IDHOADON + "',N'"+MaMH +"','1')";
                    //cn.Open();
                    //cmd = new SqlCommand(caulenhsql, cn);
                    //cmd.ExecuteNonQuery(); 
                    Form1.cthd.Insert_CTHD(IDHOADON, MaMH, 1);
                    DulieuCTHD();
                    //cn.Close();
                    //cn.Dispose();
                    if (trangthaiban[Soban] == true)
                    {

                        //cn = new SqlConnection(chuoiketnoi);
                        //caulenhsql = "Update HOADONBANHANG set TongTien = '" + nudTongcong.Value + "'where MaHoaDon = '" + IDHOADON.ToString() + "'";
                        //cn.Open();
                        //cmd = new SqlCommand(caulenhsql, cn);
                        //cmd.ExecuteNonQuery();
                        Form1.HDBH.UpdateTT_HDBH(IDHOADON,int.Parse(nudTongcong.Value.ToString()));
                        DulieuHD();
                        //cn.Close();
                        //cn.Dispose();
                    }                                                                                                       
                }             
            }
        }
        
        private void cbLoaimon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaimon.SelectedIndex == 0)
            {              
                //cn = new SqlConnection(chuoiketnoi);
                //caulenhsql = "select TenMH as[Tên Mặt hàng] , DVT as [Đơn vị tính] , DonGia as [Đơn giá] from  MATHANG ";
                //sql = new SqlDataAdapter(caulenhsql, cn);

                //datatable = new DataTable();
                //sql.Fill(datatable);

                dataGridViewLH.DataSource = Form1.MH.SelectALL_Mathang();

                //cn.Close();
                //cn.Dispose();
            }
            else if (cbLoaimon.SelectedIndex == 1)
            {
                //cn = new SqlConnection(chuoiketnoi);
                //caulenhsql = "select TenMH as[Tên Mặt hàng] , DVT as [Đơn vị tính] , DonGia as [Đơn giá] from  MATHANG where MaDanhMuc = 'CF'";
                //sql = new SqlDataAdapter(caulenhsql, cn);

                //datatable = new DataTable();
                //sql.Fill(datatable);

                dataGridViewLH.DataSource = Form1.MH.SelectWhere_Mathang("CF");

                //cn.Close();
                //cn.Dispose();
            }
            else if (cbLoaimon.SelectedIndex == 2)
            {
                //cn = new SqlConnection(chuoiketnoi);
                //caulenhsql = "select TenMH as[Tên Mặt hàng] , DVT as [Đơn vị tính] , DonGia as [Đơn giá] from  MATHANG where MaDanhMuc = 'DC'";
                //sql = new SqlDataAdapter(caulenhsql, cn);

                //datatable = new DataTable();
                //sql.Fill(datatable);

                dataGridViewLH.DataSource = Form1.MH.SelectWhere_Mathang("DC");

                //cn.Close();
                //cn.Dispose();
            }
            else if (cbLoaimon.SelectedIndex == 3)
            {
                //cn = new SqlConnection(chuoiketnoi);
                //caulenhsql = "select TenMH as[Tên Mặt hàng] , DVT as [Đơn vị tính] , DonGia as [Đơn giá] from  MATHANG where MaDanhMuc = 'PC'";
                //sql = new SqlDataAdapter(caulenhsql, cn);

                //datatable = new DataTable();
                //sql.Fill(datatable);

                dataGridViewLH.DataSource = Form1.MH.SelectWhere_Mathang("PC");

                //cn.Close();
                //cn.Dispose();
            }
            else if (cbLoaimon.SelectedIndex == 4)
            {
                //cn = new SqlConnection(chuoiketnoi);
                //caulenhsql = "select TenMH as[Tên Mặt hàng] , DVT as [Đơn vị tính] , DonGia as [Đơn giá] from  MATHANG where MaDanhMuc = 'B'";
                //sql = new SqlDataAdapter(caulenhsql, cn);

                //datatable = new DataTable();
                //sql.Fill(datatable);

                dataGridViewLH.DataSource = Form1.MH.SelectWhere_Mathang("B");

                //cn.Close();
                //cn.Dispose();
            }

        }

        private void butGiam_Click(object sender, EventArgs e)
        {
            nudTiennuoc.Value -= decimal.Parse(dataGridViewOrder.CurrentRow.Cells[4].Value.ToString());
            nudTongcong.Value -= decimal.Parse(dataGridViewOrder.CurrentRow.Cells[4].Value.ToString());
            int index = dataGridViewOrder.CurrentCell.RowIndex;
            dataGridViewOrder.Rows.RemoveAt(index);
            for (int i = index; i < HDHT - 1; i++)
            {
                DataRow dhdrow = Form1.donghoadon.Rows[i];
                if (dhdrow["Mã Hoá Đơn"].ToString() == IDHOADON.ToString())
                {
                    DSHD[i] = DSHD[i + 1];
                    DSHD[i + 1].tiennuoc = int.Parse(nudTiennuoc.Value.ToString());
                    DSHD[i + 1].tongcong = int.Parse(nudTongcong.Value.ToString());
                }
            }
            --HDHT;
            MaMathang();
            //cn = new SqlConnection(chuoiketnoi);
            //caulenhsql = "delete from CHITIETHOADON where MaMH = '"+MaMH+"' AND MaHoaDon = "+IDHOADON+"";
            //cn.Open();
            //cmd = new SqlCommand(caulenhsql, cn);
            //cmd.ExecuteNonQuery();
            Form1.cthd.Delect_CTHD(IDHOADON, MaMH);
            DulieuCTHD();
            //cn.Close();
            //cn.Dispose();


            //cn = new SqlConnection(chuoiketnoi);
            //caulenhsql = "Update HOADONBANHANG set TongTien = '" + nudTongcong.Value + "'where MaHoaDon = '" + IDHOADON.ToString() + "'";
            //cn.Open();
            //cmd = new SqlCommand(caulenhsql, cn);
            //cmd.ExecuteNonQuery();
            Form1.HDBH.UpdateTT_HDBH(IDHOADON, int.Parse(nudTongcong.Value.ToString()));
            DulieuHD();
            //cn.Close();
            //cn.Dispose();         
        }
    
        private void resettongtien()
        {
            nudTiennuoc.Value = 0;
            nudTongcong.Value = 0;
        }

        private void butThanhtoan_Click(object sender, EventArgs e)
        {
            //cn = new SqlConnection(chuoiketnoi);
            //caulenhsql = "Update HOADONBANHANG set TinhTrang = 'Đã Thanh Toán' where MaHoaDon = '" + IDHOADON.ToString() + "'";
            //cn.Open();
            //cmd = new SqlCommand(caulenhsql, cn);
            //cmd.ExecuteNonQuery();
            Form1.HDBH.Update_HDBH(IDHOADON, "Đã Thanh Toán");
            DulieuHD();
            //cn.Close();
            //cn.Dispose();
            for (int i = 0; i < Form1.hoadon.Rows.Count; i++)
            {
                DataRow row = Form1.hoadon.Rows[i];
                if (row["Mã Hoá Đơn"].ToString() == IDHOADON.ToString())
                {
                    MessageBox.Show("Bàn : " + row["Mã Bàn"].ToString() + "    Tổng tiền : " + row["Tổng Tiền"]);
                    dataGridViewOrder.Rows.Clear();
                    txtShowban.Text = "";
                    nudTiennuoc.Value = 0;
                    nudTongcong.Value = 0;
                    trangthaiban[Soban] = false;
                }
            }
            for (int i = 0; i <= 18; i++)
            {
                if (trangthaiban[i] == false)
                {
                    Ban.BackColor = Color.White;
                }
            }
            //cn = new SqlConnection(chuoiketnoi);
            //caulenhsql = "Update BAN set TrangThai = N'Không Hoạt Động' where MaBan = '" + Soban.ToString() + "'";
            //cn.Open();
            //cmd = new SqlCommand(caulenhsql, cn);
            //cmd.ExecuteNonQuery();
            //cn.Close();
            //cn.Dispose();
            Form1.ban.Ban_Update("Không Hoạt Động", Soban);
        }

      
        public void DulieuHD()
        {
            //cn = new SqlConnection(chuoiketnoi);
            //caulenhsql = "Select MaHoaDon as [Mã Hoá Đơn], MaBan as [Mã Bàn], TongTien as [Tổng Tiền], TinhTrang as [Tình Trạng], NgayLapHD as [Ngày Lập Hoá Đơn] from  HOADONBANHANG";
            //sql = new SqlDataAdapter(caulenhsql, cn);

            //Form1.hoadon = new DataTable();
            //sql.Fill(Form1.hoadon);

            Form1.CTHD.dataGridViewHD.DataSource = Form1.HDBH.Select_HDBH();

            //cn.Close();
            //cn.Dispose();
            
        }
        public void DulieuCTHD()
        {
            //cn = new SqlConnection(chuoiketnoi);
            //caulenhsql = "Select MaHoaDon as [Mã Hoá Đơn] , MaMH as [Mã Mặt Hàng], SoLuong as [Số Lượng] from  CHITIETHOADON order by MaHoaDon asc";
            //sql = new SqlDataAdapter(caulenhsql, cn);

            //Form1.donghoadon = new DataTable();
            //sql.Fill(Form1.donghoadon);

            Form1.CTHD.dataGridViewCTHD.DataSource = Form1.cthd.Select_CTHD();

            //cn.Close();
            //cn.Dispose();
        }
        public void SoHD()
        {
            cn = new SqlConnection(chuoiketnoi);
            caulenhsql = "select max(MaHoaDon) from HOADONBANHANG";
            cn.Open();
            cmd = new SqlCommand(caulenhsql, cn);
            IDHOADON = int.Parse(cmd.ExecuteScalar().ToString());
        }
        public void MAHD()
        {
            cn = new SqlConnection(chuoiketnoi);
            caulenhsql = "select MaHoaDon from HOADONBANHANG where MaBan = '"+Soban.ToString()+"' and TinhTrang = N'Chưa Thanh Toán'";
            cn.Open();
            cmd = new SqlCommand(caulenhsql, cn);
            IDHOADON = int.Parse(cmd.ExecuteScalar().ToString());
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOrder.Rows[dataGridViewOrder.CurrentCell.RowIndex];
                TenMH = row.Cells[0].Value.ToString();
            }
        }

        private void Ban_Click(object sender, EventArgs e)
        {
            dataGridViewOrder.Rows.Clear();
            Ban = (Button)sender;
            string so = Ban.Text;
            so = so.Remove(0, 4);
            Soban = int.Parse(so);
            if (trangthaiban[Soban] == false)
            {
                if (MessageBox.Show("Bạn có muốn mở bàn này không", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //cn = new SqlConnection(chuoiketnoi);
                    //caulenhsql = "Insert into HOADONBANHANG(MaBan,TongTien,TinhTrang,NgayLapHD) values('" + Soban + "','0',N'Chưa Thanh Toán',N'" + dtpNgaylap.Value.Date.ToShortDateString() + "')";
                    //cn.Open();
                    //cmd = new SqlCommand(caulenhsql, cn);
                    //cmd.ExecuteNonQuery();
                    Form1.HDBH.Insert_HDBH(Soban, 0, "Chưa Thanh Toán", dtpNgaylap.Value.Date.ToShortDateString());
                    DulieuHD();
                    //cn.Close();
                    //cn.Dispose();
                    SoHD();
                    trangthaiban[Soban] = true;
                    txtShowban.Text = "Mã hoá đơn : " + IDHOADON + "   Bàn : " + Soban;
                    resettongtien();
                    Form1.ban.Ban_Update("Đang Hoạt Động", Soban);
                    //cn = new SqlConnection(chuoiketnoi);
                    //caulenhsql = "Update BAN set TrangThai = N'Đang Hoạt Động' where MaBan = '" + Soban.ToString() + "'";
                    //cn.Open();
                    //cmd = new SqlCommand(caulenhsql, cn);
                    //cmd.ExecuteNonQuery();
                    //cn.Close();
                    //cn.Dispose();
                }
            }
            else
            {
                MAHD();             
                DulieuHD();
                txtShowban.Text = "Mã hoá đơn : " + IDHOADON + "   Bàn : " + Soban;
                dataGridViewOrder.Rows.Clear();
                for (int i = 0; i < HDHT; i++)
                {
                    if (DSHD[i].MasoHD == IDHOADON)
                    {
                        dataGridViewOrder.Rows.Add(DSHD[i].Mathang, DSHD[i].Soluong, DSHD[i].Donvitinh, DSHD[i].Dongia, DSHD[i].Thanhtien);
                        resettongtien();
                        nudTiennuoc.Value = DSHD[i].tiennuoc;
                        nudTongcong.Value = DSHD[i].tongcong;
                    }
                }
            }
            for (int i = 0; i <= 18; i++)
            {
                if (trangthaiban[i] == true)
                {
                    Ban.BackColor = Color.Red;
                }
            }

        }

        private void MaMathang()
        {
            cn = new SqlConnection(chuoiketnoi);
            caulenhsql = "select MaMH from MATHANG where TenMH = N'"+TenMH+"'";
            cn.Open();
            cmd = new SqlCommand(caulenhsql, cn);
            MaMH = cmd.ExecuteScalar().ToString();
        }

      
      
       
       
      

       

       
       

      
        
        
        
        
        
 
    }
    
    
}
