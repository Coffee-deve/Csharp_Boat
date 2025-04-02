using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class FuelNuclear : Fuel
    {
        //protected new double density = 19050000; //  19050000 kg3/dm3
        private string Nuclear = "Nuclear";
        private double total_cost = 0; 
        protected double maxcapacity = 0.1; // max capacity = max volume
        protected new double price = 100000000000;

        public override double VisitPort()
        {
            return total_cost;
        }

        public override string Type
        {
            get { return Nuclear; }
            

        }
        public override string Name
        {
            get { return Nuclear; }
            set { }
        }
        public override string GetType_()
        {
            return Nuclear;
        }
        void SeeType()
        {
            Console.WriteLine(Nuclear);
        }
    }
}
