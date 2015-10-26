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
        

    }
}
