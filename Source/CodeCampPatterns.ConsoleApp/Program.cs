#define Structural

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCampPatterns.Patterns.Implemented;
using CodeCampPatterns.Patterns.Structural;

namespace CodeCampPatterns.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
#if Structural
            //Example with the structural code
            
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(0);

            Console.ReadLine();

#else
            //Example with the implemented pattern on a real-world example

            Supervisor managingDirector = new Supervisor(1, "John", "Managing Director");

            Supervisor salesDirector = new Supervisor(2, "Jennifer", "Sales Director");

            Supervisor marketingDirector = new Supervisor(3, "Phil", "Marketing Director");

            Supervisor financeDirector = new Supervisor(4, "Ann", "Finance Director");

            managingDirector.AddEmployee(salesDirector);
            managingDirector.AddEmployee(marketingDirector);
            managingDirector.AddEmployee(financeDirector);

            Employee salesRepresentative1 = new Employee(5, "Alex", "Sales representative");
            Employee salesRepresentative2 = new Employee(6, "Travis", "Sales representative");
            salesDirector.AddEmployee(salesRepresentative1);
            salesDirector.AddEmployee(salesRepresentative2);

            Supervisor managementAccountant = new Supervisor(7, "Barbara", "Management accountant");
            Employee financialAccountant = new Employee(8, "David", "Financial accountant");
            financeDirector.AddEmployee(managementAccountant);
            financeDirector.AddEmployee(financialAccountant);

            Employee accountantAssistant = new Employee(9, "Andy", "Accountant assistant");
            managementAccountant.AddEmployee(accountantAssistant);

            managingDirector.Display(0);

            Console.ReadLine();
#endif
        }
    }
}
