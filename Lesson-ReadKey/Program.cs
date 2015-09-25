using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson gebruik readKey()";
            /*
            Console.Write("Type iets in: ");

            ConsoleKeyInfo invoer = Console.ReadKey();

            if (invoer.KeyChar == Convert.ToChar(ConsoleKey.PrintScreen))
            {
                Console.WriteLine("\nU heeft de letter de spatiebalk ingedrukt");
            }
            else
            {
                Console.WriteLine("\nU heeft de volgende letter ingetyped: {0} dit is niet de spatiebalk", invoer.KeyChar);
            }
            */
            // Maak een programma die vraagt om twee gehele getallen. Vervolgens moet het programma melden 
            // dat de som (optelling) van beide getallen alleen op het scherm komt als er op de '=' wordt gedrukt.

            Console.WriteLine("Dit programma berekent de som van twee ingevoerde getallen, alleen\n" +
                                "nadat er op het '=' teken is gedrukt. Anders stopt het programma zonder\n" + 
                                "de oplossing te geven...");

            Console.Write("\n\nGeef het eerste getal: ");

            string invoer = Console.ReadLine();

            int getal1 = Convert.ToInt32(invoer);

            Console.Write("\n\nGeef het tweede getal: ");

            invoer = Console.ReadLine();

            int getal2 = Convert.ToInt32(invoer);

            Console.WriteLine("\n\nDruk op het '=' teken wanneer u geinteresseerd bent in het antwoord\n" + 
                                "anders stopt het programma zonder u het antwoord te geven.....");

            Console.Write("\nDruk op het '=' teken voor het antwoord: ");

            ConsoleKeyInfo toetsaanslag = Console.ReadKey(true);



            if ( toetsaanslag.KeyChar == '=')
            {
                long som = getal1 + getal2;
                Console.WriteLine("\n\nHet antwoord\n" +
                                  "+++++++++++++\n" + 
                                  "{0} + {1} = {2}", getal1, getal2, som );

            }
            else
            {
                Console.WriteLine("\nU heeft niet op het '=' teken gedrukt. Het programma stopt\n" +
                                    "en blijft u het antwoord schuldig....");
            }






            Console.ReadLine();
        }
    }
}
