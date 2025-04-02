using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Scientist : Human

    {
        private Equipment _equipment;
        private const double Density = 7000.0;
        private double volume, weight;
        private double total_cost = 0;
        public Scientist( Equipment equipment)
        {
            _equipment = equipment;
        }
        public override double VisitPort()
        {
            return total_cost;
        }
        public void Work(double time)
        {
            string data = _equipment.GatherData();
            Console.WriteLine(data);
           
        }
        
        public override double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number) // someObject.Volume = 10.0;
            }
        }
        public override double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number) // someObject.Volume = 10.0;
            }
        }
    }
}
