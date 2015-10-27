using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class TruckFactory : VehicleFactory
    {
        public override IBody CreateBody()
        {
            return new TruckBody();
        }

        public override IChassis CreateChassis()
        {
            return new TruckChassis();
        }

        public override IEngine CreateEngine()
        {
            return new DieselEngine();
        }
    }
}
