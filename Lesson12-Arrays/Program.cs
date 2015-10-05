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
                Console.WriteLine("Mijn gewicht was {0}: {1}`kg", dagenVanDeWeek[i], lichaamsgewicht[i]);
            }

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");








            Console.WriteLine("Mijn lichaamsgewicht eergisteren was: {0} kg", lichaamsgewicht2);
            Console.WriteLine("Mijn lichaamsgewicht was gisteren: {0} kg", lichaamsgewicht1);
            Console.WriteLine("Mijn huidige lichaamsgewicht is: {0} kg", lichaamsgewicht0);



            Console.ReadKey();
        }
    }
}
