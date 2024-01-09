using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT03
{
    public class Complex
    {
        private int intX;
        private int intY;

        public Complex()
        {
        }
        public Complex(int intI, int intJ)
        {
            intX = intI;
            intY = intJ;
        }

        public void showXY()
        {
            Console.WriteLine("X = " + intX + " ; Y = " + intY);
        }

        public static Complex operator -(Complex comC)
        {
            Complex objCom = new Complex();
            objCom.intX = -comC.intX;
            objCom.intY = -comC.intY;
            return objCom;
        }

    }
}