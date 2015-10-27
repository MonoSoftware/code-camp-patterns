#define Structural

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCampPatterns.Patterns.Implemented;
using CodeCampPatterns.Patterns.Structural;

namespace CodeCampPatterns.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
#if Structural
            //Example with the structural code
            IComponent comp = new Component();
            AbstractDecorator decorator = new Decorator(comp);
            decorator.Operation();

            Console.ReadLine();
#else
            //Example with the implemented pattern on a real-world example
            IVehicle car = new Car(1, "Small car");
            IVehicle vehicle = new Truck(3, "Big truck");
            
            VehicleDecorator carDecorator = new CarDecorator(car);
            VehicleDecorator truckDecorator = new TruckDecorator(vehicle);

            carDecorator.Assemble();
            truckDecorator.Assemble();

            Console.ReadLine();
#endif
        }
    }
}
