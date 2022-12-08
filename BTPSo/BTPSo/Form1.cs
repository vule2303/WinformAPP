namespace BTPSo
{
    public partial class FORMMAIN : Form
    {
        public FORMMAIN()
        {
            InitializeComponent();
        }
        // biến toàn cục
        // BVN 
      
       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            int tu1, tu2, mau1, mau2;
            tu1 = int.Parse(txtTu1.Text);
            tu2 = int.Parse(txtTu2.Text);
            
            mau1 = int.Parse(txtMau1.Text);
            mau2 = int.Parse(txtMau2.Text);
            PS a = new PS(tu1, mau1);
            a.RutGonPhanSo();
            PS b = new PS(tu2, mau2);
            b.RutGonPhanSo();
            PS c = new PS();
          
            string selected = this.cboPhepToan.GetItemText(this.cboPhepToan.SelectedItem);
            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("PS khong hop le hay nhap lai");
            }
            else
            {
                switch (selected)
                {
                    case "+":
                        {
                            c = a + b;
                       
                        }
                        break;
                    case "-":
                        {
                            c = a - b;
                        }
                        break;
                    case "*":
                        {
                            c = a * b;
                        }
                        break;
                    case "/":
                        {
                            c = a / b;
                        }
                        break;

                }
                /*c.RutGonPhanSo();*/
                txtTuKQ.Text = c.TuSo.ToString();
                txtMauKQ.Text = c.MauSo.ToString();
                
            }




        }
    }
}