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
    public partial class fmMonHoc : Form
    {
        public fmMonHoc()
        {
            InitializeComponent();
        }
        QLDEntities db = new QLDEntities();
        void load_DL()
        {
            listView1.Items.Clear();
            foreach (tblMonHoc mh in db.tblMonHocs.ToList())
            {
                ListViewItem item = new ListViewItem(mh.Mamon);
                item.SubItems.Add(mh.Tenmon);
                item.SubItems.Add(mh.Makhoa);
                item.SubItems.Add(mh.Sohocphan.ToString());
                item.SubItems.Add(mh.Giaovien);
                // Thêm item vào lươi môn học
                listView1.Items.Add(item);
            }
        }
        // trả mã khoa dua vao combo mã khoa
        void duaDL_mk()
        {
            cb_mk.DataSource = db.tblKhoas.ToList();
            cb_mk.ValueMember = "Makhoa";
            cb_mk.DisplayMember = "Makhoa";
            cb_mk.ResetText();
        }
        // viết hàm vô hiệu hoá
        void vohieuhoa(Boolean gt)
        {
            txt_mam.Enabled = gt;
            bt_sua.Enabled = gt;
            bt_xoa.Enabled = gt;
            txt_mp.Enabled = gt;
            txt_tm.Enabled = gt;
            cb_mk.Enabled = gt;
            txt_mp.Enabled = gt;
            txt_gv.Enabled = gt;
        }
        private void fmMonHoc_Load(object sender, EventArgs e)
        {
            load_DL();
            vohieuhoa(false);
            duaDL_mk();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                // lây hàng thư i chọn trên lưới                   
                String Mamon = listView1.SelectedItems[i].SubItems[0].Text.ToString();
                tblMonHoc d = db.tblMonHocs.Where(s => s.Mamon.Contains(Mamon)).FirstOrDefault();
                db.tblMonHocs.Remove(d);
                db.SaveChanges();
            }
            load_DL ();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (bt_capnhat.Text == "Cập Nhật")
            {
                bt_capnhat.Text = "Lưu";
                vohieuhoa(true);
            }
            else
                                // người dùng kích vào nút Lưu
                                // lưu thông tin vào cơ sở dữ liệu
                                // kiểm tra trung mã môn
            {
                try
                {
                    tblMonHoc mh = db.tblMonHocs.Find(txt_mam.Text); //kt trùng mã
                    if (mh != null)
                    {
                        MessageBox.Show("Trùng mã môn học", "Thông Báo");
                        txt_mam.Focus();
                    }
                    tblMonHoc a = new tblMonHoc();
                    a.Mamon = txt_mam.Text;
                    a.Tenmon = txt_tm.Text;
                    a.Makhoa = cb_mk.Text;
                    a.Sohocphan = int.Parse(txt_mp.Text);
                    a.Giaovien = txt_gv.Text;
                    db.tblMonHocs.Add(a);
                    db.SaveChanges();
                    bt_capnhat.Text = "Cập Nhật";
                    load_DL();
                    vohieuhoa(false);
                    xoatext();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (bt_sua.Text == "Sửa")
                {
                    bt_sua.Text = "Lưu";
                    //  txtmamon.Enabled = false;
                }
                else
                {
                    // thực hiện tìm bản ghi cần sửa
                    tblMonHoc mh = db.tblMonHocs.Find(txt_mam.Text);
                    mh.Tenmon = txt_tm.Text;
                    mh.Makhoa = cb_mk.Text;
                    mh.Sohocphan = int.Parse(txt_mp.Text);
                    mh.Giaovien = txt_gv.Text;
                    db.SaveChanges();                   
                    bt_sua.Text = "Sửa";
                    load_DL();
                    xoatext();
                    vohieuhoa(false);
                }
            }
            catch { MessageBox.Show("chưa chọn người để sửa/ lối số hoc phần"); }
            //try
            //{
            //    tblMonHoc mh = new tblMonHoc();
            //    var q = from a in db.tblMonHocs
            //            where a.Mamon == txt_mam.Text
            //            select a;
            //    mh = q.FirstOrDefault();
            //    mh.Tenmon = txt_tm.Text;
            //    mh.Makhoa = cb_mk.Text;
            //    mh.Sohocphan = int.Parse(txt_mp.Text);
            //    mh.Giaovien = txt_gv.Text;
            //    db.SaveChanges();
            //    load_DL();
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi");
            //}
        }
        void xoatext()
        {
            txt_mam.ResetText();
            txt_tm.ResetText();
            cb_mk.ResetText();
            txt_mp.ResetText();
            txt_gv.ResetText();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vohieuhoa(true);
            // đẩy dữ liệu lên các control khi kích chọn
            if (listView1.SelectedItems.Count > 0)
            {
                txt_mam.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                txt_tm.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                cb_mk.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                txt_mp.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
                txt_gv.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
            }
        }
    }
}
