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

            // Schrijf een programma dat vraagt om een onder- en bovengrens en vervolgens de getallen daartussen
            // Op het scherm schrijft.

            Console.WriteLine("Dit programma vraagt om een ondergrensgetal en een bovengrensgetal.");
            Console.WriteLine("Daarna worden de getallen tussen ondergrens en bovengrens op het scherm afgebeeld");
            Console.Write("\nGeef de ondergrens: ");

            string inleeswaarde = Console.ReadLine();
            int getal1 = Convert.ToInt32(inleeswaarde);

            Console.Write("\nGeef  een bovensgrens: ");
            inleeswaarde = Console.ReadLine();

            int getal2 = Convert.ToInt32(inleeswaarde);

            getal = getal1;

            while (getal >= getal1 && getal <= getal2)
            {
                Console.WriteLine(getal.ToString());
                getal++;
            }

            // Maak een programma dat vraagt om een getal te raden tussen de 0 en  20
            // Telkens als de speler het fout heeft wordt dit gemeld en wordt hem gevaagd om
            // een nieuwe waarde in te voeren. Dit gaat net zo lang door tot het getal geraden is

            Random random = new Random();
            int teRadenGetal = random.Next(0, 20);

            Console.WriteLine("Probeer een getal te raden tussen de 0 en de 20");
            Console.Write("Geef een getal tussen de 0 en 20: ");
            string invoer = Console.ReadLine();

            int waardeRaadGetal = Convert.ToInt32(invoer);
            int teller = 1;

            while ( waardeRaadGetal != teRadenGetal )
            {
                Console.Write("Het getal is niet geraden, geef een nieuw getal: ");
                invoer = Console.ReadLine();
                waardeRaadGetal = Convert.ToInt32(invoer);
                teller++;
            }
            Console.WriteLine("Gefeliciteerd u heeft het getal in {0} keer geraden.\n" + 
                                "Het was inderdaad {1}.", teller, teRadenGetal);
            
             



            Console.ReadKey();
        }
    }
}
