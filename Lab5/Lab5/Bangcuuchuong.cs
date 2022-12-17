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
    public partial class Bangcuuchuong : Form
    {
        public Bangcuuchuong()
        {
            InitializeComponent();
        }

        private void Bangcuuchuong_Load(object sender, EventArgs e)
        {
            string kq = "";
            for (int i = 2; i <= 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    kq += i.ToString() + " x " + j.ToString() + " = " + (j * i).ToString() +"\t"+ "\n\r" ;
                }
                kq += "\n";
            }
            txtBCC.Text = kq;
        }
    }
}
