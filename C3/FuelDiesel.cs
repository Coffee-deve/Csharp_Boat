using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class FuelDiesel : Fuel
   
    {
        // protected new double density = 0.845; // 0,82–0,845 kg3/dm3 
        private string Diesel = "Diesel";
        private double total_cost = 0;
        protected double maxcapacity = 1000;
        protected new double price = 10000;

        public override double VisitPort() {
            return total_cost;
        }

        public override string Type
        {
            get { return Diesel; }
          
        }
        
        public override string Name
        {
            get { return Diesel; }
            set {}
        }
        public override string GetType_()
        {
            return Diesel;
        }
        void see_type()
        {
            Console.WriteLine(Diesel);
        }



    }
} 