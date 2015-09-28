using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 11 De While Loop";

            int getal = 0;
            /*
            Console.WriteLine("0");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            */
            // Zolang de variabele getal kleiner of gelijk is aan 10 mag het worden geschreven naar het scherm

            while ( getal < 11 )
            {
                Console.WriteLine(Convert.ToString(getal));
                //getal = getal + 1;
                getal++;
                //getal += 1;
                //getal += 4;
            }

            getal = 10;

            while ( getal > 0 )
            {
                Console.WriteLine(getal.ToString());
                //getal = getal - 1;
                //getal--;
                getal -= 1;
                //getal -= 4;
            }





            Console.ReadKey();
        }
    }
}
