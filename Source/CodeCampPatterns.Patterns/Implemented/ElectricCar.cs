using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public abstract class ElectricCar : Car
    {
        public abstract void Charge();

        public abstract void RaceAgainst(ElectricCar opponent);
    }
}
