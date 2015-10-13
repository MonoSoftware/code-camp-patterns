using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class RealSubject : ISubject
    {
        public void PerformAction()
        {
            Console.WriteLine(String.Format("{0} action performed", this.GetType().Name));
        }
    }
}
