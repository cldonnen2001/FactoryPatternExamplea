using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Other : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Not interested in this montrosity");
        }

        public void NubmerOfTires()
        {
            Console.WriteLine("That's not acceptable!");
        }
    }
}
