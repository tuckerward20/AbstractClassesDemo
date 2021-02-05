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
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var car1 = new Car() { HasTrunk = true, Make = "Toyota", Model = "4Runner", NumberOfCupHolders = 12, Year = 2015};
            var motorcycle1 = new Motorcycle() { HasKickStand = true, Make = "Toyota", Model = "4Runner", HasSideCar = true, Year = 2015 };
            Vehicle car2 = new Car() { HasTrunk = true, Make = "Toyota", Model = "4Runner", NumberOfCupHolders = 12, Year = 2015 };
            Vehicle motorcycle2 = new Motorcycle() { HasKickStand = true, Make = "Toyota", Model = "4Runner", HasSideCar = false, Year = 2015 };

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            /* 
            foreach (Car item1 in vehicles)
            {
                foreach (Motorcycle item2 in vehicles)
                {

                    Console.WriteLine(item2.Make, item2.Model, item2.Year, item2.HasKickStand, item2.HasSideCar);
                }
                Console.WriteLine(item1.Make, item1.Model, item1.Year, item1.NumberOfCupHolders, item1.HasTrunk);
            }

            */
            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Make}, {item.Model}, {item.Year}");
            }

            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract();
            car1.DriveVirtual();
            motorcycle2.DriveAbstract();
            motorcycle2.DriveVirtual();
            #endregion            
            Console.ReadLine();
        }
    }
}
