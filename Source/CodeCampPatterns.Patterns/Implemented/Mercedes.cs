using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Mercedes : ICar
    {
        public string Name { get; set; }

        public Mercedes(string name, object carParts)
        {
            //Assemble car
            //For the explanation purpose, let's say assembling lasts 20seconds
            Task.Delay(20000).Wait();
        }

        public ICar Clone()
        {
            return (ICar)this.MemberwiseClone();
        }
    }
}
