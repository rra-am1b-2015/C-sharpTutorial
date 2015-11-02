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
        private string naam = "geenNaam";
        private int leeftijd = 0;

        //Properties
        public int Leeftijd
        {
            set { this.leeftijd = value; }
        }

        public string Naam
        {
            set { this.naam = value; }
        }

        //Constructor
        public Begroeting()
        {
        }

        public Begroeting(string naam)
        {
            this.naam = naam;
        }

        public Begroeting(string naam, int leeftijd)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
        }

        // Methods
        public void gegroet()
        {
            Console.WriteLine("Ik vind jouw een toffe peer! " + this.naam + " voor je leeftijd ({0} jaar)",
                                this.leeftijd);
        }
    }
}
