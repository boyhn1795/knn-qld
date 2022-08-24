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
    public partial class indiem : Form
    {
        public indiem()
        {
            InitializeComponent();
        }
        QLDEntities db = new QLDEntities();
        private void bt_in_Click(object sender, EventArgs e)
        {
            var q = from n in db.tblDiems
                    join m in db.tblSinhViens on n.MaSV equals m.MaSV
                    join k in db.tblMonHocs on n.Mamon equals k.Mamon
                    where n.MaSV.Contains(txt_msv.Text)
                    select new
                    {
                        MaSV = n.MaSV,
                        Mamon = n.Mamon,
                        Tenmon = k.Mamon,
                        Hoten = m.Hoten,
                        Ngaysinh = m.Ngaysinh,
                        Diem = n.Diem
                    };
            // tạo 1 report giống như repot mình thiết kế  
            CrystalReport1 rpt = new CrystalReport1();
            // gán dữ liệu cho rpt
            rpt.SetDataSource(q.ToList());
            viewDiem.ReportSource = rpt;
        }

        private void indiem_Load(object sender, EventArgs e)
        {

        }
    }
}
