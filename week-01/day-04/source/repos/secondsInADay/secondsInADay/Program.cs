using System;

namespace secondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int currentHoursInSeconds = 14 * 60 * 60;
            int currentMinutesInSeconds = 34 * 60;
            int dayInseconds = 24 * 60 * 60;

            int remainingSeconds = dayInseconds - (currentHoursInSeconds + currentMinutesInSeconds + 42);

            Console.WriteLine(dayInseconds);
            Console.WriteLine(remainingSeconds);
            Console.ReadLine();


            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
        }
    }
}
