using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class DoanThang : HinhHoc
    {
        Point _A;
        Point _B;
        public Point A { get => _A; set => _A = value; }
        public Point B { get => _B; set => _B = value; }

        public override double ChuVi() { return 1; }
        public override double DienTich() { return 1; }
        public override void Ve(Graphics g) {
            g.DrawLine(new Pen(Color.Black, 5), A, B);
        }
    }
}