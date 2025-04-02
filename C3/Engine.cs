using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;
        bool bol = false;
        private double velocity = 1000;
       public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }
        public double GetVelocity(double submarineWeight)
        {
            velocity = velocity - velocity / (submarineWeight / 100);
            // total submarine weight = FuelTank + Waste + OxygenBottle + FoodContainer  
            // velocity = velocity - velocity / (weight/10000);
            return velocity;
        }
        public bool CheckFuelBeforeTravel(double travelTime)
        { 
            if (tank.Weight != 0.0)   
                bol = true;
            else bol = false;

                return bol;  
        }
        public void Travel(double travelTime)
        {

            waste.Volume = waste.Volume + travelTime;
            tank.Volume = tank.Volume - (travelTime*1.5);
           

        }

    }
}
