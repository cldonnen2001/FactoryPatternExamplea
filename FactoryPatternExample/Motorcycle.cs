using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle!");
        }

        void IVehicle.NubmerOfTires()
        {
            Console.WriteLine("This has two tires");
        }
    }
        
}
