namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAccess_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btAccess_Click(object sender, EventArgs e)
        {
            string name = "admin";
            string pass = "123";
            if (txtAccess.Text == name && txtPassw.Text == pass)
            {
                Lab5 f = new Lab5();
                f.Show();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}