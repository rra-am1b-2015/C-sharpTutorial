using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 5 - Variables";
            Console.BackgroundColor = ConsoleColor.White;           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            // Declareer de variabele
            string voornaam;
            string tussenvoegsel, achternaam;

            byte leeftijd;

            char eersteLetter;

            eersteLetter = 'A';

            // Geef de gedeclareed
            voornaam = "Arjan";
            tussenvoegsel = "de";
            achternaam = "Ruijter";
            leeftijd = 47;
            string tekst = "De eerste letter van mijn voornaam is {0} en \ndat is ook de eerste letter van het alfabet";

            // real numbers of floating point numbers
            float pi = 3.1415f;
            double grootGetal = 12.1235678d;
            decimal nogGroterGetal = 12.435267890M;

            bool waarOfNiet = true;
            waarOfNiet = false;


            Console.WriteLine("Mijn volledige naam is: " + voornaam + " " + tussenvoegsel + " " + achternaam + " en ik ben " + leeftijd + " jaar oud");
            Console.WriteLine("Mijn volledige naam is: {0} {1} {2} en ik ben {3} jaar oud", voornaam, tussenvoegsel, achternaam, leeftijd );
            Console.WriteLine(tekst, eersteLetter);
            Console.ReadKey();
        }
    }
}
