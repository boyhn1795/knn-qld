
namespace QuanLyDiem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýĐiểmToolStripMenuItem,
            this.quảnLýMônHọcToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            this.quảnLýĐiểmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýĐiểmToolStripMenuItem.Image")));
            this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýĐiểmToolStripMenuItem.Text = "Quản Lý Điểm";
            this.quảnLýĐiểmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            this.quảnLýMônHọcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýMônHọcToolStripMenuItem.Image")));
            this.quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            this.quảnLýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýMônHọcToolStripMenuItem.Text = "Quản Lý Môn Học";
            this.quảnLýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hỗTrợToolStripMenuItem.Image")));
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.hỗTrợToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
    }
}

