namespace Lab7
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

      

        private void btAdd_Click(object sender, EventArgs e)
        {
            string ten = txtNa.Text;
            int tuoi = int.Parse(txtAge.Text);
            double luong = double.Parse(txtSalary.Text);
            Person a = new Person(ten, tuoi, luong);
            this.dataGridView1.Rows.Add(new object[] { a.name, a.age, a.salary} );
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtNa.Text = "";
            txtAge.Text = "";
            txtSalary.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; // rowindex là chỉ số các dòng của datagridview
            // Ví dụ khi người dùng click vào dòng đầu tiên thì rowindex = 0, click thứ 2 thì  = 1
            // Datagridbiew cấu tạo là đối tượng
            DataGridViewRow dongchon = dataGridView1.Rows[i];

            txtNa.Text = dongchon.Cells[0].Value.ToString();
            txtAge.Text = dongchon.Cells[1].Value.ToString();
            txtSalary.Text = dongchon.Cells[2].Value.ToString();


        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtSalary.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
        }
    }
}