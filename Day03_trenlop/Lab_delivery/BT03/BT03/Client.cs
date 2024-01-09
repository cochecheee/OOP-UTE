using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT03
{
    public class Client
    {
        public static void Main()
        {
            Complex objComOne = new Complex(10, 20);
            objComOne.showXY();
            Complex objComTwo = new Complex();
            objComTwo.showXY();
            objComTwo = -objComOne;
            objComTwo.showXY();
        }

    }
}