using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ngay03_BT01
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
            return value.ToString();
        }
    }
}