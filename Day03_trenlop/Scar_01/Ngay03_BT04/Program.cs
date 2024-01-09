using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ngay03_BT04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Scar_01 toy = new Scar_01("Toyota");
            Scar_01.SoLuongXe();

            Car kia = new Car("KIA");
            kia.SoLuongXe();
        }

    }
}