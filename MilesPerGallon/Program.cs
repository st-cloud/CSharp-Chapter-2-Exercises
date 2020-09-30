using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Miles driven:");
            string miles = Console.ReadLine();
            Console.WriteLine("Gallons of gas consumed:");
            string gallons = Console.ReadLine();

            double milesPerGallon = double.Parse(miles) / double.Parse(gallons);
            Console.WriteLine("Miles per gallon: " + milesPerGallon);
        }
    }
}
