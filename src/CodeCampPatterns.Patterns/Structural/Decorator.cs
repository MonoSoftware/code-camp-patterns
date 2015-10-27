using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class Decorator : AbstractDecorator
    {
        public Decorator(IComponent component)
            : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Override Decorator Operation");
        }
    }
}
