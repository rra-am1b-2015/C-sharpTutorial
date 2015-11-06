using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 16 Classes Part 4";

            // Maak een object van deze class

            Auto voertuig = new Auto();

            voertuig.CarBrand = "Volkswagen";

            Console.WriteLine("{0}", voertuig.CarBrand);

            Console.ReadKey();
        }
    }
}
