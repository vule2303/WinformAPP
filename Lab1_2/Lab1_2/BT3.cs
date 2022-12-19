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
    public partial class BT3 : Form
    {
        public BT3()
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
                int a, b;
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                
                
                    MessageBox.Show($"UCLN là {USCLN(a,b).ToString()}\n BCNN là : {BSCNN(a,b).ToString()}");
                
            }
        }
        static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        /**
         * Tim boi so chung nho nhat (BSCNN)
         */
        static int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
