using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    static class VehicleFactory
    {
   
        public static IVehicle GetTireCount(string tires, string drive)
        {
            if (tires == "2" && drive == "motorcycle")
            {
                return new Motorcycle();    // 2-yes  4-yes   3-yes  other-yes 
            }
            else if (tires == "4" && drive == "car")  
            {
                return new Car();            // 2-yes  4-yes   3-yes   other-yes
            }
            else if (tires == "3")
            {
                return new TriWheel();
            }
            else
            {
                return new Other();       
            }
        }

        public static IVehicle GetVehicle(string drive)
        {
            switch (drive.ToLower())
            {
                case "motorcycle":
                    return new Motorcycle();
                case "car":
                    return new Car();
                default:
                    return new Other();
            }
        }

    }
}
