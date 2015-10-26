using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class SportsCar : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("Super loud engine has been started...");
        }
    }
}
