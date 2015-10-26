using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class TruckDecorator : VehicleDecorator
    {
        public TruckDecorator(IVehicle car) 
            : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine(String.Format("[{0}] Log: {1}", DateTime.Now.ToString(), "truck successfully finished"));
        }
    }
}
