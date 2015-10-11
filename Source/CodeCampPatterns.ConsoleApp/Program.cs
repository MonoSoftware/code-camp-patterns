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
            IPrototype p1 = new Prototype();
            IPrototype p2 = p1.Clone();

            Console.WriteLine(String.Format("Checke whether objects \"p1\" and \"p2\" are equal: {0}", Object.ReferenceEquals(p1, p2)));
            Console.ReadLine();
#else
            //Example with the implemented pattern on a real-world example
            Console.WriteLine("First car:");
            Console.WriteLine("Creation started: {0}", DateTime.UtcNow);
            ICar mercedesFirst = new Mercedes("A Class", new { CarParts = "Everything a car needs to be assembled properly." });
            Console.WriteLine("Creation ended: {0}", DateTime.UtcNow);

            Console.WriteLine("Second car:");
            Console.WriteLine("Creation started: {0}", DateTime.UtcNow);
            ICar mercedesSecond = mercedesFirst.Clone();
            Console.WriteLine("Creation ended: {0}", DateTime.UtcNow);

            Console.ReadLine();
#endif
        }
    }
}
