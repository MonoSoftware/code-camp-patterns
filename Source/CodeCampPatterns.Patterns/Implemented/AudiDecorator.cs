using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class AudiDecorator : CarDecorator
    {
        public AudiDecorator(ICar car) : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine(String.Format("[{0}] Tweet: {1}", DateTime.Now.ToString(), "successfully finished #audi"));
        }
    }
}
