using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
            Console.WriteLine("3. Inside private constructor");
        }

        public static Singleton GetInstance()
        {
            Console.WriteLine("1. Check whether the instance is null.");
            if (instance == null)
            {
                Console.WriteLine("2. Instance object is null at the moment, create a Singleton object and assign it to the instance variable.");
                instance = new Singleton();
                Console.WriteLine("4. Object is created and assigned to the instance variable.");
            }
            Console.WriteLine("5. Object is assigned to the instance, return it!");
            return instance;
        }
    }
}
