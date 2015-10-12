using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public interface IWorker
    {
        int WorkerId { get; set; }
        string Name { get; set; }
        string Position { get; set; }

        void Display(int indentation);
    }
}
