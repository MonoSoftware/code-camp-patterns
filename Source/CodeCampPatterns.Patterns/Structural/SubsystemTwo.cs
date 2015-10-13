using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class SubsystemTwo
    {
        public void OperationTwoA()
        {
            Console.WriteLine(String.Format("{0} - OperationTwoA", this.GetType().Name));

        }

        public void OperationTwoB()
        {
            Console.WriteLine(String.Format("{0} - OperationTwoB", this.GetType().Name));
        }
    }
}
