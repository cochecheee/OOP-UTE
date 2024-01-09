using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class PointTest
    {
        static void Main(string[] args)
        {
            Point point = new Point(72, 115);
            Circle2 circle = new Circle2(10, 20, 30);

            string output = "X coordinate is " + point.X + "\n" + "y coordinate is  " + point.Y;

            point.X = 10;
            point.Y = 10;

            output += "\n\nThe new location of point is " + point;
            output += "\n\nThe new location of point is " + circle;

            MessageBox.Show(output, "Demonstrating Class Point");
        }
    }
}