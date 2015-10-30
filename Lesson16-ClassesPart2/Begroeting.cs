using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart2
{
    class Begroeting
    {
        //Fields
        string naam = "Bertje";
        int leeftijd = 16;

        //Constructor
        public Begroeting()
        {
        }

        public Begroeting(string naam)
        {
            this.naam = naam;
        }

        // Methods
        public void gegroet()
        {
            Console.WriteLine("Ik vind jouw een toffe peer! " + this.naam + " voor je leeftijd ({0} jaar)",
                                this.leeftijd);
        }
    }
}
