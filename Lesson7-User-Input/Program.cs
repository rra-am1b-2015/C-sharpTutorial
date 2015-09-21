using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson7-User-Input";

            /*
            // Vraag om invoer van de gebruiker
            Console.Write("Voer uw naam in: ");

            string invoer;

            invoer = Console.ReadLine();

            Console.WriteLine("Uw volledige naam is: {0}",invoer);
            

            // Maak een programma dat twee getallen vraagt aan de gebruiker en de som ervan uitrekend.

            Console.WriteLine("Dit programma berekend de som van twee getallen.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.Write("Geef de waarde van het eerste getal: ");

            string ingevoerdeTekst;
            int eersteGetal, tweedeGetal;
            long som;

            ingevoerdeTekst = Console.ReadLine();
            eersteGetal = Convert.ToInt32(ingevoerdeTekst);

            Console.Write("Geef de waarde van het tweede getal: ");

            ingevoerdeTekst = Console.ReadLine();
            tweedeGetal = Convert.ToInt32(ingevoerdeTekst);

            som = eersteGetal + tweedeGetal;

            Console.WriteLine("De som van {0} + {1} = {2}", 
                            Convert.ToString(eersteGetal), Convert.ToString(tweedeGetal), Convert.ToString(som));

            

            Console.WriteLine("========================================================");
            Console.WriteLine("Dit programma rekent de omtrek uit van een cirkel.");
            Console.WriteLine("Geef de straal van de cirkel (afstand middelpunt tot de cirkelrand)\nen het programma berekent de omtrek");
            Console.WriteLine("");
            Console.Write("Geef de straal van de cirkel: ");

            string inleesWaarde = Console.ReadLine();

            float straal = Convert.ToSingle(inleesWaarde);

            float omtrek = 2 * Convert.ToSingle(Math.PI) * straal;

            Console.WriteLine("De omtrek = 2 * {0} * {1} = {2}", Convert.ToString(Math.PI).ToString(),
                                    straal.ToString(), omtrek.ToString());
            Console.WriteLine("========================================================");

            */

            Console.WriteLine("Dit programma berekent de BMI (Body Mass Index");

            Console.Write("Geef uw lengte in meters: ");

            string invoer = Console.ReadLine();

            float lengteInMeters = Convert.ToSingle(invoer);

            Console.Write("Geef uw gewicht in kilogrammen: ");

            invoer = Console.ReadLine();

            float gewichtInKilogram = Convert.ToSingle(invoer);

            float bmi = gewichtInKilogram / (lengteInMeters * lengteInMeters);

            double bmiRounded = Math.Round(Convert.ToDouble(bmi), 1);

            Console.WriteLine("Uw BMI bedraagt op dit moment: {0}", bmiRounded.ToString());

            Console.ReadKey();
        }
    }
}
