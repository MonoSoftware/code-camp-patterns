using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public abstract class CarDecorator : ICar
    {
        private ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public int Id
        {
            get
            {
                return this.car.Id;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.car.Date;
            }
        }

        public string Name
        {
            get
            {
                return this.car.Name;
            }
        }

        public virtual void Assemble()
        {
            this.car.Assemble();
        }
    }
}
