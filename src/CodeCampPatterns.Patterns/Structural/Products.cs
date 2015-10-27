using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural.Products
{
    public class ProductOne : AbstractProductOne
    {

    }

    public class ProductTwo : AbstractProductTwo
    {
        public override void Interacts(AbstractProductOne productOne)
        {
            Console.WriteLine(String.Format("{0} interacts with a {1}", this.GetType().Name, productOne.GetType().Name));
        }
    }
}
