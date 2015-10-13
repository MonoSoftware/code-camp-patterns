using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class Facade
    {
        private SubsystemOne subOne = new SubsystemOne();
        private SubsystemTwo subTwo = new SubsystemTwo();
        private SubsystemThree subThree = new SubsystemThree();

        public void OperationA()
        {
            subOne.OperationOneA();
            subTwo.OperationTwoA();
            subThree.OperationThreeA();
            Console.WriteLine();
        }

        public void OperationB()
        {
            subOne.OperationOneB();
            subTwo.OperationTwoB();
            subThree.OperationThreeB();
            Console.WriteLine();
        }

        public void OperationZ()
        {
            subOne.OperationOneA();
            subTwo.OperationTwoB();
            subThree.OperationThreeB();
            Console.WriteLine();
        }
    }
}
