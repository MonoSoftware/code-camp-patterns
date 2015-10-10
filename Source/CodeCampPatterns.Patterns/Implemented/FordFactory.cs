using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class FordFactory : CarFactory
    {
        public override ElectricCar CreateElectricCar()
        {
            return new FocusElectric();
        }

        public override GasolineCar CreateGasolineCar()
        {
            return new Mustang();
        }
    }
}
