using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocGhiFiletxt
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Ghi File

            System.Console.OutputEncoding = Encoding.UTF8;

            //D:\Lap trinh huong doi tuong - OOP\Day09\BTVN\DocGhiFiletxt\DocGhiFiletxt\TextFile1.txt
            string file = @"D:\Lap trinh huong doi tuong - OOP\Day09\BTVN\DocGhiFiletxt\DocGhiFiletxt\TextFile1.txt";
            //StreamWriter sw = new StreamWriter(file);
            StreamWriter sw = new StreamWriter(File.Open(file, FileMode.OpenOrCreate),Encoding.UTF8,1024);
            sw.WriteLine("Bùi Lê Thủy Tiên");
            sw.WriteLine(22162048);
            //đóng tệp
            sw.Close();

            //Đọc file
            StreamReader sd = new StreamReader(file,Encoding.UTF8);
            Console.WriteLine(sd.ReadToEnd());

        }

    }
}
