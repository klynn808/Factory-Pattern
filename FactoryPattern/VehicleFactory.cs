using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string numberOfTires)
        {
            switch (numberOfTires.ToLower())
            {
                case "two":
                    return new Motorcycle();
                case "four":
                    return new Suv();
                default:
                    return new Suv();
            }
        }
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Suv();
                default: 
                    return new Suv();
            }
        }
    }

    
}
