using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class fmDiem : Form
    {
        public fmDiem()
        {
            InitializeComponent();
        }
        QLDEntities db = new QLDEntities();
        void load_DL()
        {
            listView1.Items.Clear();
            foreach (tblDiem mh in db.tblDiems.ToList())
            {
                ListViewItem item = new ListViewItem(mh.MaSV);
                item.SubItems.Add(mh.Mamon);
                item.SubItems.Add(mh.tblSinhVien.Hoten);
                item.SubItems.Add(mh.tblSinhVien.Ngaysinh.ToShortDateString());
                item.SubItems.Add(mh.Diem.ToString());
                listView1.Items.Add(item);
            }
        }
        Boolean ktdl()
        {
            if (txt_msv.Text == "" || txt_mmh.Text == "" || txt_diem.Text == "")
                return false;
            else return true;
        }
        Boolean ktdiem()
        {
            Decimal d = decimal.Parse(txt_diem.Text);
            if (d > 10) return false;
            return true;
        }
        private void fmDiem_Load(object sender, EventArgs e)
        {
            load_DL();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (ktdl() == false) MessageBox.Show("Chưa Nhập Đủ Dữ Liệu");
            else if (ktdiem() == false)
            {
                MessageBox.Show("Nhập Sai Điểm");
                txt_diem.Focus();
            }
            else
            {
                // Kiểm tra trùng mã sv và mã môn học trong bảng điểm
                tblDiem x = db.tblDiems.Where(s => s.MaSV.Contains(txt_msv.Text) && s.Mamon.Contains(txt_mmh.Text)).FirstOrDefault();
                if (x != null)
                {
                    MessageBox.Show("Trùng Mã");
                }
                else
                {

                    // thực hiện thêm  vào bảng điểm
                    tblDiem d = new tblDiem();
                    d.MaSV = txt_msv.Text;
                    d.Mamon = txt_mmh.Text;
                    d.Diem = txt_diem.Text;
                    db.tblDiems.Add(d);
                    db.SaveChanges();
                    load_DL();
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from s in db.tblDiems
                        where s.MaSV == txt_msv.Text && s.Mamon == txt_mmh.Text
                        select s;
                tblDiem d = q.FirstOrDefault();
                d.Diem = txt_diem.Text;
                db.SaveChanges();
                load_DL();

            }
            catch { MessageBox.Show("Chưa Chọn Hàng Để Sửa"); }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // đổ dữ liệu từ phần tử đc chọn listview lên lưới
            if (listView1.SelectedItems.Count > 0)
            {
                txt_msv.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                txt_mmh.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                txt_diem.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            { 
            
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    // lây hàng thư i chọn trên lưới
                    string MaSV = listView1.SelectedItems[i].SubItems[0].Text.ToString();
                    String Mamon = listView1.SelectedItems[i].SubItems[1].Text.ToString();
                    tblDiem d = db.tblDiems.Where(s => s.MaSV.Contains(MaSV) && s.Mamon.Contains(Mamon)).FirstOrDefault();
                    db.tblDiems.Remove(d);
                    db.SaveChanges();
                }
                load_DL();

            }
            catch { MessageBox.Show("Chưa Chọn Phần Tử Được Xóa"); }
        }
        // khi nhập tên vào text thì tên và ngày sinh hiện lên trên txtHoten va txtngaysinh
        private void txt_msv_TextChanged(object sender, EventArgs e)
        {
            tblSinhVien a = db.tblSinhViens.Find(txt_msv.Text);
            if (a != null)
            {
                txt_ten.Text = a.Hoten;
                date_ngay.Text = a.Ngaysinh.ToString();
            }
        }

        private void txt_diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            try
            {
                tblDiem d = db.tblDiems.Where(s => s.MaSV.Contains(txt_msv.Text) && s.Mamon.Contains(txt_mmh.Text)).FirstOrDefault();
                txt_ten.Text = d.tblSinhVien.Hoten;
                date_ngay.Text = d.tblSinhVien.Ngaysinh.ToString();
                txt_diem.Text = d.Diem.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Không tìm thấy!");
            }
            //listView1.Items.Clear();
            //var q = from s in db.tblDiems
            //        where (s.MaSV == txt_msv.Text) && (s.Mamon == txt_mmh.Text)
            //        select s;
            //tblDiem d = q.FirstOrDefault();
            //txt_ten.Text = d.tblSinhVien.Hoten;
            //date_ngay.Text = d.tblSinhVien.Ngaysinh.ToString();
            //txt_diem.Text = d.Diem.ToString();
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            indiem frm = new indiem();
            //this.Close();
            frm.Show();
        }
    }
}
