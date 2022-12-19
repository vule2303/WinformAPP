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
            string mssv = txtMaSV.Text;
            string hoten = txtHT.Text;
            string phai = cbtxtPhai.GetItemText(cbtxtPhai.SelectedItem);
            string sdt = txtSDT.Text;
            SinhVien x = new SinhVien(mssv,hoten, sdt, phai);
            dt.Rows.Add(new object[] {x.Masv, x.Hoten, x.Sdt, x.Phai});
            // Khi tạo một datatable thì không thể sử dụng trực tiếp
            //dataGridView1.Rows.Add(new object[] {x.Masv, x.Hoten, x.Sdt, x.Phai});

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
            dt.Columns.Add("Mã SV");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Phái");
            foreach (SinhVien x in lop)
            {
                SinhVien t = new SinhVien(x);
                dt.Rows.Add(new object[] { x.Masv, x.Hoten, x.Sdt, x.Phai });
            }
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Width= 100;
            this.dataGridView1.Columns[1].Width= 250;
            this.dataGridView1.Columns[2].Width= 100;
            this.dataGridView1.Columns[3].Width= 100;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn tất cả cách dòng trong dataGridView
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex; // currentcell là ô đang được chọn và rowindex là trả ra giá trị của dòng
            this.dataGridView1.Rows.RemoveAt(i); // xoá dòng tại vị trí i
            txtHT.Text = txtMaSV.Text = txtSDT.Text = cbtxtPhai.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            DataGridViewRow dongchon = this.dataGridView1.Rows[vt];
            txtMaSV.Text = dongchon.Cells[0].Value.ToString();
            txtHT.Text = dongchon.Cells[1].Value.ToString();
            txtSDT.Text = dongchon.Cells[2].Value.ToString();
            cbtxtPhai.Text = dongchon.Cells[3].Value.ToString();
         

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
