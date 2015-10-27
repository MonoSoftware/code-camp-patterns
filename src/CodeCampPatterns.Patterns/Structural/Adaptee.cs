using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class Adaptee
    {
        public void SpecificAdapteeMethod()
        {
            Console.WriteLine("SpecificAdapteeMethod is called!");
        }
    }
}
