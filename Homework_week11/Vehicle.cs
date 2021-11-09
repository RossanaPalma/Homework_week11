using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_week11
{
    public enum Manufacturer
    {
        Toyota, Honda, BMW, Ford, Nissan, Hyundai, Jaguar
    }

    class Vehicle : Person
    {
        String name;
        int cylinder;
        Person owner;

        public String Name { get => name; set => name = value; }
        public int Cylinder { get => cylinder; set => cylinder = value; }
        internal Person Owner { get => owner; set => owner = value; }


        //Constructors
        public Vehicle()
        {

        }
        public Vehicle(Person owner) : base(owner)
        {
            name = Enum.GetName(typeof(Manufacturer), 0);
            cylinder = 4;
        }
        public Vehicle(String name, int cylinder, Person owner) : base(owner)
        {
            this.name = name;
            this.cylinder = cylinder;
        }

        //ToString Method
        public String ToString()
        {
            String vehicleString = "Vehicle " + base.ToString() + String.Format("Manufacturer : {0}  Cylinder: {1}", name, cylinder);
            return vehicleString;

        }
    }
}

