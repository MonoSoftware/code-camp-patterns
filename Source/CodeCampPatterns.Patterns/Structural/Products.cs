using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class ProductOne : AbstractProduct
    {
        public override string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }

    public class ProductTwo : AbstractProduct
    {
        public override string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }

    public class ProductThree : AbstractProduct
    {
        public override string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }
}
