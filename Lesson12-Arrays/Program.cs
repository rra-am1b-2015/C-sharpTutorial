using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 12 Array's";

            int lichaamsgewicht0, lichaamsgewicht1, lichaamsgewicht2;
            lichaamsgewicht0 = 78;
            lichaamsgewicht1 = 77;
            lichaamsgewicht2 = 79;

            int[] lichaamsgewicht;

            lichaamsgewicht = new int[7];

            int[] bodymass = new int[7];

            // Array's zijn zero based. 
            lichaamsgewicht[0] = 45;
            lichaamsgewicht[1] = 67;
            lichaamsgewicht[2] = 34;
            lichaamsgewicht[3] = 78;
            lichaamsgewicht[4] = 67;
            lichaamsgewicht[5] = 45;
            lichaamsgewicht[6] = 85;

            lichaamsgewicht = new int[] { 23, 45, 67, 89, 99, 12, 33 };

            string[] dagenVanDeWeek = new string[] { "maandag",
                                                     "dinsdag",
                                                     "woensdag",
                                                     "donderdag",
                                                     "vrijdag",
                                                     "zaterdag",
                                                     "zondag"};

            Console.WriteLine("Mijn gewicht was maandag {0}", lichaamsgewicht[0]);
            Console.WriteLine("Mijn gewicht was dinsdag: {0}", lichaamsgewicht[1]);
            Console.WriteLine("Mijn gewicht was woensdag: {0}", lichaamsgewicht[2]);
            Console.WriteLine("Mijn gewicht was donderdag: {0}", lichaamsgewicht[3]);
            Console.WriteLine("Mijn gewicht was vrijdag: {0}", lichaamsgewicht[4]);
            Console.WriteLine("Mijn gewicht was zaterdag: {0}", lichaamsgewicht[5]);
            Console.WriteLine("Mijn gewicht was zondag: {0}", lichaamsgewicht[6]);

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            for ( int i = 0; i < 7; i = i + 1)
            {
                Console.WriteLine("Mijn gewicht was {0}: {1} kg", dagenVanDeWeek[i], lichaamsgewicht[i]);
            }

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("Mijn lichaamsgewicht eergisteren was: {0} kg", lichaamsgewicht2);
            Console.WriteLine("Mijn lichaamsgewicht was gisteren: {0} kg", lichaamsgewicht1);
            Console.WriteLine("Mijn huidige lichaamsgewicht is: {0} kg", lichaamsgewicht0);

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            // Schrijf een programma dat vraagt om een lengte in meter.
            // Gebruik deze ingevoerde lengte en het lichaamsgewicht array om een nieuw
            // array met de naam BMI te vullen met berekende BMI waarden.

            // BMI = gewicht (kg) / (lengte (m) x lengte (m))

            // Gebruik hiervoor een for-loop

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("Geef uw lengte in meters:");

            string invoer = Console.ReadLine();

            float lengte = Convert.ToSingle(invoer);

            float[] bmi = new float[7];

            for ( int i = 0; i < bmi.Length; i++ )
            {
                bmi[i] = (float)Math.Round(lichaamsgewicht[i] / (lengte * lengte), 1);  // Bereken hier een bmi
                //Console.WriteLine("Ik heb het volgende getal ingevoerd: {0}", bmi[i]);
            }

            // Schrijf naar het scherm:
            // Mijn gewicht was {0}(maandag) {1}{78} kg, mijn bmi is dan {2} {30}. Mijn lengte is: {3} {1,8}

            float totaalGewicht = 0;
            float minValue = Int32.MaxValue;
            float maxValue = 0;
            for (int i = 0; i < bmi.Length; i++)
            {
                Console.WriteLine("Mijn gewicht was {0} {1} kg, mijn bmi is dan {2}. Mijn lengte is: {3}",
                                    dagenVanDeWeek[i], lichaamsgewicht[i], bmi[i], lengte);
                // Bereken gemiddelde gewicht.
                totaalGewicht = totaalGewicht + lichaamsgewicht[i];

                if ( lichaamsgewicht[i] < minValue)
                {
                    minValue = lichaamsgewicht[i];
                    Console.WriteLine("Nog lager {0}", minValue);
                }

                if (lichaamsgewicht[i] > maxValue)
                {
                    maxValue = lichaamsgewicht[i];
                    Console.WriteLine("Nog hoger {0}", minValue);
                }

            }
            Console.WriteLine("Mijn gemiddelde gewicht deze week was: {0}", totaalGewicht/bmi.Length );
            Console.WriteLine("Mijn laagste gewicht deze week was: {0}", minValue);
            Console.WriteLine("Mijn hoogste gewicht deze week was: {0}", maxValue);

            Console.ReadKey();
        }
    }
}
