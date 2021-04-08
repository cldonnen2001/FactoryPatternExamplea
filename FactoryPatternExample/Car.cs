using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }

        void IVehicle.NubmerOfTires()
        {
            Console.WriteLine("This has four tires");
        }
    }

}
