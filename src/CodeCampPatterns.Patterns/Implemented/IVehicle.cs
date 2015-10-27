using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public interface IVehicle
    {
        int Id { get; }
        string Name { get; }
        DateTime Date { get; }

        void Assemble();
    }
}
