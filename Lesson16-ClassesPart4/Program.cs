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

            Auto[] voertuigen = new Auto[5]
            {
                new Auto("Daf", "electric", 6, color.sharlakred, 2f),
                new Auto("Fiat", "500", 3, color.Pimpelpurple, 2.4f),
                new Auto("Mercedes", "SLK", 4, color.Marshmellowyellow, 5f),
                new Auto("BMW", "Z8", 2, color.Marshmellowyellow, 2.6f),
                new Auto("Toyota", "Corolla", 1, color.Pimpelpurple, 8.5f)
            };            

            

            for (int i = 0; i < voertuigen.Length; i++)
            {
                voertuigen[i].ShowCarProperties();
            }

            Console.ReadKey();
        }
    }
}
