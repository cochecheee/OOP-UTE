using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT01
{
    public class Employee
    {
        private string name;
        private int age;

        // Default Constructor
        public Employee()
        {
            name = "Mark";
            age = 25;
        }
        // Parameterized Constructor
        public Employee(string varName, int varAge)
        {
            name = varName;
            age = varAge;
        }
        public void ShowData()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Age = " + age);
        }


    }
}