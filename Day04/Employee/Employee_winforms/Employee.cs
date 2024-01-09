using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_winforms
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private Date birthDate;
        private Date hireDate;

        public Employee() { }
        public Employee(string first,string last, int birthMonth, int birthDay, int birthYear,
            int hireMonth, int hireDay, int hireYear)
        {
            FirstName = first;
            LastName = last;    

            BirthDate = new Date(birthMonth, birthDay, birthYear);
            HireDate = new Date(hireMonth, hireDay, hireYear);
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Date BirthDate { get => birthDate; set => birthDate = value; }
        public Date HireDate { get => hireDate; set => hireDate = value; }

        public string ToEmployeeString()
        {
            return LastName + ", " + FirstName + " Hired: " + HireDate.ToDateString() +
                " BirthDay: " + BirthDate.ToDateString();
        }
    }
}