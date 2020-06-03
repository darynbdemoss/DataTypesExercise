using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Miles Driven?");
            int mile = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Number of Gallons Consumed?");
            int gallons = Int32.Parse(Console.ReadLine());

            int mpg = mile / gallons;
            Console.WriteLine($"Your MPG for the trip was: {mpg}");
        }
    }
}
