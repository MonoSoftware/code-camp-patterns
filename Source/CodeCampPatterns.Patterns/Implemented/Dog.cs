using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog: I'm eating big bone.");
        }
    }
}
