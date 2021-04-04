using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true; // In this example this is always true
            string userName = ""; // A place holder. Line 17-21 will not run if the user does not enter a value
            Console.WriteLine("Please enter your username"); // Inputs for a username
            userName = Console.ReadLine(); // Saves the input to userName

            if (isRegistered && userName != "" && userName.Equals("admin")) // Checks to ensure all the specifed variables are true. Code will not run if the userName is not specified to 'admin'.
            {
                Console.WriteLine("Hi there, registered user");

                Console.WriteLine("Hi there, " + userName); // Returns the user input for variable userName

                Console.WriteLine("Hi there, Admin");
            }
            else
            {
                Console.WriteLine("You failed to specify a username or an error occured!"); // Any of the variables specified on line 15 do not match, this message will display
            }
            Console.Read(); // Pauses the program
        }
    }
}
