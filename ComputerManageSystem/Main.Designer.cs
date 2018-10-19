namespace ComputerManageSystem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InfoImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoImportToolStripMenuItem,
            this.InfoSearchToolStripMenuItem,
            this.QuickToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InfoImportToolStripMenuItem
            // 
            this.InfoImportToolStripMenuItem.Name = "InfoImportToolStripMenuItem";
            this.InfoImportToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.InfoImportToolStripMenuItem.Text = "信息录入";
            this.InfoImportToolStripMenuItem.Click += new System.EventHandler(this.InfoImportToolStripMenuItem_Click);
            // 
            // InfoSearchToolStripMenuItem
            // 
            this.InfoSearchToolStripMenuItem.Name = "InfoSearchToolStripMenuItem";
            this.InfoSearchToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.InfoSearchToolStripMenuItem.Text = "信息查询";
            // 
            // QuickToolStripMenuItem
            // 
            this.QuickToolStripMenuItem.Name = "QuickToolStripMenuItem";
            this.QuickToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.QuickToolStripMenuItem.Text = "退出";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 547);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算机配置信息管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InfoImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuickToolStripMenuItem;
    }
}

