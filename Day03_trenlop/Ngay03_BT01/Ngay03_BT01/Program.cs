using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ngay03_BT01
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyFloat a = new MyFloat(3.1f);
            MyFloat b = new MyFloat(5.1f);
            MyFloat c = new MyFloat();

            c = a + b;
            c = a - b;

            Console.WriteLine(c.ToString());
        }
    }
}