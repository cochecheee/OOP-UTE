using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT04
{
    public class OperatorOvrldDemo
    {
        private int intX;
        private int intY;

        public OperatorOvrldDemo()
        {
            intX = 0;
            intY = 0;
        }
        public OperatorOvrldDemo(int intI, int intJ)
        {
            intX = intI;
            intY = intJ;
        }

        public void ShowXY()
        {
            Console.WriteLine(intX + " " + intY);
        }
        public static OperatorOvrldDemo operator +(OperatorOvrldDemo objCom1, OperatorOvrldDemo objCom2)
        {
            OperatorOvrldDemo objCom = new OperatorOvrldDemo();
            objCom.intX = objCom1.intX + objCom2.intX;
            objCom.intY = objCom1.intY + objCom2.intY;
            return objCom;
        }

    }
}