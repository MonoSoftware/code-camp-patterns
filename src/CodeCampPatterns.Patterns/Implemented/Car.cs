using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public abstract class Car
    {
        private string name = "Generic Car Name";
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine has been started...");
        }
    }
}
