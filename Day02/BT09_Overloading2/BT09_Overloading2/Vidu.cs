using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT09_Overloading2
{
    public class Xuli
    {
        public static void Vidu()
        {
            Console.WriteLine("SV dang hoc OOP");
            Console.ReadKey();
        }

        public static void Vidu(string hoten)
        {
            Console.WriteLine($"Sinh vien {hoten}, dang hoc OOP");
            Console.ReadKey();
        }
    }
}