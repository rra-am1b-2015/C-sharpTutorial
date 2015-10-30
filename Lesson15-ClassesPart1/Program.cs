using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_ClassesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 15 Classes Part 1";

            Random willekeurigGetal;
            willekeurigGetal = new Random();

            Console.WriteLine("Het object (instantie van de class Random) heeft een method next().\n" +
                                "Door het object te maken hebben we toegang tot\n" + 
                                " kan een willekeurig geheel getal bedenken. Bijvoorbeeld deze: {0}", 
                                willekeurigGetal.Next(0, 1));

            // Maak een elektronische dobbelsteen met zes vlakken. Gooi deze virtueel 10 keer en bereken de
            // gemiddelde waarde die gegooid

            Console.WriteLine("\n\n*********************************************************************\n" +
                              "Deze applicatie vraagt hoeveel keer een elektronische dobbelsteen\n" +
                              "gegooid moet worden. Daarna worden de gegooide waarden in een array" +
                              "gestopt en het gemiddelde berekent. Het gemiddelde wordt weergegeven op" +
                              "het scherm.");
            Console.Write("\n---------------------------------------------------------------------------\n" +
                              "Geef het aantal malen dat de dobbelsteen gegooid moet worden: ");
            string invoer = Console.ReadLine();
            int aantalMalenGooien = Convert.ToInt32(invoer);

            int[] worpen = new int[aantalMalenGooien];
            Random maakGetal = new Random();
            
            for (int i = 0; i < worpen.Length; i++)
            {
                worpen[i] = maakGetal.Next(1, 7);
            }
            double gemiddelde = worpen.Average();
            Console.WriteLine("Het gemiddelde van alle worpen is: {0}", gemiddelde.ToString());
            Console.ReadKey();
        }
    }
}
