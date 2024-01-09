using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesWrite
{
    class Program
    {
        static void Main(string[] args)
        {

            //Directory.CreateDirectory(@"C:\files\males");
            string file = @"D:\Lap trinh huong doi tuong - OOP\Day07\day07.txt";
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine("Tien");
            sw.WriteLine("Bui");

            sw.Close();
        }
    }
}
