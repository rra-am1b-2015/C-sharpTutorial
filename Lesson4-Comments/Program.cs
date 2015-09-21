using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Comments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Met Console.Writeline() kun je tekst op je console-scherm zetten.

            // Commentaar regel1
            // Commentaar regel2
            // Commentaar regel3

            /* **************************************
             * Dit is een commentaar regel          *
             * Dit is ook een commentaarregel       *
             * Dit is een andere commentaarregel    *
             ****************************************/
            Console.WriteLine("Dit is een project over commentaar in je code"); // Console.WriteLine() zorgt ook voor een nieuwe regel
            Console.WriteLine("Nog wat interessante tekst"); /* Commentaar voor het verduidelijken */
            //Console.Writeline("Dit stukje code is uitgecommentarieerd door commentaar slashes");
            Console.ReadKey();
        }
    }
}
