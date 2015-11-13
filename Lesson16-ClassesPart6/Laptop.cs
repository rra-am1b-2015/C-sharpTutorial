using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart6
{
    enum video { AMD_RADEON, INTEL_HD_GRAPHICS, NVIDIA_GEFORCE, NVIDIA_TEGRA, AMD_FIREPRO };

    class Laptop
    {
        //Fields
        private string brand;
        private float displayDiagonal;
        private string processor;
        private int internalMemory;
        private video card;

        //Properties
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public float DisplayDiagonal
        {
            get { return this.displayDiagonal; }
            set { this.displayDiagonal = value; }
        }
        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public int InternalMemory
        {
            get { return this.internalMemory; }
            set { this.internalMemory = value; }
        }
        public video Card
        {
            get { return this.card; }
            set { this.card = value; }
        }

        //Constructor
        public Laptop(string brand, float displayDiagonal, string processor, int internalMemory, video card)
        {
            this.brand = brand;
            this.displayDiagonal = displayDiagonal;
            this.processor = processor;
            this.internalMemory = internalMemory;
            this.card = card;
        }

        //Methods
        public void ShowLaptopPropertiesConsole()
        {
            Console.WriteLine("\r\n++++++++++++++++++++++++++++++++++++++++++++++++++\r\n" +
                              "Het merk is:\t\t\t{0}\r\n" +
                              "De beeldscherm diagonaal is:\t{1} INCH\r\n" +
                              "De processor is:\t\t{2}\r\n" +
                              "Grootte interngeheugen:\t\t{3}\r\n" +
                              "Type videokaart:\t\t{4}\r\n" +
                              "++++++++++++++++++++++++++++++++++++++++++++++++++\r\n", 
                              this.brand, 
                              this.displayDiagonal,
                              this.processor,
                              this.internalMemory,
                              this.card);
        }

        public static void ShowLaptops(Laptop[] laptops)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                laptops[i].ShowLaptopPropertiesConsole();
            }
        }

        public static void WriteToFile(Laptop[] laptops)
        {
            string dir = Directory.GetCurrentDirectory();
            string outputDir = dir + @"\output";
            Directory.CreateDirectory(outputDir);
            string output = "";
            for( int i = 0; i < laptops.Length; i++ )
            {
                output += string.Format("\r\n++++++++++++++++++++++++++++++++++++++++++++++++++\r\n" +
                                        "Het merk is:\t\t\t{0}\r\n" +
                                        "De beeldscherm diagonaal is:\t{1} INCH\r\n" +
                                        "De processor is:\t\t{2}\r\n" +
                                        "Grootte interngeheugen:\t\t{3}\r\n" +
                                        "Type videokaart:\t\t{4}\r\n" +
                                        "++++++++++++++++++++++++++++++++++++++++++++++++++\r\n",
                                        laptops[i].Brand,
                                        laptops[i].DisplayDiagonal,
                                        laptops[i].Processor,
                                        laptops[i].InternalMemory,
                                        laptops[i].Card);
            }
           
            File.WriteAllText(outputDir + @"\test.txt", output );
            Console.WriteLine("{0}", "Hallo");
        }
    }
}
