using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class SubsystemThree
    {
        public void OperationThreeA()
        {
            Console.WriteLine(String.Format("{0} - OperationThreeA", this.GetType().Name));

        }

        public void OperationThreeB()
        {
            Console.WriteLine(String.Format("{0} - OperationThreeB", this.GetType().Name));

        }
    }
}
