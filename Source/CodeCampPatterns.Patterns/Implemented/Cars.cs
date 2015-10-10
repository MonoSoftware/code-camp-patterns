using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    #region Ford Cars

    public class FocusElectric : ElectricCar
    {
        public override void Charge()
        {
            Console.WriteLine("Car recharging in process...After few hours car is rechared completely.");
        }

        public override void RaceAgainst(ElectricCar opponent)
        {
            //Car racing logic
            Console.WriteLine(String.Format("{0} vs. {1}: {2} wins", opponent.GetType().Name, this.GetType().Name, opponent.GetType().Name));
        }

        public override void RaceTo100Kmph()
        {
            Console.WriteLine(String.Format("{0}: 0 - 100 Km/h: 15 seconds", this.GetType().Name));
        }
    }

    public class Mustang : GasolineCar
    {
        public override void Fuel()
        {
            Console.WriteLine("Car refueling in process...After few minutes car is refueled completelly, but your wallet is empty.");
        }

        public override void RaceAgainst(GasolineCar opponent)
        {
            //Car racing logic
            Console.WriteLine(String.Format("{0} vs. {1}: {2} wins", this.GetType().Name, opponent.GetType().Name, this.GetType().Name));
        }

        public override void RaceTo100Kmph()
        {
            Console.WriteLine(String.Format("{0}: 0 - 100 Km/h: 5 seconds", this.GetType().Name));
        }
    }

    #endregion Ford Cars

    #region Mercedes Cars

    public class BClassElectricDrive : ElectricCar
    {
        public override void Charge()
        {
            Console.WriteLine("Car recharging in process...After few hours car is rechared completely.");
        }

        public override void RaceAgainst(ElectricCar opponent)
        {
            //Car racing logic
            Console.WriteLine(String.Format("{0} vs. {1}: tied", this.GetType().Name, opponent.GetType().Name));
        }

        public override void RaceTo100Kmph()
        {
            Console.WriteLine(String.Format("{0}: 0 - 100 Km/h: 10 seconds", this.GetType().Name));
        }
    }

    public class AClass : GasolineCar
    {
        public override void Fuel()
        {
            Console.WriteLine("Car refueling in process...After few minutes car is refueled completelly, but your wallet is empty.");
        }

        public override void RaceAgainst(GasolineCar opponent)
        {
            //Car racing logic
            Console.WriteLine(String.Format("{0} vs. {1}: tied", this.GetType().Name, opponent.GetType().Name));
        }

        public override void RaceTo100Kmph()
        {
            Console.WriteLine(String.Format("{0}: 0 - 100 Km/h: 9 seconds", this.GetType().Name));
        }
    }

    #endregion Mercedes Cars
}
