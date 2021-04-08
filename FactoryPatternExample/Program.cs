using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of vehicle do you want to create");
            string userVehicle = Console.ReadLine();

            IVehicle drive = VehicleFactory.GetVehicle(userVehicle);

            drive.Drive();
           

            Console.WriteLine("How many wheels does your vehicle have?");
            string userWheel = Console.ReadLine();

            IVehicle tires = VehicleFactory.GetTireCount(userWheel);

            tires.NubmerOfTires();
          
        }
    }
}
