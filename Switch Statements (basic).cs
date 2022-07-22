using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            // Switch/case example
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;

                default:
                    Console.WriteLine("How old are you then?");
                    break;

            }
            // If example

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if(age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            // String example
            string username = "Denis";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("Username is Denis");
                    break;
                case "Root":
                    Console.WriteLine("Username is Root");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }
        }
    }
}
