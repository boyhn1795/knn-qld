
namespace QuanLyDiem
{
    partial class indiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_in = new System.Windows.Forms.Button();
            this.txt_msv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewDiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_in);
            this.groupBox1.Controls.Add(this.txt_msv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhập";
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(279, 14);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(75, 23);
            this.bt_in.TabIndex = 2;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // txt_msv
            // 
            this.txt_msv.Location = new System.Drawing.Point(137, 16);
            this.txt_msv.Name = "txt_msv";
            this.txt_msv.Size = new System.Drawing.Size(114, 20);
            this.txt_msv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã SV:";
            // 
            // viewDiem
            // 
            this.viewDiem.ActiveViewIndex = -1;
            this.viewDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewDiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewDiem.Location = new System.Drawing.Point(12, 82);
            this.viewDiem.Name = "viewDiem";
            this.viewDiem.Size = new System.Drawing.Size(776, 356);
            this.viewDiem.TabIndex = 1;
            // 
            // indiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewDiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "indiem";
            this.Text = "indiem";
            this.Load += new System.EventHandler(this.indiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.TextBox txt_msv;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewDiem;
    }
}