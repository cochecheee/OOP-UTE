using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay03_BT02
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Dong cua Main()");
            B.LopCuaB.Display();
        }
    }

    namespace B
    {
        public class LopCuaB
        {
            public static void Display()
            {
                Console.WriteLine("Dong cua B");
                Console.ReadLine();
            }
        }
    }
}
