using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT01
{
    public class Program
    {
        static void Main()
        {
            Employee objEmpOne = new Employee();
            Employee objEmpTwo = new Employee("Allen", 30);
            objEmpOne.ShowData();
            Console.WriteLine();
            objEmpTwo.ShowData();
        }
    }
}