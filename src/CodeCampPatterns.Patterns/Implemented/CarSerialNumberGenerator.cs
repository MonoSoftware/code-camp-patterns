using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class CarSerialNumberGenerator
    {
        private int count = 0;

        private static CarSerialNumberGenerator serialNumberGenerator;

        public static CarSerialNumberGenerator Instance
        {
            get
            {
                if (serialNumberGenerator == null)
                {
                    serialNumberGenerator = new CarSerialNumberGenerator();
                }
                return serialNumberGenerator;
            }
        }

        private CarSerialNumberGenerator()
        { }

        public int GetNumber()
        {
            return ++count;
        }
    }
}
