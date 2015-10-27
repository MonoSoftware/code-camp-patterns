using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class GasolineEngine : IEngine
    {
        public string EngineParts
        {
            get
            {
                return "Engine parts for gasoline engine.";
            }
        }
    }
}
