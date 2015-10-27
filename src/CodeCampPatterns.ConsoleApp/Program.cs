//#define Structural

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
            Facade facade = new Facade();
            facade.OperationA();
            facade.OperationB();
            facade.OperationZ();

            Console.ReadLine();

#else
            //Example with the implemented pattern on a real-world example
            Car car = new Car();
            car.CreateCar();

            Console.ReadLine();
#endif
        }
    }
}
