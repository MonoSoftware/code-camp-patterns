using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductOne CreateProductOne();

        public abstract AbstractProductTwo CreateProductTwo();
    }
}
