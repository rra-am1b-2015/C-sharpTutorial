﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Enumerations
{
   

    class Program
    {
        enum ijsSoorten { aardbei = 3, chocolade = 2, citroen = 0, malaga = 1, meloen = 6, stracciatella = 5, mango = 7, perzik = 4 };
        enum koffiedranken { cappucino, espresso, koffie, lattemachiato, koffieverkeerd, dubbeleespresso, lungo };
        enum slagroom { met, zonder};

        static void Main(string[] args)
        {
            Console.Title = "Enumerations";


            


            //string ijsSoorten = "gemalen bladluis";

            ijsSoorten ijsSmaak;
            koffiedranken koffie = koffiedranken.cappucino;

            ijsSmaak = ijsSoorten.citroen;

            Console.WriteLine("Ik heb vandaag heerlijk {0}-ijs gegeten. Het was fantastisch van smaak", ijsSmaak);

            for ( int i = 0; i < 8; i++)
            {
                Console.WriteLine("Waardenummer {0} van de enumeration ijsSoorten heeft de waarde {1}", i, ijsSmaak );
                ijsSmaak = ijsSmaak + 1;
            }

            // Maak een programma dat je mening vraagt over alle ijssmaken in de enumeration. Gebruik daarbij een for-loop.
            // De antwoorden worden opgeslagen in een string[] meningOverIjsSmaak array. Alle antwoorden worden aan het einde achter elkaar 
            // weergegeven in de vorm:
            // Ik vind {ijsSoort}: {meningOverIjsSmaak}

            Console.Clear();
            ijsSmaak = ijsSoorten.citroen;
            string[] meningen = new string[8];

            /*
            Console.WriteLine("Geef uw mening over de onderstaande ijssmaken\n" + 
                              "druk op een willekeurige toets om verder te gaan...");
            Console.ReadKey();

            for ( int i = 0; i < 8; i++)
            {
                Console.WriteLine("Geef uw mening over de ijssoort {0}:", ijsSmaak);
                string invoer = Console.ReadLine();
                meningen[i] = invoer;
                ijsSmaak++;
            }

            ijsSmaak = ijsSoorten.citroen;
            for ( int i = 0; i < 8; i++)
            {
                Console.WriteLine("Uw mening over {0}-ijs is: {1}", ijsSmaak, meningen[i]);
                ijsSmaak++;

            }
            */

            // Maak een enum die verschillende koffiedranken bevat zoals: cappucino, 
            // espresso, koffie, latte machiato, koffie verkeerd, dubbele espresso, longo
            // Schrijf een programma dat vraagt om een voornaam. Sla dit op in een array voornaam.
            // Vraag daarna watvoor soort koffie deze persoon wil hebben. Maak ook een enum metOfZonderSlagroom. Deze
            // heeft de waarde { met, zonder }. Vraag ook of deze persoon met of zonder slagroom wil en sla dit op
            // In een array slagroom. Daarna voor elke persoon weer welke koffie hij/zij wil en met of zonder slagroom
            // Dit alles voor 10 personen.

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("Dit programma is ontwikkeld voor kelners met een slecht geheugen. Vraag om een voornaam\n" +
                                "koffiedrank en of de persoon die bestelt slagroom wil.\n" + 
                                "druk op de een toets om verder te gaan...");
            string[] voornaam = new string[10];
            koffiedranken[] drankje = new koffiedranken[10];
            slagroom[] room = new slagroom[10];

            Console.ReadKey();
            do
            {
                Console.Write("Geef uw voornaam: ");
                string invoer = Console.ReadLine();
                string naam = invoer;
                Console.WriteLine("Welke koffie wilt u: ");
                for (int i = 1; i < 8; i++ )
                {
                    Console.WriteLine("{0} {1}", i, koffie);
                    koffie++;
                }
                Console.WriteLine("Maak uw keuze door het invoeren van een nummer: ");
                invoer = Console.ReadLine();
                int getal = Convert.ToInt32(invoer);
                switch (getal)
                {
                    case 1:


                }



            } while(true);

            Console.ReadKey();
        }
    }
}
