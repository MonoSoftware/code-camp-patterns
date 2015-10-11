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

            ProductFactory factory = new ProductFactory();
            for (int i = 1; i <= 4; i++)
            {
                AbstractProduct p = factory.CreateProduct(i);
                if (p != null)
                {
                    Console.WriteLine(@"Product name: {0}", p.Name);
                }
            }

            Console.ReadLine();
#else
            //Example with the implemented pattern on a real-world example

            MercedesFactory mercedesFactory = new MercedesFactory();
            Car mercedesAFirst = mercedesFactory.CreateCar(MercedesSeries.A);
            Car mercedesBFirst = mercedesFactory.CreateCar(MercedesSeries.B);
            Car mercedesCFirst = mercedesFactory.CreateCar(MercedesSeries.C);
            Car mercedesEFirst = mercedesFactory.CreateCar(MercedesSeries.E);
            Car mercedesSFirst = mercedesFactory.CreateCar(MercedesSeries.S);
            Car mercedesASecond = mercedesFactory.CreateCar(MercedesSeries.A);

            mercedesAFirst.GetDescription();
            mercedesBFirst.GetDescription();
            mercedesCFirst.GetDescription();
            mercedesEFirst.GetDescription();
            mercedesSFirst.GetDescription();
            mercedesASecond.GetDescription();

            Console.ReadLine();
#endif
        }
    }
}
