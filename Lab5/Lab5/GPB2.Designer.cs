namespace Lab5
{
    partial class GPB2
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
            this.btExit = new System.Windows.Forms.Button();
            this.btSolve = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(294, 113);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(83, 33);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSolve
            // 
            this.btSolve.Location = new System.Drawing.Point(294, 61);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(83, 33);
            this.btSolve.TabIndex = 8;
            this.btSolve.Text = "Giải PT";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(76, 91);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(160, 23);
            this.txtB.TabIndex = 5;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "B =";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(76, 51);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(160, 23);
            this.txtA.TabIndex = 6;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "C =";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(76, 130);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(160, 23);
            this.txtC.TabIndex = 5;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // GPB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(397, 206);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSolve);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "GPB2";
            this.Text = "GPB2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btExit;
        private Button btSolve;
        private TextBox txtB;
        private Label label2;
        private TextBox txtA;
        private Label label1;
        private Label label3;
        private TextBox txtC;
    }
}