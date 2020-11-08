using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPostcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de postcode in");
            string line = new String('*', 25);
            Console.WriteLine(line);
            int[] postCode = { 1000, 2000, 3000, 4000, 5000, 6000 };
            string[] stad = { "Brussel", "Antwerpen", "Bergen", "Aalst", "Ninove", "Dilbeek" };
            int value = int.Parse(Console.ReadLine());
            int pos = Array.IndexOf(postCode, value);
            Console.WriteLine($"De stad van die postcode is: {stad[pos]}");
        }
    }
}
