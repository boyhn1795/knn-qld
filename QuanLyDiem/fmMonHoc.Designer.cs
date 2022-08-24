
namespace QuanLyDiem
{
    partial class fmMonHoc
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
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_mk = new System.Windows.Forms.ComboBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.txt_gv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_tm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giảng Viên";
            this.columnHeader5.Width = 157;
            // 
            // cb_mk
            // 
            this.cb_mk.FormattingEnabled = true;
            this.cb_mk.Location = new System.Drawing.Point(140, 64);
            this.cb_mk.Margin = new System.Windows.Forms.Padding(2);
            this.cb_mk.Name = "cb_mk";
            this.cb_mk.Size = new System.Drawing.Size(174, 21);
            this.cb_mk.TabIndex = 3;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(370, 104);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(70, 19);
            this.bt_sua.TabIndex = 2;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(370, 63);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(70, 19);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Location = new System.Drawing.Point(370, 18);
            this.bt_capnhat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(70, 19);
            this.bt_capnhat.TabIndex = 2;
            this.bt_capnhat.Text = "Cập Nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // txt_gv
            // 
            this.txt_gv.Location = new System.Drawing.Point(140, 110);
            this.txt_gv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_gv.Name = "txt_gv";
            this.txt_gv.Size = new System.Drawing.Size(174, 20);
            this.txt_gv.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giảng Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Khoa:";
            // 
            // txt_mp
            // 
            this.txt_mp.Location = new System.Drawing.Point(140, 87);
            this.txt_mp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.Size = new System.Drawing.Size(174, 20);
            this.txt_mp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Học Phần:";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Khoa";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Môn";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Môn";
            this.columnHeader1.Width = 76;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 177);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Học Phần";
            this.columnHeader4.Width = 117;
            // 
            // txt_tm
            // 
            this.txt_tm.Location = new System.Drawing.Point(140, 41);
            this.txt_tm.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tm.Name = "txt_tm";
            this.txt_tm.Size = new System.Drawing.Size(174, 20);
            this.txt_tm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Môn:";
            // 
            // txt_mam
            // 
            this.txt_mam.Location = new System.Drawing.Point(140, 19);
            this.txt_mam.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mam.Name = "txt_mam";
            this.txt_mam.Size = new System.Drawing.Size(174, 20);
            this.txt_mam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Môn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(570, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Môn Học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_mk);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_capnhat);
            this.groupBox1.Controls.Add(this.txt_gv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_tm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(570, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Môn Học";
            // 
            // fmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmMonHoc";
            this.Text = "fmMonHoc";
            this.Load += new System.EventHandler(this.fmMonHoc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cb_mk;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.TextBox txt_gv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_tm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}