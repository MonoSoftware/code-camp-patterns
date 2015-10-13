using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class SafeCar : ICar
    {
        private Car car = new Car();
        private int driverAge;

        public SafeCar(int driverAge)
        {
            this.driverAge = driverAge;
        }

        public void DriveCar()
        {
            if (this.driverAge >= 18)
            {
                this.car.DriveCar();
            }
            else
            {
                Console.WriteLine("Too young...");
            }
        }
    }
}
