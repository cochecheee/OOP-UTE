﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\Lap trinh huong doi tuong - OOP\Day07\day07.txt";
            System.IO.StreamReader sr = new System.IO.StreamReader(file);
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("File ended");
            sr.Close();
        }
    }
}
