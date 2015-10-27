using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public abstract class VehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IEngine CreateEngine();
    }
}
