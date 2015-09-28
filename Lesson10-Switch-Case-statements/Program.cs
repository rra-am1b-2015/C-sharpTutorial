using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Switch_Case_statements
{
    

    class Program
    {
        enum mijnKleuren { Onbekend, Pimpelpaars, GeelRood, OranjeBruin };
        enum auto { Fiat, Mercedes, Audi, Ford, Volkswagen };

        static void Main(string[] args)
        {
            int getal = 10;

            auto autoMerk = auto.Fiat;

            mijnKleuren eigenKleur = mijnKleuren.Onbekend;

            Console.Title = "Lesson 10 Switch Case Statements";

            Console.Write("Geef uw lievelingskleur: ");

            string kleur = Console.ReadLine();

            /*
            if ( kleur == "paars")
            {
                Console.WriteLine("U lievelingskleur is paars");
            }
            else if ( kleur == "rood")
            {
                Console.WriteLine("U lievelingskleur is rood");
            }
            else if (kleur == "groen")
            {
                Console.WriteLine("U lievelingskleur is groen");
            }
            else if (kleur == "blauw")
            {
                Console.WriteLine("U lievelingskleur is blauw");
            }
            else if (kleur == "oranje")
            {
                Console.WriteLine("U lievelingskleur is oranje");
            }
            else
            {
                Console.WriteLine("Uw lievelingskleur is niet bekend....");
            }
            */


            switch ( kleur )
            {
                case "GeelRood":
                    eigenKleur = mijnKleuren.GeelRood;
                    break;
                case "OranjeBruin":
                    eigenKleur = mijnKleuren.OranjeBruin;
                    break;
                case "Pimpelpaars":
                    eigenKleur = mijnKleuren.Pimpelpaars;
                    break;
                default:
                    Console.WriteLine("De gekozen kleur is niet bekend bij de enum mijnKleuren");
                    break;
            }

            Console.WriteLine("De gekozen kleur is: {0}", eigenKleur.ToString() );


            // Is de kleur groen, rood, blauw of paarse schrijf naar het scherm
            // Uw lievelingskleur is groen groen, rood, blauw of paarse


            // Maak en enum genaamd auto met daarin de volgende merken: Ford, Mercedes, Fiat, Audi, Volkswagen
            // Maak een variabele autoMerk van het type enum auto.
            // Geef deze variabele een waarde auto.Fiat
            // Lees de waarde van autoMerk uit met een switch case. En echo welk merk gekozen is.

            switch ( autoMerk )
            {
                case auto.Audi:
                    Console.WriteLine("U heeft een {0}", autoMerk.ToString());
                    break;
                case auto.Fiat:
                    Console.WriteLine("U heeft een {0}", autoMerk.ToString());
                    break;
                case auto.Ford:
                    Console.WriteLine("U heeft een {0}", autoMerk.ToString());
                    break;
                case auto.Mercedes:
                    Console.WriteLine("U heeft een {0}", autoMerk.ToString());
                    break;
                case auto.Volkswagen:
                    Console.WriteLine("U heeft een {0}", autoMerk.ToString());
                    break;
                default:
                    Console.WriteLine("De door uw gekozen waarde is niet bekend in de enum");
                    break;
            }

            // Maak een enum genaamd weekdagen. weekdagen kan alle dagen van de week aannemen
            // Maak een variabele vandaag. Geef deze de waarde weekdagen.Vrijdag
            // Bekijk vandaag in een switch case en schrijf naar het scherm. Het is vandaag Vrijdag.
            Console.ReadKey();
        }
    }
}
