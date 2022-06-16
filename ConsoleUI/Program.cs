using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             DONE*/

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            DONE*/

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car c = new Car() { Year = "2022", Make = "Honda", Model="Accord", HasTrunk = true };
            Motorcycle m = new Motorcycle() { Year = "1900", Make = "DNE", Model = "DNE", HasSideCart = false };
            Vehicle v1=new Car() { Year="1999", Make="Chevy", Model="Astro", HasTrunk=true};
            Vehicle v2=new Motorcycle() { Year="2021", Make="Kawasaki", Model="Ninja", HasSideCart=true};

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(c);
            vehicles.Add(m);
            vehicles.Add(v1);
            vehicles.Add(v2);
            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Year);
                Console.WriteLine(v.Make);
                Console.WriteLine(v.Model);
                if (v.GetType().Name=="Motorcycle")
                    Console.WriteLine(((Motorcycle)v).HasSideCart);
                if (v.GetType().Name=="Car")
                    Console.WriteLine(((Car)v).HasTrunk);
                Console.WriteLine("------------");
                
            }
            // Call each of the drive methods for one car and one motorcycle
            c.DriveVirtual();
            c.DriveAbstract();
            m.DriveVirtual();
            m.DriveAbstract();



            #endregion
        }
    }
}
