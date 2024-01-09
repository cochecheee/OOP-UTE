using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneStore
{
    public class StorePhone : Devices
    {
        private String address;
        private int contactNumber;

        public string Address { get => address; set => address = value; }
        public int ContactNumber { get => contactNumber; set => contactNumber = value; }
        public StorePhone(string deviceName, int year, string color, string seriNum, string producer, float price, string address, int contactNumber):base(deviceName,year,color,seriNum,producer,price)
        {
            Address = address;
            ContactNumber = contactNumber;
        }
        public override void UsingGSM()
        {
            Console.WriteLine("Using GSM");
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