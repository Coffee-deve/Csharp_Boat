using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
         abstract class Fuel : ITransportable
    {
        protected double volume, weight, density, max_capacity, price;
        public abstract double VisitPort();
        public abstract string Type { get; }
        abstract public string GetType_();
        public abstract string Name { get; set; }
        public double Price
        {
            get { return price; }
        }
        public double Density
        {
            get => density;
            set => density = value;
        }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / density; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
    }
}
