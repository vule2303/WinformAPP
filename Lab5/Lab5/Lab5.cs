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
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bảngCửuChươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bangcuuchuong a = new Bangcuuchuong();
            a.ShowDialog();
        }

        private void giảiPTBậc1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPT1 a = new GPT1();
            a.ShowDialog();
        }

        private void gảiiPTBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPT2 a = new CPT2();
            a.ShowDialog();
        }

        private void tínhChuViVàDiệnTíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhCVvDT a = new TinhCVvDT();
            a.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
