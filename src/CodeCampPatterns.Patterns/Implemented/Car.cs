using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("I'm driving a car!");
        }
    }
}
