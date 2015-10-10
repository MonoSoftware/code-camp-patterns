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
            
            //Consumer of abstract factory pattern

            AbstractFactory factory = new Factory();
            AbstractProductOne abstractProductOne = factory.CreateProductOne();
            AbstractProductTwo abstractProductTwo = factory.CreateProductTwo();
            abstractProductTwo.Interacts(abstractProductOne);

            Console.ReadLine();

#else
            //Example with the implemented pattern on a real-world example
            
            //Consumer of abstract factory pattern
            CarFactory fordFactory = new FordFactory();
            ElectricCar fordCarElectric = fordFactory.CreateElectricCar();
            GasolineCar fordCarGasoline = fordFactory.CreateGasolineCar();

            fordCarElectric.RaceTo100Kmph();
            fordCarElectric.Charge();

            fordCarGasoline.RaceTo100Kmph();
            fordCarGasoline.Fuel();

            CarFactory mercedesFactory = new MercedesFactory();
            ElectricCar mercedesCarElectric = mercedesFactory.CreateElectricCar();
            GasolineCar mercedesCarGasoline = mercedesFactory.CreateGasolineCar();

            mercedesCarGasoline.RaceTo100Kmph();
            mercedesCarElectric.Charge();

            mercedesCarGasoline.RaceTo100Kmph();
            mercedesCarGasoline.Fuel();

            fordCarElectric.RaceAgainst(mercedesCarElectric);
            mercedesCarGasoline.RaceAgainst(fordCarGasoline);

            Console.ReadLine();
#endif
        }
    }
}
