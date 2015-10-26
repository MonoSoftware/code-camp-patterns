using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class ElectricCar : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("Super quiet engine has been started...");
        }
    }
}
