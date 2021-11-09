using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_week11
{
    class Truck : Vehicle
    {
        double loadCapacity;
        int towingCapacity;

        //Constructors
        public Truck(String name, int cylinder, Person owner, double loadCapacity, int towingCapacity) : base(name, cylinder, owner)
        {
            this.loadCapacity = loadCapacity;
            this.towingCapacity = towingCapacity;
        }

        // ToString Method
        public String ToString()
        {
            String truckString = "Truck " + base.ToString() + String.Format(" Load capacity: {0} Towing capacity: {1} ", loadCapacity, towingCapacity);
            return truckString;
        }
    
    }
}

