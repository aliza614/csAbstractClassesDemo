using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle: Vehicle
    {
        /* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
           */
        public bool HasSideCart { get; set; } =true;
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving Abstract the Car Now...");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine("The vehicle is a motorcycle");
        }
    }
}
