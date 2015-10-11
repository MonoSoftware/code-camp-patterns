using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Car
    {
        public string Name { get; set; }

        public string SerialNumber { get; set; }

        public int PowerInHp { get; set; }

        public DateTime CreatedDate { get; set; }

        public void GetDescription()
        {
            Console.WriteLine(String.Format("Mercedes:\nClass: {0}\nSerialNumber:{1}\nPowerInHp:{2}\nCreatedDate:{3}", this.Name, this.SerialNumber, this.PowerInHp, CreatedDate.ToString()));
        }
    }
}
