namespace Lab7
{
    partial class QLTTSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btADD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN\r\n";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(162, 129);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(248, 23);
            this.txtMaSV.TabIndex = 1;
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(480, 129);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(84, 31);
            this.btADD.TabIndex = 2;
            this.btADD.Text = "Thêm";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(162, 158);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(248, 23);
            this.txtHT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(109, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phái";
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(162, 187);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(248, 23);
            this.txtPhai.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(109, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số ĐT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(162, 216);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(248, 23);
            this.txtSDT.TabIndex = 1;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(480, 167);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(84, 31);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Xoá";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(480, 205);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(84, 31);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSV,
            this.clHoTen,
            this.clPhai,
            this.clSDT});
            this.dataGridView1.Location = new System.Drawing.Point(61, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(503, 160);
            this.dataGridView1.TabIndex = 3;
            // 
            // clMaSV
            // 
            this.clMaSV.HeaderText = "Mã SV";
            this.clMaSV.Name = "clMaSV";
            // 
            // clHoTen
            // 
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.Width = 180;
            // 
            // clPhai
            // 
            this.clPhai.HeaderText = "Phái";
            this.clPhai.Name = "clPhai";
            this.clPhai.Width = 60;
            // 
            // clSDT
            // 
            this.clSDT.HeaderText = "Số Điện Thoạt";
            this.clSDT.Name = "clSDT";
            this.clSDT.Width = 120;
            // 
            // QLTTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLTTSV";
            this.Text = "QLTTSV";
            this.Load += new System.EventHandler(this.QLTTSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtMaSV;
        private Button btADD;
        private Label label2;
        private Label label3;
        private TextBox txtHT;
        private Label label4;
        private TextBox txtPhai;
        private Label label5;
        private TextBox txtSDT;
        private Button btDel;
        private Button btExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clMaSV;
        private DataGridViewTextBoxColumn clHoTen;
        private DataGridViewTextBoxColumn clPhai;
        private DataGridViewTextBoxColumn clSDT;
    }
}