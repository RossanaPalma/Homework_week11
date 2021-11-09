/// Chapter No. 22 - Homework11
/// File Name: Homework_week11.java
/// @author: Rossana Palma
/// Date:  November 7, 2021
///
/// Problem Statement:  Create a class called Vehicle that has the Manufacturer name (enum), 
/// number of cyclinders in the engine (int), and the owner(Person). Then create a class called 
/// Truck that is derived from Vehicle and has the additional following properties: the load 
/// capacity in tons (double), and towing capacity in pounds (int).  Be sure your class has a 
/// reasonable set of constructors, getters/setters, properties and suitably defined ToString 
/// and Equals methods.  Write a driver program to test all your methods. 
/// 
/// 
/// 
/// 
/// Overall Plan:
/// 1) Finish the definition of the Person class
/// 2) Create a Vehicle class that has int cylinder and Person owner
/// 3) Create a Truck class that is derived from Vehicle and add load 
/// capacity and towing capacity.
/// 4) Create properties and constructors for each class
/// 5) Create ToString and Equals method for each class
/// 6) Test all methods in main driver



using System;

namespace Homework_week11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create objects
            Person p1 = new Person(" Paul ");
            Person p2 = new Person(" Carmela ");
            Person p3 = new Person(" Paul ");

            Console.WriteLine("Person 1: " + p1.ToString());
            Console.WriteLine("Person 2: " + p2.ToString());
            Console.WriteLine("Person 3: " + p3.ToString());

            //Testing Equals Method
            Console.WriteLine("Is p1 equals p2? " + p1.Equals(p2));
            Console.WriteLine("Is p2 equals p3? " + p2.Equals(p3));
            Console.WriteLine("Is p1 equals p3? " + p1.Equals(p3));

            // Testing Vehicle class
            Vehicle v1 = new Vehicle(p1);
            Vehicle v2 = new Vehicle(p2);
            Vehicle v3 = new Vehicle(p3);

            Console.WriteLine("Vehicle v1: " + v1.ToString());
            Console.WriteLine("Vehicle v2: " + v2.ToString());
            Console.WriteLine("Vehicle v3: " + v3.ToString());

            //Testing Truck class
            Truck t1 = new Truck(Enum.GetName(typeof(Manufacturer), 3), 5, p1, 0.5, 1000);
            Console.WriteLine("Person 1: " + t1.ToString());

            Console.ReadLine();

        }
    }
}
