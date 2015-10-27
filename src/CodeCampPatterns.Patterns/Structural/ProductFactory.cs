using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class ProductFactory : AbstractProductFactory
    {
        public override AbstractProduct CreateProduct(int identifier)
        {
            switch (identifier)
            {
                case 1:
                    return new ProductOne();
                case 2:
                    return new ProductTwo();
                case 3:
                    return new ProductThree();
                default:
                    return null;
            }
        }
    }
}
