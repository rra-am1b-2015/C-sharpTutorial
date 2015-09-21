using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 6 Basic Math";

            int getal1, getal2;
            float som, verschil, product, quotient, modulo;
            // product * en quotient /

            getal1 = 106;
            getal2 = 7;

            // optellen +
            som = getal1 + getal2;
            // verschil -
            verschil = getal1 - getal2;
            //product *
            product = getal1 * getal2;
            //quotient /
            quotient = getal1 / getal2;

            // Modulo %
            modulo = getal1 % getal2;

            Console.WriteLine("De som van {0} + {1} = {2}", getal1, getal2, som);
            Console.WriteLine("Het verschil van {0} - {1} = {2}", getal1, getal2, verschil);
            Console.WriteLine("Het product van {0} x {1} = {2}", getal1, getal2, product);
            Console.WriteLine("Het quotient van {0} : {1} = {2}", getal1, getal2, quotient);
            Console.WriteLine("De modulo van {0} % {1} = {2}", getal1, getal2, modulo);

            int a = 5;
            a++;
            Console.WriteLine("Wanneer a = 5 is en je hoogt het op met ++ dan is de uitkomst: " + a);

            int b = 6;
            b--;
            Console.WriteLine("Wanneer b = 6 is en je verlaagt het met -- dan is de uitkomst: " + b);

            int c = 2;
            c += 3;  // Is hetzelfde als c = c + 3
            Console.WriteLine("Wanneer c= 2 en je schrijft c += 3,  dan wordt er 3 bij c opgetelt " + c);


            Console.ReadKey();
        }
    }
}
