using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class TuGiac : HinhHoc
    {
        Point _A;
        Point _B;
        Point _C;
        Point _D;
        public Point A { get => _A; set => _A = value; }
        public Point B { get => _B; set => _B = value; }
        public Point C { get => _C; set => _C = value; }
        public Point D { get => _D; set => _D = value; }
        public override double ChuVi() { return 1; }
        public override double DienTich() { return 1; }
        public override void Ve(Graphics g) 
        {
            g.DrawLine(new Pen(Color.Black,5),A,B);
            g.DrawLine(new Pen(Color.Black, 5), A, C);
            g.DrawLine(new Pen(Color.Black, 5), C, D);
            g.DrawLine(new Pen(Color.Black, 5), D, B);
        }
    }
}