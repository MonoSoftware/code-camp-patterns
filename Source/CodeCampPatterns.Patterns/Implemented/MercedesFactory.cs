using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class MercedesFactory : CarFactory
    {
        public override ElectricCar CreateElectricCar()
        {
            return new BClassElectricDrive();
        }

        public override GasolineCar CreateGasolineCar()
        {
            return new AClass();
        }
    }
}
