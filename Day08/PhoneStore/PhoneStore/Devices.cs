using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneStore
{
    public abstract class Devices : IGSM
    {
        private string tenthietbi;

        private int namsanxuat;

        private string mausac;

        private string seriesnum;

        public string Producer { get => producer; set => producer = value; }
        public float Price { get => price; set => price = value; }
        public int Year { get => namsanxuat; set => namsanxuat = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public string Seriesnum { get => seriesnum; set => seriesnum = value; }

        private String producer;
        private float price;
        public Devices(int namsanxuat)
        {
            this.Year = namsanxuat;
        }
        public Devices(string tenthietbi, int namsanxuat, string mausac, string seriesnum, string producer, float price)
        {
            this.Tenthietbi = tenthietbi;
            this.Year = namsanxuat;
            this.Mausac = mausac;
            this.Seriesnum = seriesnum;
            this.producer = producer;
            this.price = price;
        }
        public abstract void input();
        abstract public void UsingGSM();
        public abstract void Display();
        public abstract void Hoatdong();
    }
} 