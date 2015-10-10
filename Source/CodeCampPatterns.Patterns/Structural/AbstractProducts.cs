using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public abstract class AbstractProductOne
    {
    }

    public abstract class AbstractProductTwo
    {
        public abstract void Interacts(AbstractProductOne productOne);
    }
}
