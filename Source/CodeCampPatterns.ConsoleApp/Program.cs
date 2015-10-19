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
            
            //Consumer of abstract factory pattern

            AbstractFactory factory = new Factory();
            AbstractProductOne abstractProductOne = factory.CreateProductOne();
            AbstractProductTwo abstractProductTwo = factory.CreateProductTwo();
            abstractProductTwo.Interacts(abstractProductOne);

            Console.ReadLine();

#else
            //Example with the implemented pattern on a real-world example

            //Consumer of abstract factory pattern
            string make = "car";

            VehicleFactory vehicleFactory = null;
            if (make.Equals("car"))
            {
                vehicleFactory = new CarFactory();
            }
            else
            {
                vehicleFactory = new TruckFactory();
            }

            IChassis vehicleChassis = vehicleFactory.CreateChassis();
            IEngine vehicleEngine = vehicleFactory.CreateEngine();
            IBody vehicleBody = vehicleFactory.CreateBody();
            
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleEngine.EngineParts);
            Console.WriteLine(vehicleBody.BodyParts);

            Console.ReadLine();
#endif
        }
    }
}
