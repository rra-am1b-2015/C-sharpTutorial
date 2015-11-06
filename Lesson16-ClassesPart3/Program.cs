using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 16 Classes Part 3";
            Rekenen berekening = new Rekenen(5, 12);
            berekening.Getal1 = 3;
            berekening.Getal2 = 34;
            Console.WriteLine("De som van {0} + {1} = {2}", berekening.Getal1, berekening.Getal2, berekening.Optellen());
            Console.WriteLine("Het product van {0} * {1} = {2}",berekening.Getal1, berekening.Getal2, berekening.Product());
            Console.WriteLine("Het verschil van {0} - {1} = {2}", berekening.Getal1, berekening.Getal2, berekening.Aftrekken());
            Console.WriteLine("Het quotient van {0} / {1} = {2}", berekening.Getal1, berekening.Getal2, berekening.Quotient());
            Console.WriteLine("De modulus van {0} % {1} = {2}", berekening.Getal1, berekening.Getal2, berekening.Modulus());

            berekening.Totaal();

            // Maak van elke method een overload die twee floats als argument meekrijgt.
            Console.ReadKey();
        }
    }
}
