using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day07_BTTL
{
    public class Boss : Employee
    {
        private decimal salary;
        public Boss(string firstNameValue, string lastNameValue, decimal salaryValue):base(firstNameValue,lastNameValue)
        {
            Salary = salaryValue;
        }
        public decimal Salary { get => salary; set => salary = value; }
        public override string ToString()
        {
            return "Boss: " + base.ToString();
        }
        public override decimal Earnings()
        {
            return Salary;
        }
    }
}