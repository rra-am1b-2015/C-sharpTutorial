using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Het winnende getal is 1
            Console.Title = "Lesson 9 Decision Making";

            Console.WriteLine("Keuzemenu:\n" +
                              "----------\n\n" + 
                              "- kies A voor het spelen van een raadspelletje.\n" +
                              "- kies B voor het berekenen van uw BMI (Body Mass Index)\n" +
                              "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n\n");

            Console.Write("Geef nu uw keuze: ");

            string keuzeInvoer = Console.ReadLine();

            char gekozenLetter = Convert.ToChar(keuzeInvoer);

            if (//test gekozenLetter)
            {
                //Zet hier alle code m.b.t. het raadspelletje
            }
            else if (// test gekozenLetter)
            {
                // Zet hier alle code voor de BMI Berekening

            }
            else
            {
                // Zeg hier wat je gaat doen als de keuze niet A of B is.
            }


            Console.WriteLine("Geef een getal tussen de 1 en de 5.\n" +
                              "U heeft een kans om het goede getal te raden.\n" +
                              "Choose wiseley.........");
            Console.Write("Geef het getal van uw keuze: ");

            string invoer = Console.ReadLine();

            byte gekozenGetal = Convert.ToByte(invoer);

            if (gekozenGetal == 1)
            {
                Console.WriteLine("U heeft gekozen voor {0}. Gefeliciteerd dit is het winnende getal.\n" + 
                                  "U gaat naar Hawai", gekozenGetal);
            }
            else if (gekozenGetal == 0)
            {
                Console.WriteLine("U heeft gekozen voor {0}. Gefeliciteerd dit is ook het winnende getal.\n" +
                                  "U gaat naar Texel", gekozenGetal);
            }
            else if (gekozenGetal == 4)
            {
                Console.WriteLine("U heeft gekozen voor {0}. Gefeliciteerd, dit is ook een winnend getal,\n " + 
                                  "u gaat naar Terschelling",gekozenGetal );
            }
            else
            {
                Console.WriteLine("U heeft gekozen voor {0}. Dit is niet het winnende getal. Helaas,\n" + 
                                  "volgende keer beter.", gekozenGetal);
            }



            Console.WriteLine("\n\nDit programma berekent de BMI (Body Mass Index)");

            Console.Write("Geef uw lengte in meters: ");

            invoer = Console.ReadLine();

            float lengteInMeters = Convert.ToSingle(invoer);

            Console.Write("Geef uw gewicht in kilogrammen: ");

            invoer = Console.ReadLine();

            float gewichtInKilogram = Convert.ToSingle(invoer);

            float bmi = gewichtInKilogram / (lengteInMeters * lengteInMeters);

            double bmiRounded = Math.Round(Convert.ToDouble(bmi), 1);

            Console.WriteLine("Uw BMI bedraagt op dit moment: {0}", bmiRounded.ToString());

            if ( bmiRounded < 18.5 )
            {
                Console.WriteLine("U heeft een BMI van {0}, U heeft ondergewicht", bmiRounded);
            }
            else if ( bmiRounded >= 18.5  &&   bmiRounded < 25 )
            {
                Console.WriteLine("U heeft een BMI van {0}, U heeft normaal gewicht", bmiRounded);
            }
            else if ( bmiRounded >= 25 && bmiRounded < 27 )
            {
                Console.WriteLine("U heeft een BMI van {0}, U heeft licht overgewicht", bmiRounded);
            }
            else if ( bmiRounded >= 27 && bmiRounded < 30 )
            { 
                Console.WriteLine("U heeft een BMI van {0}, U heeft matig overgewicht", bmiRounded);
            }
            else if ( bmiRounded >= 30 && bmiRounded < 40 )
            {
                Console.WriteLine("U heeft een BMI van {0}, U heeft ernstig overgewicht", bmiRounded);
            }
            else
            {
                Console.WriteLine("U heeft een BMI van {0}, U heeft ziekelijk overgewicht", bmiRounded);
            }



            Console.ReadKey();


        }
    }
}
