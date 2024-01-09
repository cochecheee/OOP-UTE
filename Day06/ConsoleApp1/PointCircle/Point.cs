using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Point
    {
        protected int y;
        protected int x;

        public Point() {}

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override string ToString()
        {
            base.ToString();
            return "{" + x + ", " + y + "}";
        }
    }
}