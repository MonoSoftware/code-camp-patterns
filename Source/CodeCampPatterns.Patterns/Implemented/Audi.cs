using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Audi : ICar
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public Audi(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Date = DateTime.Now;
        }

        public void Assemble()
        {
            Console.WriteLine("Audi - assembled!!!");
        }
    }
}
