using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class OxygenBottle:IVisitPort
    {
        private double volume = 10;
        private double weight = 20;
        protected double maxcapacity_ = 1000;
        protected double price_of_refill;
        public OxygenBottle(double maxCapacity)
        {
            maxcapacity_ = maxCapacity;
        }
       
        public double MaxCapacity
        {
            get { return maxcapacity_; }
            set { }
            
        }
        public double GetMaxCapacity()
        {
            return maxcapacity_;
        }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 2.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 2.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double VisitPort()
        {
            price_of_refill = (maxcapacity_ - Volume) * 100;
            volume = maxcapacity_;
            return price_of_refill;
        }
    }
}
