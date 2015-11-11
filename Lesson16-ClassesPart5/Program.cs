using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 16 Classes Part 5";

            Smartphone mobieltje;
            mobieltje = new Smartphone("Samsung", 12.56f, OperatingSystem.Android, "Kitkat", 16 );
            mobieltje.ShowSmartphoneProps();
            Console.WriteLine(mobieltje.ShowSmartphoneInfoText());

            Smartphone[] mobieltjes = new Smartphone[] 
            {
                new Smartphone("Samsung", 12.56f, OperatingSystem.Android, "Kitkat", 16),
                new Smartphone("IPhone", 230f, OperatingSystem.iOS, "iOS 7", 32),
                new Smartphone("BlackBerry", 670f, OperatingSystem.BlackberryOs, "BlackBerry OS 10", 64),
                new Smartphone("Blackberry", 430f, OperatingSystem.BlackberryOs, "Blackberry OS 9", 128),
                new Smartphone("Samsung", 30f, OperatingSystem.Android, "LolliPop", 128),
            };

            for (int i = 0; i < mobieltjes.Length; i++)
            {
                Console.WriteLine(mobieltjes[i].ShowSmartphoneInfoText());
            }

            foreach (Smartphone mobile in mobieltjes)
            {
                mobile.ShowSmartphoneProps();
            }



            // Een smartphone class in een apart bestand
            // bedenk 5 relevante Fields
            // Maak de properties voor de Fields (get en set)
            // Maak een constructor die alle 5 de Fields kan initialiseren.
            // Maak een method die alle relevante gegevens weer kan geven.
            // Maak een smartphone array met 5 objecten.
            // Roep met een foreach loop de method ShowSmartPhone() aan van alle objecten.


            // Maak een laptop class in een apart bestand
            // bedenk 5 relevante Fields
            // Maak de properties voor de Fields (get en set)
            // Maak een constructor die alle 5 de Fields kan initialiseren.
            // Maak een method die alle relevante gegevens weer kan geven.
            // Maak een laptop array met 5 objecten.
            // Roep met een foreach loop de method ShowLaptop() aan van alle objecten.
            Console.ReadKey();
        }
    }
}
