using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Car : IVehicle
    {
        public string Color
        {
            get
            {
                return "Car color";
            }
        }

        public string Engine
        {
            get
            {
                return "Gasoline engine.";
            }
        }
    }
}
