using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public abstract class GasolineCar : Car
    {
        public abstract void Fuel();

        public abstract void RaceAgainst(GasolineCar opponent);
    }
}
