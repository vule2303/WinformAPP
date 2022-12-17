using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtCanh1.Text);
            float b = float.Parse(txtCanh2.Text);
            HCN z = new HCN(a,b);
            if (a > 0 && b > 0)
            {
                txtChuVi.Text = z.ChuVi().ToString();
                txtDienTich.Text = z.DienTich().ToString();
            }else
            {
                MessageBox.Show("Hãy nhập a > 0 và b > 0");
            }
        }

        private void txtChuVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCanh1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //
            if (e.KeyChar == '.' && txtCanh1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
        }

        private void txtCanh2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //
            if (e.KeyChar == '.' && txtCanh2.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
