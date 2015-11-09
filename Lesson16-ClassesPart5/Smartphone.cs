using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart5
{
    enum OperatingSystem { Android, iOS, BlackberryOs, WindowsPhone };

    class Smartphone
    {
        // Fields
        string brand = "Samsung";
        float price = 0.00f;
        OperatingSystem operatingSystem = OperatingSystem.Android;
        string versionOS = "Lollipop";
        short memoryCapacity = 4;
        
        // Properties
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public OperatingSystem OperatingSystem
        {
            get { return this.operatingSystem; }
            set { this.operatingSystem = value; }
        }
        public string VersionOs
        {
            get { return this.versionOS; }
            set { this.versionOS = value; }
        }
        public short MemoryCapacity
        {
            set { this.memoryCapacity = value; }
            get { return this.memoryCapacity; }
        }

        // Constructor
        public Smartphone(string brand, float price, OperatingSystem operatingSystem, string versionOS, short memoryCapacity)
        {
            this.brand = brand;
            this.price = price;
            this.operatingSystem = operatingSystem;
            this.versionOS = versionOS;
            this.memoryCapacity = memoryCapacity;
        }

        public void ShowSmartphoneProps()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++\n" +
                              "Het merk is\t\t\t: {0}\n" +
                              "De prijs is\t\t\t: {1}\n" +
                              "Het besturingssysteem is\t: {2}\n" +
                              "De versie van het OS is\t\t: {3}\n" +
                              "De grote van het geheugen is\t: {4}\n" +
                              "+++++++++++++++++++++++++++++++++++++++++++++++\n", 
                                  this.brand,
                                  this.price,
                                  this.operatingSystem,
                                  this.versionOS,
                                  this.memoryCapacity);
        }

        public string ShowSmartphoneInfoText()
        {
            string infoText = string.Format("+++++++++++++++++++++++++++++++++++++++++++++++\n" +
                                            "Het merk is\t\t\t: {0}\n" +
                                            "De prijs is\t\t\t: {1}\n" +
                                            "Het besturingssysteem is\t: {2}\n" +
                                            "De versie van het OS is\t\t: {3}\n" +
                                            "De grote van het geheugen is\t: {4}\n" +
                                            "+++++++++++++++++++++++++++++++++++++++++++++++\n",
                                            this.brand,
                                            this.price,
                                            this.operatingSystem,
                                            this.versionOS,
                                            this.memoryCapacity);
            return infoText;
        }

        // Methods
    }
}
