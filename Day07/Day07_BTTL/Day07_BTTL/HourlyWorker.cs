using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day07_BTTL
{
    public class HourlyWorker : Employee
    {
        private decimal wage;
        private double hoursWorked;
        public decimal Wage { get => wage; set => wage = value; }
        public double HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        public HourlyWorker(string firstNameValue, string lastNameValue, decimal wageValue, double hoursWorkedValue):base(firstNameValue, lastNameValue)
        {
            Wage = wageValue;
            HoursWorked = hoursWorkedValue;
        }
        public override string ToString()
        {
            return "Hourly Worker: " + base.ToString();
        }
        public override decimal Earnings()
        {
            if(HoursWorked <= 40)
            {
                return Wage * Convert.ToDecimal(HoursWorked);
            }
            else
            {
                decimal basePay = Wage * Convert.ToDecimal(40);
                decimal overtimePay = Wage *
            }
        }
    }
}