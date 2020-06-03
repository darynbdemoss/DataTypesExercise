using System;

namespace NumericValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the area of rectangle program");
            Console.WriteLine("Length: ");
            int length = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            int width = Int32.Parse(Console.ReadLine());

            int area = length * width;

            Console.WriteLine($"The area of the rectangle is : {area}");
        }
    }
}
