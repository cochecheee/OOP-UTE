using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Learn1
{
    public class Employee
    {
        private string firstname;
        private string lastname;
        private Date birthDate;
        private Date hireDate;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public Date BirthDate { get => birthDate; set => birthDate = value; }
        public Date HireDate { get => hireDate; set => hireDate = value; }

        public Employee() { }

        public Employee(string firstname, string lastname, int birthMonth, int birthDay, int birthYear, int hireMonth,
            int hireDay, int hireYear)
        {
            Firstname= firstname;
            Lastname= lastname;
            BirthDate = new Date(birthMonth,birthDay,birthYear);
            HireDate = new Date(hireMonth,hireDay,hireYear);
        }
        public string ToEmployeeString()
        {
            return Lastname + ", " + Firstname + " Hired: " + HireDate.ToDateString() +
                " BirthDay: " + BirthDate.ToDateString();
        }
    }
}