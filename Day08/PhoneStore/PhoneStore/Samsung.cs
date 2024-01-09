using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneStore
{
    public class Samsung : Devices
    {
        public Samsung(string deviceName, int year, string color, string seri, float price) : base(deviceName, year, color, seri, "Samsung", price)
        {
    
        }
        public override void UsingGSM()
        {
            Console.WriteLine("Using GMS");
        }
        public override void Hoatdong()
        {
            UsingGSM();

        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
        public override void input()
        {
            throw new NotImplementedException();
        }
    }
}