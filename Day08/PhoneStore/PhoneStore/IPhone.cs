using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneStore
{
    public class IPhone : Devices, IWifi, I3G, IGRPS
    {
        public IPhone(string deviceName, int year, string color, string seri, float price) : base(deviceName, year, color, seri, "Iphone", price)
        {
            //this.Producer = "LG";
        }
        public void UsingGPRS()
        {

        }
        public void UsingWifi()
        {

        }
        public void Using3G()
        {

        }
        public override void UsingGSM()
        {
            throw new NotImplementedException();
        }
        public override void Hoatdong()
        {
            throw new NotImplementedException();
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