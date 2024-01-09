using HinhHoc;

namespace ThuaKe_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tamGiac_btn_Click(object sender, EventArgs e)
        {
            Point dinhA = new Point(10, 10);
            Point dinhB = new Point(50, 50);
            Point dinhC = new Point(50, 20);
            TamGiac tg = new TamGiac(dinhA, dinhB, dinhC);

            Graphics g = pictureBox1.CreateGraphics();
            tg.Ve(g);
        }

        private void doanThang_btn_Click(object sender, EventArgs e)
        {
            DoanThang dt = new DoanThang();
            dt.A = new Point(10, 10);
            dt.B = new Point(10, 50);

            Graphics g = pictureBox1.CreateGraphics();
            dt.Ve(g);
        }

        private void circleShape_btn_Click(object sender, EventArgs e)
        {
            HinhTron ht = new HinhTron();
            ht.Radius = 100;
            ht.Center = new Point(200,100);

            Graphics g = pictureBox1.CreateGraphics();
            ht.Ve(g);
        }

        private void tuGiac_btn_Click(object sender, EventArgs e)
        {
            TuGiac tug = new TuGiac();
            tug.A = new Point(10, 10);
            tug.B = new Point(10, 50);
            tug.C = new Point(100, 50);
            tug.D = new Point(50, 100);

            Graphics g = pictureBox1.CreateGraphics();
            tug.Ve(g);
        }

        private void hinhVuong_btn_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.A = new Point(10, 10);
            hcn.B = new Point(10, 50);
            hcn.C = new Point(50, 10);
            hcn.D = new Point(50, 50);

            Graphics g = pictureBox1.CreateGraphics();
            hcn.Ve(g);
        }
    }
}