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

            ProductFactory factory = new ProductFactory();
            for (int i = 1; i <= 4; i++)
            {
                AbstractProduct p = factory.CreateProduct(i);
                if (p != null)
                {
                    Console.WriteLine(String.Format("Product name: {0}", p.Name));
                }
            }

            Console.ReadLine();
#else
            //Example with the implemented pattern on a real-world example

            IVehicle car = VehicleFactory.CreateVehicle(VehicleType.Car);
            IVehicle truck = VehicleFactory.CreateVehicle(VehicleType.Truck);

            Console.WriteLine(car.Color);
            Console.WriteLine(car.Engine);

            Console.WriteLine();

            Console.WriteLine(truck.Color);
            Console.WriteLine(truck.Engine);


            Console.ReadLine();
#endif
        }
    }
}
