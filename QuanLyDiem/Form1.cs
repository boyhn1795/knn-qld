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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QLDEntities db = new QLDEntities();
        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDiem a = new fmDiem();
            a.ShowDialog();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmMonHoc a = new fmMonHoc();
            a.ShowDialog();
        }
    }
}
