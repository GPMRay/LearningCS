using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 26;

            switch (age) // Grabs the current value of variable 'age'
            {
                case 15: // Checks to see if age is equal to 15. If not moves on.
                    Console.WriteLine("Too young to party in the club");
                    break; // Required to end the case.
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default: // If none of these cases match the variable in the switch, then 'default' will be ran.
                    Console.WriteLine("How old are you then?");
                    break;
            }
            
            // This does the same exact thing as shown above, however checks a string. This would work for any other data type.
            string username = "Denis";
            switch(username)
            {
                case "Denis":
                    Console.WriteLine("Username is denis");
                    break;
                case "root":
                    Console.WriteLine("Username is denis");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }

            Console.Read();
        }
    }
}
