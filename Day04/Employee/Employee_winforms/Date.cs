using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_winforms
{
    public class Date
    {
        private int month;
        private int day;
        private int year;

        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }
        public int Year { get => year; set => year = value; }

        public Date(int theMonth, int theDay, int theYear)
        {
            if(theMonth > 0 && theMonth <= 12) { 
            Month = theMonth;}
            else
            {
                Month = 1;
                Console.WriteLine("Thang {0} khong hop le. Tam thoi dua ve 1.", theMonth);
            }
            Year = theYear;
            Day = CheckDay(theDay);
        }

        private int CheckDay(int testDay)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (testDay > 0 && testDay <= daysPerMonth[Month])
                return testDay;

            if (Month == 2 && testDay == 29 &&
                (Year %400 == 0 || (Year%4==0 && Year % 100 != 0)))
                {
                return testDay;
            }

            Console.WriteLine("Ngay {0} khong hip le. Tam thoi dua ve 1.", testDay);

            return 1;
        }
        public string ToDateString()
        {
            return Month + "/" + Day + "/" + Year;
        }
    }
}