using System;

namespace MilesToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Can you give me a distance?");
            int distanceKm = int.Parse(Console.ReadLine());

            Console.WriteLine(distanceKm * 1.60);

            Console.ReadLine();
          
            Console.ReadLine();



        }
    }
}
