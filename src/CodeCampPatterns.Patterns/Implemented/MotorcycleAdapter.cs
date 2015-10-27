using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class MotorcycleAdapter : Motorcycle, IVehicle
    {
        public void GetVehicleName()
        {
            this.GetMotorcycleName();
        }
    }
}
