
namespace QuanLyDiem
{
    partial class fmDiem
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
            this.date_ngay = new System.Windows.Forms.DateTimePicker();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_tk = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_mmh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_msv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm";
            // 
            // date_ngay
            // 
            this.date_ngay.Enabled = false;
            this.date_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngay.Location = new System.Drawing.Point(129, 88);
            this.date_ngay.Name = "date_ngay";
            this.date_ngay.Size = new System.Drawing.Size(174, 20);
            this.date_ngay.TabIndex = 18;
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(343, 107);
            this.bt_in.Margin = new System.Windows.Forms.Padding(2);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(73, 19);
            this.bt_in.TabIndex = 17;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // bt_tk
            // 
            this.bt_tk.Location = new System.Drawing.Point(343, 84);
            this.bt_tk.Margin = new System.Windows.Forms.Padding(2);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(73, 19);
            this.bt_tk.TabIndex = 17;
            this.bt_tk.Text = "Tìm Kiếm";
            this.bt_tk.UseVisualStyleBackColor = true;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(343, 63);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(73, 19);
            this.bt_sua.TabIndex = 13;
            this.bt_sua.Text = "Sửa Điểm";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(343, 40);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(73, 19);
            this.bt_xoa.TabIndex = 14;
            this.bt_xoa.Text = "Xoá Điểm";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Location = new System.Drawing.Point(343, 16);
            this.bt_capnhat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(73, 19);
            this.bt_capnhat.TabIndex = 15;
            this.bt_capnhat.Text = "Cập Nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Sinh Viên:";
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(129, 113);
            this.txt_diem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(174, 20);
            this.txt_diem.TabIndex = 11;
            this.txt_diem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diem_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Sinh:";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Sinh Viên";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Môn Học";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sinh Viên";
            this.columnHeader1.Width = 97;
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
            this.listView1.Location = new System.Drawing.Point(2, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(432, 136);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(437, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // txt_ten
            // 
            this.txt_ten.Enabled = false;
            this.txt_ten.Location = new System.Drawing.Point(129, 63);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(174, 20);
            this.txt_ten.TabIndex = 11;
            // 
            // txt_mmh
            // 
            this.txt_mmh.Location = new System.Drawing.Point(129, 41);
            this.txt_mmh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mmh.Name = "txt_mmh";
            this.txt_mmh.Size = new System.Drawing.Size(174, 20);
            this.txt_mmh.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên MH:";
            // 
            // txt_msv
            // 
            this.txt_msv.Location = new System.Drawing.Point(129, 17);
            this.txt_msv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_msv.Name = "txt_msv";
            this.txt_msv.Size = new System.Drawing.Size(174, 20);
            this.txt_msv.TabIndex = 12;
            this.txt_msv.TextChanged += new System.EventHandler(this.txt_msv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã SV:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_ngay);
            this.groupBox1.Controls.Add(this.bt_in);
            this.groupBox1.Controls.Add(this.bt_tk);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_capnhat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_diem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_mmh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_msv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(437, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // fmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmDiem";
            this.Text = "fmDiem";
            this.Load += new System.EventHandler(this.fmDiem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker date_ngay;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_mmh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_msv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}