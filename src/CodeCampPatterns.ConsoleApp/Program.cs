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
            ElectricCar electricCar = new ElectricCar();
            electricCar.Name = "Prius";

            SportsCar sportsCar = new SportsCar();
            sportsCar.Name = "Mustang";

            electricCar.StartEngine();
            sportsCar.StartEngine();
            
            Console.ReadLine();
        }
    }
}
