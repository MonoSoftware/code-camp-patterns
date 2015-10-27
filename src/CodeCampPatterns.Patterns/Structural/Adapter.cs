using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class Adapter : Adaptee, ITarget
    {
        public void SpecificMethod()
        {
            this.SpecificAdapteeMethod();
        }
    }
}
