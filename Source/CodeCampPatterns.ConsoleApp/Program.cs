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
            ITarget target = new Adapter();
            target.SpecificMethod();
            Console.ReadLine();
#else
            //Example with the implemented pattern on a real-world example

            List<IVehicle> vehicles = new List<IVehicle>()
            {
                new CarAdapter(),
                new MotorcycleAdapter()
            };

            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.GetVehicleName();
            }

            Console.ReadLine();
#endif
        }
    }
}
