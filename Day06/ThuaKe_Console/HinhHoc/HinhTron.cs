using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class HinhTron : HinhHoc
    {
        private Point _Center;
        private int radius;
        public Point Center { get => _Center; set => _Center = value; }
        public int Radius { get => radius; set => radius = value; }

        public override double ChuVi() { return 1; }
        public override double DienTich() { return 1; }
        public override void Ve(Graphics g) {

            int centerX = Center.X;
            int centerY = Center.Y;

            for (int angle = 0; angle < 360; angle++)
            {
                double radians = angle * Math.PI / 180;
                int x = (int)(centerX + Radius * Math.Cos(radians));
                int y = (int)(centerY + Radius * Math.Sin(radians));
                g.DrawLine(new Pen(Color.Black,5), centerX, centerY, x, y);
            }
        }
    }
}