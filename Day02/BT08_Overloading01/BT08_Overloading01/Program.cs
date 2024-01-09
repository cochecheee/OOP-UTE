using System;

namespace Overloading
{
    public class MyFloat
    {
        private float value;
        public MyFloat()
        {
            value = 0;
        }

        public MyFloat(float newVal)
        {
            value = newVal;
        }

        public static MyFloat operator +(MyFloat a, MyFloat b)
        {
            return new MyFloat(a.value + b.value);
        }

        public static MyFloat operator -(MyFloat a, MyFloat b)
        {
            return new MyFloat(a.value - b.value);
        }

        public override string ToString()
        {
            string s = value.ToString();
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyFloat a = new MyFloat(3.1f);
            MyFloat b = new MyFloat(5.1f);
            MyFloat c = new MyFloat();

            c = a + b;
            c = a - b;

            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}