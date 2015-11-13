using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maak een laptop class in een apart bestand
            // bedenk 5 relevante Fields
            // Maak de properties voor de Fields (get en set)
            // Maak een constructor die alle 5 de Fields kan initialiseren.
            // Maak een method die alle relevante gegevens weer kan geven in de console (ShowLaptopPropertiesConsole()).
            // Maak een laptop array met 5 objecten.
            // Roep met een foreach loop de method ShowLaptop() aan van alle objecten.
            // Schrijf de inhoud van het Laptops array naar een tekstbestand output.txt

            Console.Title = "Lesson 16 Classes Part 6";
            Laptop mijnLaptop = new Laptop("HP", 15.6f, "AMD A8", 8, video.NVIDIA_TEGRA);
            mijnLaptop.Brand = "LENOVO";
            mijnLaptop.ShowLaptopPropertiesConsole();

            Laptop[] laptops = new Laptop[5]
            {
                   new Laptop("HP", 15.6f, "AMD A8", 8, video.NVIDIA_TEGRA),
                   new Laptop("LENOVO", 11.3f, "INTEL", 16, video.AMD_FIREPRO),
                   new Laptop("ASUS", 21.0f, "NOBROWSKI", 32, video.AMD_RADEON),
                   new Laptop("MSI", 14.8f, "INSIT", 4, video.INTEL_HD_GRAPHICS),
                   new Laptop("APPLE", 7f, "TELMATIC", 2, video.NVIDIA_GEFORCE)
            };

            // Static aanroepen van een static method
            Laptop.ShowLaptops(laptops);

            Laptop.WriteToFile(laptops);

        Console.ReadKey();
        }
    }
}
