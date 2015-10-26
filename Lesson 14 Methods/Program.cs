using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 14 Methods";

            for (int i = 0; i < 100; i++)
            {
                //groeten();
            }

            groeten(100, "de heer","de Ruijter");
            groeten(2, "de heer", "Odijk");
            groeten(1200, "mevrouw", "Hombergh");

            // Maak een method die twee string argumenten heeft en deze aan elkaar plakt.

            Console.WriteLine("Dit is de aan elkaar geplakte string: {0}", plakString("Hallo", " en dag"));

            // Maak een method die twee getallen (integer getallen) bij elkaar optelt. Zorg voor de veiligheid dat de som van het type long is.
            int getal1 = 12;
            int getal2 = 34;

            Console.WriteLine("De som van {0} + {1} = {2}", getal1, getal2, optellen(getal1 , getal2));

            Console.WriteLine("Het product van {0} x {1} = {2}", getal1, getal2, vermenigvuldigen(getal1, getal2));

            float getal3 = 3.14f;
            float getal4 = 3.24f;

            Console.WriteLine("Het quotient van {0} x {1} = {2}", getal3, getal4, delen(getal3, getal4));
            Console.WriteLine("De modulus van {0} x {1} = {2}", getal1, getal2, modulus(getal1, getal2));
            Console.WriteLine("Het verschil van {0} x {1} = {2}", getal1, getal2, aftrekken(getal1, getal2));

            Console.WriteLine("{0}", sorteerGetallen());
            Console.ReadKey();
        }

        static void groeten(int aantal, string geslacht, string naam)
        {
            Console.WriteLine("{0} x felicitaties van {1} {2}", aantal, geslacht, naam);
        }

        static string plakString(string string1, string string2)
        {
            string nieuweString = string1 + string2;
            return nieuweString;
        }

        static long optellen(int getal1, int getal2)
        {
            long som = getal1 + getal2;
            return som;
        }

        static float vermenigvuldigen(int getal1, int getal2)
        {
            float product = getal1 * getal2;
            return product;
        }

        // Maak een method die twee integer getallen deelt en waarvan de uitkomst een double is.
        // Maak een method die de modulus berekent van twee integer getallen.
        // Maak een method die twee integer getallen van elkaar aftrekt en als uitkomst een getal van het type long heeft.
        // Maak een method die vraagt om 5 getallen. Na het het laatste getal zet de method de ingevoerde waarden aflopend achter elkaar, komma gescheiden. 
        // Tip gebruik een bestaande array method voor het sorteren.
        
        static double delen(int getal1,  int getal2)
        {
            double quotient = getal1 / getal2;
            return quotient;
        }

        static double delen(float getal1, float getal2)
        {
            double quotient = getal1 / getal2;
            return quotient;
        }

        static float delen(float getal1, int getal2)
        {
            float quotient = getal1 / getal2;
            return quotient;
        }

        static int modulus(int getal1, int getal2)
        {
            int mod = getal1 % getal2;
            return mod;
        }

        static long aftrekken(int getal1, int getal2)
        {
            Int64 verschil = getal1 - getal2;
            return verschil;
        }


        static string sorteerGetallen()
        {
            Console.WriteLine("Deze app vraagt om 5 getallen en zet deze in aflopende volgorde op het scherm");

            int teller = 0;
            int[] getallen = new int[5];
            while (teller < 5)
            {
                Console.Write("Geef getal nr: {0} => ", teller);
                string invoer = Console.ReadLine();
                getallen[teller] = Convert.ToInt32(invoer);
                teller++;
            }
            Array.Sort(getallen);
            Array.Reverse(getallen);
            string aflopend = "";
            for (int i = 0; i < 5; i++)
            {
                aflopend += getallen[i] + " ";
            }
            return "De getallen in aflopende volgorde zijn: " + aflopend;
        }
    }
}
