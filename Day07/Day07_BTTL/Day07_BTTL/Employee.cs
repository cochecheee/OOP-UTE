using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day07_BTTL
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public override string ToString()
        {
            return FirstName+ " " + LastName;  
        }
        public abstract decimal Earnings();
    }
}