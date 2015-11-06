using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart3
{
    class Rekenen
    {
        // Fields, klassevariabelen, classvariables
        private int getal1, getal2;

        // Properties
        public int Getal1
        {
            set { this.getal1 = value;  }
            get { return this.getal1; }
        }

        public int Getal2
        {
            set { this.getal2 = value; }
            get { return this.getal2;  }
        }


        // Constructors 
        public Rekenen()
        {
            this.getal1 = 0;
            this.getal2 = 0;
        }


        public Rekenen(int getal1, int getal2)
        {
            this.getal1 = getal1;
            this.getal2 = getal2;
        }

        // Methods
        public long Optellen()
        {
            long som = this.getal1 + this.getal2;
            return som;
        }

        public long Aftrekken()
        {
            long verschil = this.getal1 - this.getal2;
            return verschil;
        }

        public long Product()
        {
            long product = this.getal1 * this.getal2;
            return product;
        }

        public float Quotient()
        {
            float quotient = (float)this.getal1 / this.getal2;
            return quotient;
        }

        public int Modulus()
        {
            int modulus = this.getal1 % this.getal2;
            return modulus;
        }

        public void Totaal()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("De som van {0} + {1} = {2}", this.getal1, this.getal2, this.Optellen());
            Console.WriteLine("Het product van {0} * {1} = {2}", this.getal1, this.getal2, this.Product());
            Console.WriteLine("Het verschil van {0} - {1} = {2}", this.getal1, this.getal2, this.Aftrekken());
            Console.WriteLine("Het quotient van {0} / {1} = {2}", this.getal1, this.getal2, this.Quotient());
            Console.WriteLine("De modulus van {0} % {1} = {2}", this.getal1, this.getal2, this.Modulus());
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }
    }
}
