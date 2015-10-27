using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCampPatterns.Patterns.Structural.Products;

namespace CodeCampPatterns.Patterns.Structural
{
    public class Factory : AbstractFactory
    {
        public override AbstractProductOne CreateProductOne()
        {
            return new ProductOne();
        }

        public override AbstractProductTwo CreateProductTwo()
        {
            return new ProductTwo();
        }
    }
}
