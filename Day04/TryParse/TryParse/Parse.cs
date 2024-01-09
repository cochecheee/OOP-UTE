using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    public class Parse_T
    {
        public Parse_T() { }
        public void Parse_Test()
        {
            Console.WriteLine("Enter the day...");
            var day = Console.ReadLine();

            Console.WriteLine("Enter the month...");
            var month = Console.ReadLine();

            Console.WriteLine("Enter the year...");
            var year = Console.ReadLine();

            DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            Console.WriteLine("\n" + date.DayOfWeek);
        }

        public void dateTime()
        {
            var day = DateTime.Now.DayOfWeek.ToString();

            switch(day)
            {
                case "Saturday":
                    Console.WriteLine("Yellow");
                    break;
                case "Sunday":
                    Console.WriteLine("Green");
                    break;
                case "Monday":
                    Console.WriteLine("Blue");
                    break;
                case "Tuesday":
                    Console.WriteLine("Grey");
                    break;
                case "Wednesday":
                    Console.WriteLine("Red");
                    break;
                case "Thursday":
                    Console.WriteLine("Orange");
                                        break;
                case "Friday":
                    Console.WriteLine("White");
                                        break;
            }
        }
    }
}
