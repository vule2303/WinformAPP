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
    public partial class TinhCVvDT : Form
    {
        public TinhCVvDT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSolve_Click(object sender, EventArgs e)
        {
            int chon = 0;
            if (rdbtTron.Checked == true)
                chon = 0;
            if (rdbtVuong.Checked == true)
                chon = 1;
            if (rdbtCN.Checked == true)
                chon = 2;
            if (rdbtTG.Checked == true)
                chon = 3;
            switch (chon)
            {
                case 0:
                    {
                        if (txtCanh1.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập đủ dữ liệu");
                        }else
                        {
                            double r = double.Parse(txtCanh1.Text);
                            HinhTron a = new HinhTron(r);
                            this.txtChuvi.Text = a.LayChuVi().ToString();
                            this.txtDienTich.Text = a.LayDienTich().ToString();
                            MessageBox.Show(a.Xuat(), "Thông báo");
                        }
                        
                    }
                    break;
                case 1:
                    {
                        if (txtCanh1.Text == string.Empty )
                        {
                            MessageBox.Show("Hãy nhập đủ dữ liệu");
                        }else
                        {
                            double canh = double.Parse(txtCanh1.Text);
                            HinhVuong v = new HinhVuong(canh);
                            this.txtChuvi.Text = v.LayChuVi().ToString();
                            this.txtDienTich.Text = v.LayDienTich().ToString();
                            MessageBox.Show(v.Xuat(), "Thông báo");
                        }
                       
                    }
                    break;
                case 2:
                    {
                        if (txtCanh1.Text == string.Empty || txtCanh2.Text == string.Empty )
                        {
                            MessageBox.Show("Hãy nhập đủ dữ liệu");
                        }
                        else
                        {
                            double chieudai = double.Parse(txtCanh1.Text);
                            double chieurong = double.Parse(txtCanh2.Text);
                            HinhCN cn = new HinhCN(chieudai, chieurong);
                            this.txtChuvi.Text = cn.LayChuVi().ToString();
                            this.txtDienTich.Text = cn.LayDienTich().ToString();
                            MessageBox.Show(cn.Xuat(), "Thông báo");
                        }
                       

                    }
                    break;
                case 3:
                    {
                        if (txtCanh1.Text == string.Empty || txtCanh2.Text == string.Empty || txtCanh3.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập đủ dữ liệu");
                        }
                        else
                        {
                            double c1 = double.Parse(txtCanh1.Text);
                            double c2 = double.Parse(txtCanh2.Text);
                            double c3 = double.Parse(txtCanh3.Text);
                            HinhTG tg = new HinhTG(c1, c2, c3);
                            this.txtChuvi.Text = tg.LayChuVi().ToString();
                            this.txtDienTich.Text = tg.LayDienTich().ToString();
                            MessageBox.Show(tg.Xuat(), "Thông báo");
                        }
                        
                    }
                    break;
            }

            
        }

        private void rdbtTron_CheckedChanged(object sender, EventArgs e)
        {
            this.lbCanh1.Text = "Bán kính";
            this.lbCanh1.Visible = true;
            txtCanh1.Visible = true;
            txtCanh1.Enabled = true;

            this.lbCanh2.Visible = false;
            txtCanh2.Visible = false;
            txtCanh2.Enabled = false;

            this.lbCanh3.Visible= false;
            txtCanh3.Visible = false;
            txtCanh3.Enabled = false;
        }

        private void rdbtVuong_CheckedChanged(object sender, EventArgs e)
        {
            this.lbCanh1.Text = "Độ dài";
            this.lbCanh1.Visible = true;
            txtCanh1.Visible = true;
            txtCanh1.Enabled = true;

            this.lbCanh2.Visible = false;
            txtCanh2.Visible = false;
            txtCanh2.Enabled = false;

            this.lbCanh3.Visible = false;
            txtCanh3.Visible = false;
            txtCanh3.Enabled = false;
        }

        private void rdbtCN_CheckedChanged(object sender, EventArgs e)
        {
            this.lbCanh1.Text = "Cạnh 1";
            this.lbCanh1.Visible = true;
            txtCanh1.Visible = true;
            txtCanh1.Enabled = true;

            this.lbCanh2.Text = "Cạnh 2";
            this.lbCanh2.Visible = true;
            txtCanh2.Visible = true;
            txtCanh2.Enabled = true;

            this.lbCanh3.Visible = false;
            txtCanh3.Visible = false;
            txtCanh3.Enabled = false;
        }

        private void rdbtTG_CheckedChanged(object sender, EventArgs e)
        {
            this.lbCanh1.Text = "Cạnh 1";
            this.lbCanh1.Visible = true;
            txtCanh1.Visible = true;
            txtCanh1.Enabled = true;

            this.lbCanh2.Text = "Cạnh 2";
            this.lbCanh2.Visible = true;
            txtCanh2.Visible = true;
            txtCanh2.Enabled = true;

            this.lbCanh3.Text = "Cạnh 3";
            this.lbCanh3.Visible = true;
            txtCanh3.Visible = true;
            txtCanh3.Enabled = true;
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            txtDienTich.Text = "";
            txtChuvi.Text = "";
            txtCanh1.Text = "";
            txtCanh2.Text = "";
            txtCanh3.Text = "";
        }

        private void txtChuvi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCanh3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //
            if (e.KeyChar == '.' && txtCanh3.Text.IndexOf('.') != -1)
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
