using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    static class VehicleFactory
    {
   
        public static IVehicle GetTireCount(string tires, string drive = "car")
        {
            if (tires == "2")
            {
                return new Motorcycle();  // 4 returns car output
            }
            else if (tires == "4" && drive == "car")  
            {
                return new Car();         // 2  returns this has two tires
            }
            else
            {
                return new Other();  // not working 
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
