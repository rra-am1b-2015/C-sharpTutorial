using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart4
{
    enum color { Pimpelpurple, sharlakred, Marshmellowyellow};

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 16 Classes Part 4";

            // Maak een object van deze class

            Auto voertuig = new Auto("Mercedes", "SLK", 3, color.Pimpelpurple, 3.6f);

            /*
            voertuig.CarBrand = "Volkswagen";
            voertuig.Type = "Rampo";
            voertuig.AmountOfDoors = 3;
            */

            voertuig.ShowCarProperties();

            Console.ReadKey();
        }
    }
}
