using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Tristan_Yurgionas
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
            
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;


        }
        public double GetCurrentWeight()
        {
            double CurrentWeight = 0;

            foreach (Passenger item in Occupants)
            {
                CurrentWeight +=  item.GetWeight();
            }
            return CurrentWeight;
        }
        
        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() <= MaxWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
           
        
    }
}
