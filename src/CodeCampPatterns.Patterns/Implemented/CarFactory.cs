using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class CarFactory : VehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IEngine CreateEngine()
        {
            return new GasolineEngine();
        }
    }
}
