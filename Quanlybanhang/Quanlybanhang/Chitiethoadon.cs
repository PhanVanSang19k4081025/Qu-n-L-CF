using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class Chitiethoadon : UserControl
    {
       
        public Chitiethoadon()
        {
            InitializeComponent();
        }            
        private void Chitiethoadon_Load(object sender, EventArgs e)
        {           
            Form1.sddv.DulieuHD();
            Form1.sddv.DulieuCTHD();           
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHD.Rows[dataGridViewHD.CurrentCell.RowIndex];
                Form1.sddv.IDHOADON= int.Parse(row.Cells[0].Value.ToString());
                Form1.sddv.Soban = int.Parse(row.Cells[1].Value.ToString());
            }
        }               
    }
}
