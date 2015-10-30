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
            zegHallo = new Begroeting("Fransje");
            zegHallo.gegroet();

            // Maak verschillende Begroeting objecten (instanties) die verschillende personen begroeten.
            // Voeg een veld leeftijd toe. Maak een nieuwe constructor die zowel de naam als de leeftijd kan
            // initialiseren.

            Begroeting zegGedag = new Begroeting("Suzanne");
            zegGedag.gegroet();


            Console.ReadKey();
        }
    }    
}


