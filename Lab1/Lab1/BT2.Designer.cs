namespace Lab1
{
    partial class BT2
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btSolve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(301, 273);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(82, 20);
            this.txtB.TabIndex = 11;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(301, 217);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(82, 20);
            this.txtA.TabIndex = 12;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btExit.Location = new System.Drawing.Point(514, 323);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 31);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btReturn.Location = new System.Drawing.Point(514, 266);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(87, 31);
            this.btReturn.TabIndex = 9;
            this.btReturn.Text = "Làm Lại";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(259, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "b =";
            // 
            // btSolve
            // 
            this.btSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSolve.Location = new System.Drawing.Point(514, 213);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(87, 31);
            this.btSolve.TabIndex = 10;
            this.btSolve.Text = "Giải";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(259, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "a =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(352, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ax2 + Bx + c = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(311, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập Giá Trị A,B,C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(199, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(259, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "c =";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(301, 323);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(82, 20);
            this.txtC.TabIndex = 11;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // BT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSolve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BT2";
            this.Text = "BT2";
            this.Load += new System.EventHandler(this.BT2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSolve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtC;
    }
}