using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle length (cm):");
            string length = Console.ReadLine();
            Console.WriteLine("Enter rectangle width (cm):");
            string width = Console.ReadLine();

            double area = double.Parse(length) * double.Parse(width);
            Console.WriteLine("Area of Rectangle: " + area + " cm");
        }
    }
}
