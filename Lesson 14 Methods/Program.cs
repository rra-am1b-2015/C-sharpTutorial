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


            Console.ReadKey();
        }

        static void groeten(int aantal, string geslacht, string naam)
        {
            Console.WriteLine("{0} x felicitaties van {1} {2}", aantal, geslacht, naam);
        }
    }
}
