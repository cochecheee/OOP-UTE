using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Combo2 : IBox
    {
        new public void P()
        {
            Console.WriteLine("Trien khai IBox trong Combo2");
        }
    }

}