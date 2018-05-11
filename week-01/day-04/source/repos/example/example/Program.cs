using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Enter your name: ";
            string name;


            Console.Write(message); // kiíratod az message-et

            name = Console.ReadLine();

            Console.WriteLine("Szia, " + name);
            
            Console.ReadLine();
        }
    }
}
