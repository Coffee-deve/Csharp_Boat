using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class FuelTank:IVisitPort
    {
        protected Double volume, weight, total_cost;
        protected Double diesel_price = 100;
        protected Double nuclear_price = 0.1;
        public Double maxCapacity = 1000;

        public Double MaxCapacity
        {
            get { return maxCapacity; }
            set { maxCapacity = value; }
 
        }

        private Fuel _fuel;
        public FuelTank(Double maxcapacity, Fuel fuel)
        {
         
            MaxCapacity = maxcapacity;
            _fuel = fuel;
           
        }
        
        public String GetFuelType()
        {
            return _fuel.GetType_();
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number) // someObject.Volume = 10.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number) // someObject.Volume = 10.0;
            }
        }
        public Double VisitPort()  // In the FuelTank class for the VisitPort method, refueling should take into account how much 
        {                                //fuel is in stock(analogously for the OxygenBottle and FoodContainer classes), the type of                     
            volume = MaxCapacity;        //fuel(diesel/nuclear) and the associated price differences
                                         // current fuel
           string type = _fuel.GetType_();
            if (type == "Nuclear")
            {
               
                total_cost = MaxCapacity * nuclear_price;
                return total_cost;
            }
            else if(type == "Diesel")
            {
                total_cost = MaxCapacity * diesel_price;
                return total_cost;
            }

            //    Console.WriteLine(_fuel.Price); // 0
            //Console.WriteLine(_fuel.Volume); //0
            //    Console.WriteLine(MaxCapacity); // 50
            //    Console.WriteLine(total_cost);  //0
            
            return total_cost;
            // current fuel type
            // price different for nuclear/ diesel
            // total_ cost = type_of_fuel * how much is needed
        }
    }
}
