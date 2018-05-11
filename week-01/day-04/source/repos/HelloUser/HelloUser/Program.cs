using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user

            Console.Write("Hello user what is your name? ");
            string name = Console.ReadLine();

            Console.Write("Hello! " + name + " How are you?");
           
            Console.ReadLine();
        }
    }
}
