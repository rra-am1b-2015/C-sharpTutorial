using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 16 Classes Part 2";
            Begroeting zegHallo;
            zegHallo = new Begroeting("Fransje",123);
            zegHallo.Leeftijd = 23;
            zegHallo.Naam = "Frans";
            zegHallo.gegroet();



            // Maak verschillende Begroeting objecten (instanties) die verschillende personen begroeten.
            // Voeg een veld leeftijd toe. Maak een nieuwe constructor die zowel de naam als de leeftijd kan
            // initialiseren.

            Begroeting zegGedag = new Begroeting("Suzanne");
            zegGedag.gegroet();


            Begroeting groetNummer3;
            groetNummer3 = new Begroeting("Arjan de Ruijter", 47);

            groetNummer3.Leeftijd = 48;
            groetNummer3.Naam = "Arian de Ruijter";
            groetNummer3.gegroet();

            // Maak 3 instanties(objecten) van de class begroeting, stop deze in een array en roep voor iedere
            // instantie de gegroet() method aan. Gebruik voor iedere instantie een andere overload van de constructor.

            Begroeting groetNummer4;
            groetNummer4 = new Begroeting();
            groetNummer4.Naam = "Rudolph";
            groetNummer4.Leeftijd = 49;
            groetNummer4.gegroet();

            Begroeting[] test = new Begroeting[3] { new Begroeting(),
                                                    new Begroeting("Harry"),
                                                    new Begroeting("Jim", 67)};

           for ( int i = 0; i < 3; i++)
           {
                test[i].gegroet();
           }


 


            Console.ReadKey();
        }
    }    
}


