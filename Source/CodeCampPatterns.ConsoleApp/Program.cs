using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCampPatterns.Patterns.Implemented;

namespace CodeCampPatterns.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Happy";

            Cat cat = new Cat();
            cat.Name = "Grumpy";

            dog.Eat();
            cat.Eat();

            Console.ReadLine();
        }
    }
}
