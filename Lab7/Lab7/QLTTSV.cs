using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class QLTTSV : Form
    {
        public DataTable dt = new DataTable();
        public QLTTSV()
        {
            InitializeComponent();
        }

        private void btADD_Click(object sender, EventArgs e)
        {

        }

        private void QLTTSV_Load(object sender, EventArgs e)
        {
            SinhVien[] lop =
            {
                new SinhVien ("01","Le Duc Tuan Vu", "0905133340","Nam"),
                new SinhVien ("02","Le Duc Tuan Vu", "0905133340","Nu"),
                new SinhVien ("03","Le Duc Tuan Vu", "0905133340","Nam"),
                new SinhVien ("04","Le Duc Tuan Vu", "0905133340","Nu"),
                new SinhVien ("05","Le Duc Tuan Vu", "0905133340","Nam"),
            };
            foreach (SinhVien x in lop)
            {
                SinhVien t = new SinhVien(x);
                dt.Rows.Add(new object[] { x.Masv, x.Hoten, x.Phai, x.Sdt });
            }
            this.dataGridView1.DataSource = dt;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex; // currentcell là ô đang được chọn và rowindex là trả ra giá trị của dòng
            this.dataGridView1.Rows.RemoveAt(i);
            txtHT.Text = txtMaSV.Text = txtSDT.Text = txtPhai.Text = "";
        }
    }
}
