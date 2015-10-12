using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Supervisor : IWorker
    {
        private List<IWorker> employees;

        public string Name { get; set; }

        public string Position { get; set; }

        public int WorkerId { get; set; }

        public Supervisor(int id, string name, string position)
        {
            this.WorkerId = id;
            this.Name = name;
            this.Position = position;

            employees = new List<IWorker>();
        }

        public void AddEmployee(IWorker employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(IWorker employee)
        {
            employees.Remove(employee);
        }

        public void Display(int indentation)
        {
            Console.Write(new String(' ', indentation));
            Console.WriteLine("[{0}] {1} - {2}", this.WorkerId, this.Name, this.Position);
            foreach (var employee in this.employees)
            {
                employee.Display(indentation + 2);
            }
        }
    }
}
