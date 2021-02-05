using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCar { get; set; }
        public bool HasKickStand { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("abstract motorcycle driving boiii");
        }


        public override void DriveVirtual()
        {
            Console.WriteLine("override virtual motorcycle driving boii");
        }
    }
}
