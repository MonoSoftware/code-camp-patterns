using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Truck : IVehicle
    {
        public string Color
        {
            get
            {
                return "Truck color";
            }
        }

        public string Engine
        {
            get
            {
                return "Diesel engine.";
            }
        }
    }
}
