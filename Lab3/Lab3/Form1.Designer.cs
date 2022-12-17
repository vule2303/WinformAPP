namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbtTron = new System.Windows.Forms.RadioButton();
            this.rdbtVuong = new System.Windows.Forms.RadioButton();
            this.rdbtCN = new System.Windows.Forms.RadioButton();
            this.rdbtTamG = new System.Windows.Forms.RadioButton();
            this.btStart = new System.Windows.Forms.Button();
            this.btDoAgain = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(216, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI DIỆN TÍCH CÁC HÌNH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(100, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 335);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rdbtTron
            // 
            this.rdbtTron.AutoSize = true;
            this.rdbtTron.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rdbtTron.Checked = true;
            this.rdbtTron.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtTron.Location = new System.Drawing.Point(172, 130);
            this.rdbtTron.Name = "rdbtTron";
            this.rdbtTron.Size = new System.Drawing.Size(101, 25);
            this.rdbtTron.TabIndex = 3;
            this.rdbtTron.TabStop = true;
            this.rdbtTron.Text = "Hình tròn";
            this.rdbtTron.UseVisualStyleBackColor = false;
            this.rdbtTron.CheckedChanged += new System.EventHandler(this.rdbtTron_Click);
            // 
            // rdbtVuong
            // 
            this.rdbtVuong.AutoSize = true;
            this.rdbtVuong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rdbtVuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtVuong.Location = new System.Drawing.Point(172, 185);
            this.rdbtVuong.Name = "rdbtVuong";
            this.rdbtVuong.Size = new System.Drawing.Size(117, 24);
            this.rdbtVuong.TabIndex = 3;
            this.rdbtVuong.Text = "Hình vuông";
            this.rdbtVuong.UseVisualStyleBackColor = false;
            this.rdbtVuong.CheckedChanged += new System.EventHandler(this.rdbtVuong_CheckedChanged);
            // 
            // rdbtCN
            // 
            this.rdbtCN.AutoSize = true;
            this.rdbtCN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rdbtCN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtCN.Location = new System.Drawing.Point(172, 237);
            this.rdbtCN.Name = "rdbtCN";
            this.rdbtCN.Size = new System.Drawing.Size(137, 25);
            this.rdbtCN.TabIndex = 3;
            this.rdbtCN.Text = "Hình chứ nhật";
            this.rdbtCN.UseVisualStyleBackColor = false;
            this.rdbtCN.CheckedChanged += new System.EventHandler(this.rdbtCN_CheckedChanged);
            // 
            // rdbtTamG
            // 
            this.rdbtTamG.AutoSize = true;
            this.rdbtTamG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rdbtTamG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtTamG.Location = new System.Drawing.Point(172, 286);
            this.rdbtTamG.Name = "rdbtTamG";
            this.rdbtTamG.Size = new System.Drawing.Size(135, 25);
            this.rdbtTamG.TabIndex = 3;
            this.rdbtTamG.Text = "Hình tam giác";
            this.rdbtTamG.UseVisualStyleBackColor = false;
            this.rdbtTamG.CheckedChanged += new System.EventHandler(this.rdbtTamG_CheckedChanged);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btStart.ForeColor = System.Drawing.Color.Navy;
            this.btStart.Location = new System.Drawing.Point(376, 130);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(104, 33);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Tính";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btDoAgain
            // 
            this.btDoAgain.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btDoAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDoAgain.ForeColor = System.Drawing.Color.Navy;
            this.btDoAgain.Location = new System.Drawing.Point(376, 205);
            this.btDoAgain.Name = "btDoAgain";
            this.btDoAgain.Size = new System.Drawing.Size(104, 33);
            this.btDoAgain.TabIndex = 4;
            this.btDoAgain.Text = "Làm lại";
            this.btDoAgain.UseVisualStyleBackColor = false;
            this.btDoAgain.Click += new System.EventHandler(this.btDoAgain_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExit.ForeColor = System.Drawing.Color.Navy;
            this.btExit.Location = new System.Drawing.Point(376, 278);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(104, 33);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(645, 155);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(47, 23);
            this.txtA.TabIndex = 5;
        
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(645, 208);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(47, 23);
            this.txtB.TabIndex = 5;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(645, 263);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(47, 23);
            this.txtC.TabIndex = 5;

            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(521, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cạnh A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(521, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cạnh B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(521, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(521, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cạnh C";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(352, 334);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(145, 23);
            this.txtCV.TabIndex = 5;
            this.txtCV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCV_KeyPress);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(352, 372);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(145, 23);
            this.txtS.TabIndex = 5;
            this.txtS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCV_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(257, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chu vi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(257, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Diện tích";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDoAgain);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.rdbtTamG);
            this.Controls.Add(this.rdbtCN);
            this.Controls.Add(this.rdbtVuong);
            this.Controls.Add(this.rdbtTron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab3A Le Duc Tuan Vu ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private RadioButton rdbtTron;
        private RadioButton rdbtVuong;
        private RadioButton rdbtCN;
        private RadioButton rdbtTamG;
        private Button btStart;
        private Button btDoAgain;
        private Button btExit;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCV;
        private TextBox txtS;
        private Label label6;
        private Label label7;
    }
}