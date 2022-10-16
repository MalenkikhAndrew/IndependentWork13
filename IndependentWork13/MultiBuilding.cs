using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork13
{
    internal class MultiBuilding : Building
    {
        private int numberOfFloors;
        int NumberOfFloors
        {
            get
            {  
            return numberOfFloors;
            }
            set
            {
                if (value < 0)
                    numberOfFloors = 0;
                else
                    numberOfFloors = value;
            }
        }
        public MultiBuilding(string address, double length, double width, double height, int numberOfFloors)
            : base(address, length, width, height) 
        {
            this.NumberOfFloors = numberOfFloors;
        }
        public string Print() 
        {
            string result=base.Print();
            result += $", Этажность={numberOfFloors}";
            return result;
        }
    }

}
