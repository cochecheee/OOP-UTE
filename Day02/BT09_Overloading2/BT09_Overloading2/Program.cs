using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace BT09_Overloading2
{
    public class Program
    {
        public static void Main()
        {
            string sinhVien = "";
            Console.WriteLine("Day la vi du ve overload");
            sinhVien = Console.ReadLine();
            Console.ReadKey();

            if(sinhVien == string.Empty)
            {
                Xuli.Vidu();
            }else
            {
                Xuli.Vidu(sinhVien);
            }
        }
    }
}