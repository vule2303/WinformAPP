using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class GPB2 : Form
    {
        public GPB2()
        {
            InitializeComponent();
        }

        private void btSolve_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "" || txtA.Text == "-" || txtA.Text == ".-" || txtA.Text == "." || txtA.Text == "-." || txtB.Text == "-" || txtB.Text == ".-" || txtB.Text == "." || txtB.Text == "-.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
            }
            else
            {
                double a, b, c, x1, x2, delta;
                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                c = double.Parse(txtC.Text);
                if (a == 0)
                {
                    MessageBox.Show($"Phương trình có nghiệm duy nhất x = {x1 = -c / b}");
                }
                else
                {
                    delta = Math.Pow(b, 2) - 4 * a * c;
                    if (delta < 0)
                        MessageBox.Show("Phương trình vô nghiệm");
                    else if (delta == 0)
                    {
                        x1 = -b / 2 * a;
                        MessageBox.Show($"Phương trình có nghiệm kép \n x1 = x2 = {x1}");
                    }

                    else
                    {
                        x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                        x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                        MessageBox.Show($"Phương trình có 2 nghiệm phân biệt \n x1 = {x1} \n x2 = {x2}");
                    }

                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
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
