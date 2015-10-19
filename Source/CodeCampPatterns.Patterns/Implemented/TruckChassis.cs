using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class TruckChassis : IChassis
    {
        public string ChassisParts
        {
            get
            {
                return "Chassis parts for a truck.";
            }
        }
    }
}
