using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart4
{
    class Auto
    {
        //Fields
        private string carBrand = "Nog geen merk gekozen";
        private string type = "Nog geen type gekozen";
        private short amountOfDoors = 5;

        // Properties
        public string CarBrand
        {
            get { return this.carBrand; }
            set
            {
                if (value == "Volkswagen")
                {
                    this.carBrand = "Volkswagen (frauduleuze software)";
                }
                else
                {
                    this.carBrand = value;
                }
            }
        }

        //Constructor


        //Methods
    }
}
