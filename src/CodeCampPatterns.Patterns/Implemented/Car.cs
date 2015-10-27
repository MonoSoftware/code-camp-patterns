using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class Car
    {
        private CarAccessories accessories = new CarAccessories();
        private CarBody body = new CarBody();
        private CarEngine engine = new CarEngine();
        private CarModel model = new CarModel();

        public void CreateCar()
        {
            model.DecideModel();
            body.BuildBody();
            engine.AssembleEngine();
            accessories.AddAccessories();
        }

    }
}
