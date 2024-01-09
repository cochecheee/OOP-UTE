using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    public class CompositionTest
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Bob", "Jones", 2, 2, 1989, 3, 12, 2016);

            MessageBox.Show(e.ToEmployeeString(), "Testing Class Employee");
        }
    }
}