using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
            Year = 0000;
            Make = "Generic Make";
            Model = "Generic Model";
        }
        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        /*
         * Create an abstract class called Vehicle
         * The vehicle class shall have three string properties Year, Make, and Model
         */
        public int Year { get; set; } = 2001;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";


        /*
         * Set the defaults to something generic in the Vehicle class
         * Vehicle shall have an abstract method called DriveAbstract with no implementation
         * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
         */
        public abstract void DriveAbstract();
        
        public virtual void DriveVirtual()
        {
            Console.WriteLine("default virtual driving boiii");
        }
        /*
         */
    }
}
