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
        private color carColor = color.Marshmellowyellow;
        private float fuelConsumption;
        

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
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public short AmountOfDoors
        {
            get { return this.amountOfDoors; }
            set { this.amountOfDoors = value; }
        }
        public color CarColor
        {
            set { this.carColor = value; }
            get { return this.carColor; }
        }
        public float FuelConsumption
        {
            set { this.fuelConsumption = value; }
            get { return this.fuelConsumption; }
        }

        //Constructor
        public Auto()
        {

        }

        public Auto(string carBrand, string type, short amountOfDoors, color carColor, float fuelConsumption)
        {
            this.carBrand = carBrand;
            this.type = type;
            this.amountOfDoors = amountOfDoors;
            this.carColor = carColor;
            this.fuelConsumption = fuelConsumption;
        }

        //Methods
        public void ShowCarProperties()
        {
            Console.WriteLine("\n**********************************************\n" +
                               "Merk:\t\t\t{0}\n" +
                               "Type:\t\t\t{1}\n" +
                               "Aantal deuren:\t\t{2}\n" +
                               "Kleur van de auto:\t{3}\n" +
                               "Brandstofverbruik is:\t{4} L/100km\n" +
                               "**********************************************\n",
                               this.carBrand,
                               this.type,
                               this.amountOfDoors,
                               this.carColor,
                               this.fuelConsumption);
        }
    }
}
