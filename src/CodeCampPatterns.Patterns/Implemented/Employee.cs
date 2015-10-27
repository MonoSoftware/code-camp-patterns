using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Employee : IWorker
    {
        public string Name { get; set; }
        
        public string Position { get; set; }
        
        public int WorkerId { get; set; }

        public Employee(int workerId, string name, string position)
        {
            this.WorkerId = workerId;
            this.Name = name;
            this.Position = position;
        }

        public void Display(int indentation)
        {
            Console.Write(new String(' ', indentation));
            Console.WriteLine(String.Format("[{0}] {1} - {2}", this.WorkerId, this.Name, this.Position));
        }
    }
}
