namespace Lab5
{
    partial class TinhCVvDT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtTG = new System.Windows.Forms.RadioButton();
            this.rdbtCN = new System.Windows.Forms.RadioButton();
            this.rdbtVuong = new System.Windows.Forms.RadioButton();
            this.rdbtTron = new System.Windows.Forms.RadioButton();
            this.btExit = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.btSolve = new System.Windows.Forms.Button();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChuvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanh3 = new System.Windows.Forms.TextBox();
            this.lbCanh3 = new System.Windows.Forms.Label();
            this.txtCanh2 = new System.Windows.Forms.TextBox();
            this.lbCanh2 = new System.Windows.Forms.Label();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.lbCanh1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.rdbtTG);
            this.panel1.Controls.Add(this.rdbtCN);
            this.panel1.Controls.Add(this.rdbtVuong);
            this.panel1.Controls.Add(this.rdbtTron);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btReturn);
            this.panel1.Controls.Add(this.btSolve);
            this.panel1.Controls.Add(this.txtDienTich);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtChuvi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCanh3);
            this.panel1.Controls.Add(this.lbCanh3);
            this.panel1.Controls.Add(this.txtCanh2);
            this.panel1.Controls.Add(this.lbCanh2);
            this.panel1.Controls.Add(this.txtCanh1);
            this.panel1.Controls.Add(this.lbCanh1);
            this.panel1.Location = new System.Drawing.Point(37, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 353);
            this.panel1.TabIndex = 0;
            // 
            // rdbtTG
            // 
            this.rdbtTG.AutoSize = true;
            this.rdbtTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtTG.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdbtTG.Location = new System.Drawing.Point(110, 213);
            this.rdbtTG.Name = "rdbtTG";
            this.rdbtTG.Size = new System.Drawing.Size(119, 20);
            this.rdbtTG.TabIndex = 2;
            this.rdbtTG.TabStop = true;
            this.rdbtTG.Text = "Hình tam giác";
            this.rdbtTG.UseVisualStyleBackColor = true;
            this.rdbtTG.CheckedChanged += new System.EventHandler(this.rdbtTG_CheckedChanged);
            // 
            // rdbtCN
            // 
            this.rdbtCN.AutoSize = true;
            this.rdbtCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtCN.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdbtCN.Location = new System.Drawing.Point(110, 164);
            this.rdbtCN.Name = "rdbtCN";
            this.rdbtCN.Size = new System.Drawing.Size(117, 20);
            this.rdbtCN.TabIndex = 2;
            this.rdbtCN.TabStop = true;
            this.rdbtCN.Text = "Hình chữ nhật";
            this.rdbtCN.UseVisualStyleBackColor = true;
            this.rdbtCN.CheckedChanged += new System.EventHandler(this.rdbtCN_CheckedChanged);
            // 
            // rdbtVuong
            // 
            this.rdbtVuong.AutoSize = true;
            this.rdbtVuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtVuong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdbtVuong.Location = new System.Drawing.Point(110, 115);
            this.rdbtVuong.Name = "rdbtVuong";
            this.rdbtVuong.Size = new System.Drawing.Size(102, 20);
            this.rdbtVuong.TabIndex = 2;
            this.rdbtVuong.TabStop = true;
            this.rdbtVuong.Text = "Hình vuông";
            this.rdbtVuong.UseVisualStyleBackColor = true;
            this.rdbtVuong.CheckedChanged += new System.EventHandler(this.rdbtVuong_CheckedChanged);
            // 
            // rdbtTron
            // 
            this.rdbtTron.AutoSize = true;
            this.rdbtTron.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtTron.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rdbtTron.Location = new System.Drawing.Point(110, 69);
            this.rdbtTron.Name = "rdbtTron";
            this.rdbtTron.Size = new System.Drawing.Size(86, 20);
            this.rdbtTron.TabIndex = 2;
            this.rdbtTron.TabStop = true;
            this.rdbtTron.Text = "Hình tròn";
            this.rdbtTron.UseVisualStyleBackColor = true;
            this.rdbtTron.CheckedChanged += new System.EventHandler(this.rdbtTron_CheckedChanged);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btExit.Location = new System.Drawing.Point(324, 200);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 33);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btReturn.Location = new System.Drawing.Point(324, 135);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(94, 33);
            this.btReturn.TabIndex = 4;
            this.btReturn.Text = "Làm lại";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btSolve
            // 
            this.btSolve.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSolve.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btSolve.Location = new System.Drawing.Point(324, 69);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(94, 33);
            this.btSolve.TabIndex = 4;
            this.btSolve.Text = "Tính";
            this.btSolve.UseVisualStyleBackColor = false;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(324, 302);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(148, 20);
            this.txtDienTich.TabIndex = 3;
            this.txtDienTich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChuvi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Diện tích";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtChuvi
            // 
            this.txtChuvi.Location = new System.Drawing.Point(324, 260);
            this.txtChuvi.Name = "txtChuvi";
            this.txtChuvi.Size = new System.Drawing.Size(148, 20);
            this.txtChuvi.TabIndex = 3;
            this.txtChuvi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChuvi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chu vi";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCanh3
            // 
            this.txtCanh3.Location = new System.Drawing.Point(560, 164);
            this.txtCanh3.Name = "txtCanh3";
            this.txtCanh3.Size = new System.Drawing.Size(73, 20);
            this.txtCanh3.TabIndex = 3;
            this.txtCanh3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanh3_KeyPress);
            // 
            // lbCanh3
            // 
            this.lbCanh3.AutoSize = true;
            this.lbCanh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanh3.Location = new System.Drawing.Point(480, 167);
            this.lbCanh3.Name = "lbCanh3";
            this.lbCanh3.Size = new System.Drawing.Size(54, 16);
            this.lbCanh3.TabIndex = 1;
            this.lbCanh3.Text = "Cạnh 3";
            this.lbCanh3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCanh2
            // 
            this.txtCanh2.Location = new System.Drawing.Point(560, 128);
            this.txtCanh2.Name = "txtCanh2";
            this.txtCanh2.Size = new System.Drawing.Size(73, 20);
            this.txtCanh2.TabIndex = 3;
            this.txtCanh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanh2_KeyPress);
            // 
            // lbCanh2
            // 
            this.lbCanh2.AutoSize = true;
            this.lbCanh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanh2.Location = new System.Drawing.Point(480, 131);
            this.lbCanh2.Name = "lbCanh2";
            this.lbCanh2.Size = new System.Drawing.Size(54, 16);
            this.lbCanh2.TabIndex = 1;
            this.lbCanh2.Text = "Cạnh 2";
            this.lbCanh2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCanh1
            // 
            this.txtCanh1.Location = new System.Drawing.Point(560, 90);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(73, 20);
            this.txtCanh1.TabIndex = 3;
            this.txtCanh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanh1_KeyPress);
            // 
            // lbCanh1
            // 
            this.lbCanh1.AutoSize = true;
            this.lbCanh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanh1.Location = new System.Drawing.Point(480, 93);
            this.lbCanh1.Name = "lbCanh1";
            this.lbCanh1.Size = new System.Drawing.Size(54, 16);
            this.lbCanh1.TabIndex = 1;
            this.lbCanh1.Text = "Cạnh 1";
            this.lbCanh1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(201, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÍNH CHU VI VÀ DIỆN TÍCH CÁC HÌNH";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // BT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "BT2";
            this.Text = "BT2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCanh1;
        private System.Windows.Forms.RadioButton rdbtTron;
        private System.Windows.Forms.TextBox txtCanh1;
        private System.Windows.Forms.Button btSolve;
        private System.Windows.Forms.RadioButton rdbtTG;
        private System.Windows.Forms.RadioButton rdbtCN;
        private System.Windows.Forms.RadioButton rdbtVuong;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.TextBox txtCanh3;
        private System.Windows.Forms.Label lbCanh3;
        private System.Windows.Forms.TextBox txtCanh2;
        private System.Windows.Forms.Label lbCanh2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChuvi;
        private System.Windows.Forms.Label label5;
    }
}