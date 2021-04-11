using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    class TriWheel : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("That is so adorable - try a real vehicle");
        }

        public void NubmerOfTires()
        {
            Console.WriteLine("We going Disc World?");
        }
    }
}
