namespace Lab3
{
    public partial class Form1 : Form
    {
        double a, b, c, cv, dt;
        public Form1()
        {

            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            double cv = 0; dt = 0;
            int chon = 0;
            if (this.rdbtTron.Checked == true)
                chon = 0;
            if (this.rdbtVuong.Checked == true)
                chon = 1;
            if (this.rdbtCN.Checked == true)
                chon = 2;
            if (this.rdbtTamG.Checked == true)
                chon = 3;
            switch (chon)
            {
                case 0:
                    {
                        if (txtA.Text == "")
                        {
                            MessageBox.Show("Nhập sai vui lòng nhập lại");
                        } else
                        {


                            a = double.Parse(txtA.Text);

                            cv = 2 * a * Math.PI;
                            dt = a * a * Math.PI;
                        }

                    }
                    break;
                case 1:
                    {
                        a = double.Parse(txtA.Text);
                        cv = 4 * a;
                        dt = a * a;
                    }
                    break;
                case 2:
                    {
                        a = double.Parse(txtA.Text);
                        b = double.Parse(txtB.Text);
                        cv = (a + b) / 2;
                        dt = a * b;
                    }
                    break;
                case 3:
                    {
                        a = double.Parse(txtA.Text);
                        b = double.Parse(txtB.Text);
                        c = double.Parse(txtC.Text);
                        HTG z = new HTG(a, b, c);
                        MessageBox.Show(z.KiemTraTG());
                        cv = z.LayChuVi();
                        dt = z.LayDienTich();



                    }
                    break;
            }
            txtCV.Text = cv.ToString();
            txtS.Text = dt.ToString();
        }
        public string _curChoose;
        private void Form1_Load(object sender, EventArgs e)
        {
            
                _curChoose = ((RadioButton)sender).Text;
                disableAndReset();
                switch (_curChoose)
                {
                    case "Hình tròn":
                        lbla.Text = "Bán kính";
                        txtA.Visible = true;
                        break;
                    case "Hình vuông":
                        lbla.Text = "Cạnh";
                        txtA.Visible = true;
                        break;
                    case "Hình chữ nhật":
                        lbla.Text = "Cạnh dài";
                        txtA.Visible = true;
                        lblb.Text = "Cạnh rộng";
                        txtB.Visible = true;
                        break;
                    case "Hình tam giác":
                        lbla.Text = "Cạnh 1";
                        txtA.Visible = true;
                        lblb.Text = "Cạnh 2";
                        txtB.Visible = true;
                        label5.Text = "Cạnh 3";
                        txtC.Visible = true;
                        break;
                    default:
                        MessageBox.Show("What?");
                        break;
                }
                return;
            }
        

        private void rdbtVuong_CheckedChanged(object sender, EventArgs e)
        {

            this.label2.Text = "Bán kính";
            this.label2.Visible = true;
            txtA.Visible = true;
            txtA.Enabled = true;
            this.label3.Visible = false;
            txtB.Visible = false;
            txtB.Enabled = false;
            this.label5.Visible = false;
            txtC.Visible = false;
            txtC.Enabled = false;
        }

        private void rdbtCN_CheckedChanged(object sender, EventArgs e)
        {

            this.label2.Text = "Chiều dài";
            this.label2.Visible = true;
            txtA.Visible = true;
            txtA.Enabled = true;
            this.label3.Text = "Chiều rộng";
            this.label3.Visible = true;
            txtB.Visible = true;
            txtB.Enabled = true;
            this.label5.Visible = false;
            txtC.Visible = false;
            txtC.Enabled = false;
        }

        private void rdbtTamG_CheckedChanged(object sender, EventArgs e)
        {

            this.label2.Visible = true;
            txtA.Visible = true;
            txtA.Enabled = true;
            this.label3.Visible = true;
            this.label2.Text = "Cạnh 1";
            this.label3.Text = "Cạnh 2";
            this.label5.Text = "Cạnh 3";
            txtB.Visible = true;
            txtB.Enabled = true;
            this.label5.Visible = true;
            txtC.Visible = true;
            txtC.Enabled = true;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDoAgain_Click(object sender, EventArgs e)
        {
            txtS.Text = "";
            txtCV.Text = "";
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //
            if (e.KeyChar == '.' && txtA.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
        }
        public bool CountString(string a)
        {
            if (a.IndexOf('.') != -1) 
            return true;

            return false;

        }



            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtC_TextChanged(object sender, EventArgs e)
            {

            }

            private void rdbtTron_Click(object sender, EventArgs e)
            {
                this.label2.Text = "Bán kính";
                this.label2.Visible = true;
                txtA.Visible = true;
                txtA.Enabled = true;

                this.label5.Visible = false;
                txtC.Visible = false;
                txtC.Enabled = false;
                this.label3.Visible = false;
                txtB.Visible = false;
                txtB.Enabled = false;

            }
        }
    } 