using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class SubsystemOne
    {
        public void OperationOneA()
        {
            Console.WriteLine(String.Format("{0} - OperationOneA", this.GetType().Name));
        }

        public void OperationOneB()
        {
            Console.WriteLine(String.Format("{0} - OperationOneB", this.GetType().Name));
        }
    }
}
