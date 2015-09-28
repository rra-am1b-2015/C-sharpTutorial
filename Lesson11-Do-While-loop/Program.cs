using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Do_While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 11 Do While";

            // Schrijf een programma die vraagt om een getal en uitrekend tot welke macht dit getal moet worden genomen
            // Om boven de 1000000 uit te komen. Gebruik een Do While Loop. 

            // Dit programma rekent uit tot welke macht een opgegeven getal moet worden genomen om
            // boven de 1 miljoen te komen
            // Geef een willekeurig geheel getal: 3
            // U moet 3 tot de macht 101 nemen om boven 100000 uit te komen.

            Console.Write("Dit programma rekent uit tot welke macht een opgegeven getal\n" +
                                "moet worden genomen om boven de 1 miljoen te komen.\n" +
                                "Geef een willekeurig geheel getal: ");
            string invoer = Console.ReadLine();


            int getal = Convert.ToInt32(invoer);
            int macht = 1;

            int berekendeWaarde = 1;
            do
            {
                berekendeWaarde = berekendeWaarde * getal;
                macht++;
            }
            while (berekendeWaarde < 1000000);
            Console.WriteLine("{0} tot de macht {1} is de eerste macht die boven de 1000000 uitkomt.\n" + 
                                "De uitkomst is namelijk: {2}", getal.ToString(), (macht-1).ToString(), berekendeWaarde.ToString());

            Console.ReadKey();
        }
    }
}
