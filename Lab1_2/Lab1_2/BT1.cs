using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "" || txtA.Text == "-" || txtA.Text == ".-" || txtA.Text == "." || txtA.Text == "-." || txtB.Text == "-" || txtB.Text == ".-" || txtB.Text == "." || txtB.Text == "-.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
            }
            else
            {
                double a, b;
                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                if (a == 0 && b == 0)
                {
                    MessageBox.Show($"Phương trình có vô số nghiệm");
                }
                else if (a == 0 && b > 0)
                {
                    MessageBox.Show($"Phương trình vô nghiệm");
                }
                else
                {
                    MessageBox.Show($"Phương trình có nghiệm duy nhất x = {-b / a}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
