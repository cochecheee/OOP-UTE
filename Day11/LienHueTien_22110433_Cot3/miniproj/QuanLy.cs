using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproj
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NV fr1 = new NV();
            fr1.Show();
        }

        private void cửaHàng01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phone fr5 = new Phone();
            fr5.Show();
        }

        private void cửaHàng02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach fr6 = new Sach();
            fr6.Show();
        }

        private void inComeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InCome fr7 = new InCome();
            fr7.Show();
        }

        private void outComeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutCome fr8 = new OutCome();
            fr8.Show();
        }

        private void lợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thang fr9 = new Thang();
            fr9.Show();
        }
    }
}
