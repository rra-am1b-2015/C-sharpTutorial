using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Enumerations
{
   

    class Program
    {
        enum ijsSoorten { aardbei = 3, chocolade = 2, citroen = 0, malaga = 1, meloen = 6, stracciatella = 5, mango = 7, perzik = 4 };

        static void Main(string[] args)
        {
            Console.Title = "Enumerations";

            //string ijsSoorten = "gemalen bladluis";

            ijsSoorten ijsSmaak;
           

            ijsSmaak = ijsSoorten.citroen;

            Console.WriteLine("Ik heb vandaag heerlijk {0}-ijs gegeten. Het was fantastisch van smaak", ijsSmaak);

            for ( int i = 0; i < 8; i++)
            {
                Console.WriteLine("Waardenummer {0} van de enumeration ijsSoorten heeft de waarde {1}", i, ijsSmaak );
                ijsSmaak = ijsSmaak + 1;
            }

            // Maak een programma dat je mening vraagt over alle ijssmaken in de enumeration. Gebruik daarbij een for-loop.
            // De antwoorden worden opgeslagen in een string[] meningOverIjsSmaak array. Alle antwoorden worden aan het einde achter elkaar 
            // weergegeven in de vorm:
            // Ik vind {ijsSoort}: {meningOverIjsSmaak}

            Console.Clear();
            ijsSmaak = ijsSoorten.citroen;
            Console.WriteLine("Geef uw mening over de onderstaande ijssmaken\n" + 
                              "druk op een willekeurige toets om verder te gaan...");
            Console.ReadKey();

            for ( int i = 0; i < 8; i++)
            {
                Console.WriteLine("Geef uw mening over de ijssoort {0}:", ijsSmaak);
                ijsSmaak++;
            }
            



            Console.ReadKey();
        }
    }
}
