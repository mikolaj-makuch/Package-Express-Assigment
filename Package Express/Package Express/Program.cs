using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight >= 51)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is your package width?");
            }
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width + height + length > 51)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                double total = (width + height + length) * weight / 100.0;
                string cost = "Your estimated total for shipping this package is: $";
                Console.WriteLine(cost + total);
            }
            Console.ReadLine();
        }
    }
}
