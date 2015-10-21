using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat: I'm eating Whiskas!");
        }
    }
}
