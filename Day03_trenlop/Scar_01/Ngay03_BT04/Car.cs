using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ngay03_BT04
{
    public class Car
    {
        private int SoXe = 6;
        private string TenXe;

        public Car(string T)
        {
            TenXe = T;
            Console.WriteLine("Xe {0} day!", TenXe);
            SoXe++;
        }

        public Car()
        {
            Console.WriteLine("Su dung xe...");
            SoXe = 0;
        }

        public void SoLuongXe()
        {
            Console.WriteLine("Dang dung ", SoXe);
        }
    }
}