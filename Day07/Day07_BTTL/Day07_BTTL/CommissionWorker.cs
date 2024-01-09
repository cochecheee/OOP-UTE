using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day07_BTTL
{
    public class CommissionWorker : Employee
    {
        private decimal salary;
        private decimal commission;
        private int quantity;
        public decimal Salary { get => salary; set => salary = value; }
        public decimal Commission { get => commission; set => commission = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public CommissionWorker(string firstNameValue, string lastNameValue,decimal salary,decimal commissionValue, int quantityValue):base(firstNameValue,lastNameValue)
        {
            Salary = salary;
            Commission = commissionValue;
            Quantity = quantityValue;
        }
        public override decimal Earnings()
        {
            return Salary + Commission * Quantity;
        }
        public override string ToString()
        {
            return "Commission Worker: " + base.ToString();
        }
    }
}