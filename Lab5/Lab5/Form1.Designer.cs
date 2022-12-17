namespace Lab5
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
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.btAccess = new System.Windows.Forms.Button();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtAccess
            // 
            this.txtAccess.Location = new System.Drawing.Point(158, 18);
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(147, 23);
            this.txtAccess.TabIndex = 1;
            this.txtAccess.TextChanged += new System.EventHandler(this.txtAccess_TextChanged);
            // 
            // btAccess
            // 
            this.btAccess.Location = new System.Drawing.Point(360, 17);
            this.btAccess.Name = "btAccess";
            this.btAccess.Size = new System.Drawing.Size(75, 23);
            this.btAccess.TabIndex = 2;
            this.btAccess.Text = "Đăng nhập";
            this.btAccess.UseVisualStyleBackColor = true;
            this.btAccess.Click += new System.EventHandler(this.btAccess_Click);
            // 
            // txtPassw
            // 
            this.txtPassw.Location = new System.Drawing.Point(158, 58);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '*';
            this.txtPassw.Size = new System.Drawing.Size(147, 23);
            this.txtPassw.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(360, 58);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 100);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAccess);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccess);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAccess;
        private Button btAccess;
        private TextBox txtPassw;
        private Label label2;
        private Button btExit;
    }
}