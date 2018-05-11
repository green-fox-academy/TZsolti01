using System;

namespace MaterialReview5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfDoorsInACar = 5;
            int numberOfBuildingPart = 30_000;
            float price = 3_990_000.00f;
            bool permisson = true;
            char energyLevel = 'b';
            string brand = "Mercedes Benz";

            if (price < 1_000_000)
            {
                if (price < 0)
                {
                    Console.WriteLine("funny...");
                }
                else
                {
                    Console.WriteLine("Wow my Friend this is very cheap!");
                }
            }
            else if (price < 5_000_000)
            {
                Console.WriteLine("HMmmmm, maybe next year");
            }
            else if (price < 10_000_000)
            {
                Console.WriteLine("Don't you have some fancy discount for me?");
            }
            else
            {
                Console.WriteLine("You are very funny and not my Friend");
            }

            switch (energyLevel)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("This is very very eco");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Not so bad...");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("This means some discount, right?");
                    break;
                default:
                    Console.WriteLine("Thanks no!");
                    break;
            }

            for (int i = 0; i < brand.Length; i++)
            {
                if (brand[i] == 'e')
                {
                    Console.WriteLine("This is the letter we are looking for " + brand[i] + " this is the best letter");
                }
                else
                {
                    Console.WriteLine("This is not the letter we are looking for " + brand[i]);
                }
            }

            Console.ReadLine();
        }
    }
}