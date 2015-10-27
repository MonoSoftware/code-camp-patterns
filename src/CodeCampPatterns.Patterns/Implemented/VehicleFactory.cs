using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class VehicleFactory
    {
        public static IVehicle CreateVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Car:
                    return new Car();
                case VehicleType.Truck:
                    return new Truck();
                default:
                    Console.WriteLine("Unknown vehicle type");
                    return null;
            }
        }
    }
}
