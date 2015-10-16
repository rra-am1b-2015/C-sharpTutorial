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

            Console.WriteLine("Dit is de aan elkaar geplakte string: {0}", plakString("Hallo", "en dag"));


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


    }
}
