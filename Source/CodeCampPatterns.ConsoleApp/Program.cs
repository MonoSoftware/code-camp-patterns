#define Structural

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCampPatterns.Patterns.Structural;

namespace CodeCampPatterns.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
#if Structural
            //Example with the structural code

            //Uncomment to see compile time inaccessibility due to protection level of the constructor
            //Singleton objError = new Singleton();

            Console.WriteLine("Get instance of singleton object for the first time:");
            Singleton objFirst = Singleton.GetInstance();
            Console.WriteLine();

            Console.WriteLine("Get instance of singleton object again:");
            Singleton objSecond = Singleton.GetInstance();
            Console.WriteLine();

            Console.WriteLine("Check whether \"objFirst\" and \"objSecond\" are trully the same:");
            Console.WriteLine("Check against reference equality: {0}", Object.ReferenceEquals(objFirst, objSecond));

            Console.ReadLine();
#else
            //Example with the implemented pattern on a real-world example
            

#endif
        }
    }
}
