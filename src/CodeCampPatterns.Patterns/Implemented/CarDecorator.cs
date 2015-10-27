using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class CarDecorator : VehicleDecorator
    {
        public CarDecorator(IVehicle car) 
            : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine(String.Format("[{0}] Tweet: {1}", DateTime.Now.ToString(), "successfully finished #car"));
        }
    }
}
