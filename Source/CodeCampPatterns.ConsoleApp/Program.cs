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
            ICar mercedesA = new Mercedes(1, "A Class");
            ICar audi3= new Audi(3, "A3");
            
            CarDecorator mercedesDecorator = new MercedesDecorator(mercedesA);
            CarDecorator audiDecorator = new AudiDecorator(audi3);

            mercedesDecorator.Assemble();
            audiDecorator.Assemble();

            Console.ReadLine();
#endif
        }
    }
}
