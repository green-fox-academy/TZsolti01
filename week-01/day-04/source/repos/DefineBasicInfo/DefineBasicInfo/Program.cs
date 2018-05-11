using System;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            string name = "Zsolti";
            int age = 26;
            double height = 1.80;
            bool running = false;

            Console.WriteLine("What is your name? " +name);
            Console.WriteLine("How old are you? " +age);
            Console.WriteLine("How long are you? " +height +"m");
            Console.WriteLine("Are you married? " +running);

            Console.ReadLine();
            
        }
    }
}
