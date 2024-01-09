using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HinhHoc
{
    public class TamGiac : HinhHoc
    {
        private Point _A, _B, _C;

        public Point C
        {
            get { return _C; }
            set { _C = value; }
        }
        public Point A { get => _A; set => _A = value; }
        public Point B { get => _B; set => _B = value; }
        public Point Tam
        {
            get { return new Point((A.X + B.X + C.X) / 3,(A.Y + B.Y + C.Y) / 3); }
        }
        public TamGiac() { }
        public TamGiac(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override void Ve(Graphics g)
        {
            Console.WriteLine("Tam Giac: ......");
            //Ve canh AB
            g.DrawLine(new Pen(Color.Red, 5), A, B);
            //Ve canh BC
            g.DrawLine(new Pen(Color.Red, 5), B, C);
            //Ve canh AC
            g.DrawLine(new Pen(Color.Red, 5), A, C);
            //new Pen

        }

        public override double ChuVi()
        {
            double a, b, c;
            a = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            c = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            b = a = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));

            return a + b + c;

        }
        public override double DienTich()
        {
            double a, b, c;
            a = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            c = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
            b = a = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
    }
}