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
        
        static void Main(string[] args)
        {
            enum auto { Fiat, Mercedes };

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
            Console.ReadKey();
        }
    }
}
