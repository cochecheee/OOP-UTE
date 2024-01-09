using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ngay03_BT04
{
    public class Scar_01
    {
        private static int SoXe = 6;
        private string TenXe;

        public Scar_01(string T)
        {
            TenXe = T;
            Console.WriteLine("Xe {0} day!", TenXe);
            SoXe++;
        }
        public Scar_01()
        {
            Console.WriteLine("Su dung ce...");
            SoXe = 0;
        }

        public static void SoLuongXe()
        {
            Console.WriteLine("Dang dung {0}", SoXe);
        }
    }
}