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
            ISubject realSubject = new RealSubject();
            realSubject.PerformAction();

            ISubject proxy = new Proxy();
            proxy.PerformAction();

            Console.ReadLine();

#else
            //Example with the implemented pattern on a real-world example

            SafeCar safeCar1 = new SafeCar(25);
            SafeCar safeCar2 = new SafeCar(17);

            safeCar1.DriveCar();
            safeCar2.DriveCar();

            Console.ReadLine();
#endif
        }
    }
}
