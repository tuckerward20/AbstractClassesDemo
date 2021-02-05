using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }
        public bool HasTrunk { get; set; }
        public int NumberOfCupHolders { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("abstract car driving boiii");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("override virtual car driving boii");
        }
    }
}
