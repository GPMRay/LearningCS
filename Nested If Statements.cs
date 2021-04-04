using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true; // In this example this is always true
            string userName = ""; // A place holder. Line 20 will no run if the user does not enter a value
            Console.WriteLine("Please enter your username"); // Inputs for a username
            userName = Console.ReadLine(); // Saves the input to userName

            if(isRegistered) // This will always run since the variable is set to true
            {
                Console.WriteLine("Hi there, registered user");
                if(userName != "") // If user specified a username on line 13 the code below will run
                {
                    Console.WriteLine("Hi there, " + userName); // Returns the user input for variable userName
                    if(userName.Equals("admin")) // If the username specified on line 13 is 'admin' it will show the string below
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
            Console.Read(); // Pauses the program
        }
    }
}
