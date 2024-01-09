using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Circle2 : Point
    {
        private double radius;

        public Circle2(int xValue, int yValue, double radiusValue)
        {
            x = xValue;
            y = yValue;
            radius= radiusValue;
        }
        public double Radius { get => radius; set => radius = value; }

        public double Diameter()
        {
            return Radius * 2;
        }

        public virtual double Circumference()
        {
            return Math.PI * Diameter();
        }

        public virtual double area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            base.ToString();
            return "Center = [" + x + ", " + y + "]" + "; Radius = " + radius;
        }
    }
}