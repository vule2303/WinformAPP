namespace Lab5
{
    partial class Lab5
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
            this.btReturn = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cHƯƠNG1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảiPTBậc1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gảiiPTBậc2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhChuViVàDiệnTíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngCửuChươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btReturn.Location = new System.Drawing.Point(317, 27);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(91, 34);
            this.btReturn.TabIndex = 1;
            this.btReturn.Text = "Quay về";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExit.Location = new System.Drawing.Point(317, 113);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(91, 34);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHƯƠNG1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cHƯƠNG1ToolStripMenuItem
            // 
            this.cHƯƠNG1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giảiPTBậc1ToolStripMenuItem,
            this.gảiiPTBậc2ToolStripMenuItem,
            this.tínhChuViVàDiệnTíchToolStripMenuItem,
            this.bảngCửuChươngToolStripMenuItem});
            this.cHƯƠNG1ToolStripMenuItem.Name = "cHƯƠNG1ToolStripMenuItem";
            this.cHƯƠNG1ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cHƯƠNG1ToolStripMenuItem.Text = "CHƯƠNG 1";
            // 
            // giảiPTBậc1ToolStripMenuItem
            // 
            this.giảiPTBậc1ToolStripMenuItem.Name = "giảiPTBậc1ToolStripMenuItem";
            this.giảiPTBậc1ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.giảiPTBậc1ToolStripMenuItem.Text = "1. Giải PT bậc 1";
            this.giảiPTBậc1ToolStripMenuItem.Click += new System.EventHandler(this.giảiPTBậc1ToolStripMenuItem_Click);
            // 
            // gảiiPTBậc2ToolStripMenuItem
            // 
            this.gảiiPTBậc2ToolStripMenuItem.Name = "gảiiPTBậc2ToolStripMenuItem";
            this.gảiiPTBậc2ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.gảiiPTBậc2ToolStripMenuItem.Text = "2. Gỉai PT bậc 2";
            this.gảiiPTBậc2ToolStripMenuItem.Click += new System.EventHandler(this.gảiiPTBậc2ToolStripMenuItem_Click);
            // 
            // tínhChuViVàDiệnTíchToolStripMenuItem
            // 
            this.tínhChuViVàDiệnTíchToolStripMenuItem.Name = "tínhChuViVàDiệnTíchToolStripMenuItem";
            this.tínhChuViVàDiệnTíchToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.tínhChuViVàDiệnTíchToolStripMenuItem.Text = "3.Tính chu vi và diện tích";
            this.tínhChuViVàDiệnTíchToolStripMenuItem.Click += new System.EventHandler(this.tínhChuViVàDiệnTíchToolStripMenuItem_Click);
            // 
            // bảngCửuChươngToolStripMenuItem
            // 
            this.bảngCửuChươngToolStripMenuItem.Name = "bảngCửuChươngToolStripMenuItem";
            this.bảngCửuChươngToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.bảngCửuChươngToolStripMenuItem.Text = "4. In ra Bảng cửu chương ";
            this.bảngCửuChươngToolStripMenuItem.Click += new System.EventHandler(this.bảngCửuChươngToolStripMenuItem_Click);
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(420, 169);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lab5";
            this.Text = "Lab5 - Vũ - 12104056";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btReturn;
        private Button btExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cHƯƠNG1ToolStripMenuItem;
        private ToolStripMenuItem bảngCửuChươngToolStripMenuItem;
        private ToolStripMenuItem giảiPTBậc1ToolStripMenuItem;
        private ToolStripMenuItem gảiiPTBậc2ToolStripMenuItem;
        private ToolStripMenuItem tínhChuViVàDiệnTíchToolStripMenuItem;
    }
}