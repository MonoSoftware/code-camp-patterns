using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public abstract class AbstractDecorator : IComponent
    {
        private IComponent component;

        public AbstractDecorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            this.component.Operation();
        }
    }
}
