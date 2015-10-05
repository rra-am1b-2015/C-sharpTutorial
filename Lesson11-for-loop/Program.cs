using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 11 For loop";

            for (int i = 0; i <= 10; i = i + 1)
            {
                Console.WriteLine("Dit is een for loop! Aantal keren dat dit" + 
                                    " codeblok is uitgevoerd: {0}", i.ToString());
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            // Schrijf de getallen 10 t/m 0 op het scherm aflopend. Doe dit zonder in het codeblok te veranderen
            for( int i = 10; i >= 0; i = i - 1)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            // Schrijf de getallen 10 t/m 0 op het scherm aflopend. Doe dit zonder in het codeblok te veranderen
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            // Schrijf de getallen 10 t/m 0 op het scherm aflopend. Doe dit zonder in het codeblok te veranderen
            for (int i = 10; i >= 0; i -= 1)
            {
                Console.WriteLine("{0}", i);
            }


            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            // Schrijf de getallen van 0 t/m 10 op de console oplopend met stapjes van 4.
            // Doe dit zonder wijzigingen aan te brengen in het codeblok

            for ( int j = 0; j <= 10; j += 4)
            {
                Console.WriteLine("{0}", j.ToString());
            }

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            // Vraag de gebruiker om een getal en geef dan van dit getal de tafel weer van 0 t/m 20. Gebruik
            // een for-loop.
            Console.Write("Geef een getal waarvan de tafel op het scherm moet komen: ");

            string invoer = Console.ReadLine();

            int getal = Convert.ToInt32(invoer);

            Console.Write("Tot welk getal moet de tafel worden weergegeven : ");

            invoer = Console.ReadLine();

            int aantalTafelRegels = Convert.ToInt32(invoer);

            Console.WriteLine("Hier komt de tafel van {0}. Let op! om bijgeloofredenen wordt de regel met 13 niet uitgevoerd", getal);
            for ( int i = 0; i <= aantalTafelRegels; i++ )
            {
                if ( i == 13 )
                {
                    break;
                }
                long product = i * getal;
                Console.WriteLine("{0}\tx\t{1} =  {2}", i.ToString(), getal, product);
            }

            // Breidt bovenstaande applicatie uit zodat er ook gevraagd wordt tot hoever de tafel moet weergegeven
            // worden.


            Console.ReadKey();
        }
    }
}
