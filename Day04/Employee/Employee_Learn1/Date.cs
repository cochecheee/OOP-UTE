using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Employee_Learn1
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public Date() { }
        public Date(int month, int day, int year)
        {
            if(month > 0 && month <= 12)
            {
                Month = month;
            }
            else
            {
                Month = 1;
                Console.WriteLine("Thang {0} khong hop le. Tam thoi dua ve 1", month);
            }
            Year = year;
            Day = CheckDay(day);
        }

        private int CheckDay(int testDay)
        {
            int[] dayOfMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //kiem tra trong khoang dung khong
            if(testDay > 0 && testDay <= dayOfMonth[Month]) { 
                return testDay;
            }
            //kiem tra thang 2 va nam nhuan
            if (testDay > 0 && testDay <= dayOfMonth[Month] && ((Year % 400 == 0) || (Year % 4 == 0 && Year % 100 != 0)))
                return 29;

            Console.WriteLine("Ngay {0} khong hip le. Tam thoi dua ve 1.", testDay);

            return 1;
        }
        public string ToDateString()
        {
            return month + "/" + day + "/" + year;
        }
    }
}