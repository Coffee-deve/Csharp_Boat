using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class FoodContainer : IVisitPort
    {
        protected double maxcapacity_ = 1000;
        private double volume = 100;
        private double weight, price_of_refill;

        public FoodContainer(double maxcapacity)
        {
            maxcapacity_ = maxcapacity;

        }
    
        public double MaxCapacity
        {
            get { return maxcapacity_; }
            set
            { }
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
                weight = value * 20.0; // 
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 20.0; // 
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
