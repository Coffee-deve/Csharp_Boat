using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C3
{
    class LifeSupportSystem
    {
       private double weight, volume;
       private List<OxygenBottle> oxygenBottles;
       private FoodContainer foodContainer;
       private Waste waste;
       private List<Human> crew;
       private bool Are_supplies_checked = false;

        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste_, List<Human> crew_)
        { 
            oxygenBottles = bottles;   
            foodContainer = container; 
            waste = waste_;             
            crew = crew_;               
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {// check oxygen and food  
         //take into account the travel time as well as the number of people on board.
         
            if (foodContainer.Weight != 0.0 && oxygenBottles != null && (oxygenBottles.Count() >= ((crew.Count())/ 5)) && travelTime < 1000000000000)
                Are_supplies_checked = true;
            else   Are_supplies_checked = false; 
            return Are_supplies_checked;
        }

        public void Run(double time)
        { // should depend resource consumption on both the travel time and the number of people on board.
            int size_of_crew = crew.Count();
            int size_of_oxygenbottles = oxygenBottles.Count();
            for(int i = 0; i< oxygenBottles.Count(); i++)
            {
                oxygenBottles[i].Weight = oxygenBottles[i].Weight - (time) - (size_of_crew*200);
            }
              
            foodContainer.Volume = (foodContainer.Volume - time - (size_of_crew*20));
            waste.Volume = (waste.Volume + time + ((size_of_crew)*3));

            // decrease oxygen, decrease food, increase waste value
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
        public  double Weight
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
