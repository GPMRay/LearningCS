using System;

namespace HelloWorld
{
    class Program
    {
        // Global variables
        static string username;
        static string password;

        static void Main(string[] args) // This is what launches first when ran
        {
            Register(); // Goes to the methods
            Login();
            Console.Read(); // Pauses at the end
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine(); // Saves input to global username variable. We do not enter 'string' first as this is a global variable.
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("--------------------------------"); // Returns to Main method
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if(username == Console.ReadLine()) // Checks to see if the input matches the username specified in Login class
            {
                Console.WriteLine("Please enter your password"); // If the username matches, it will then ask for the password
                if (password == Console.ReadLine()) // If the password matches it will move to the next line and stop.
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart program.");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart program"); // If the username specified on line 31 fails, this message will pop up. Skipping all the rest of the code.
            }
        }
    }
}
