using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // Default value.
            string enteredText = ""; // Empty string assigned to 'enteredText'.
            while(enteredText.Equals("")) // Start of the while loop. Makes sures that the string variable 'enteredText' is empty.
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else + enter if you wish to finish counting.");
                enteredText = Console.ReadLine();
                if (!enteredText.Equals("")) // Checks to see if 'enteredText' does not equal empty anymore.
                {
                    Console.WriteLine("{0} are inside the bus. Press enter to close the program.", counter); // Final number shown.
                    break; // Exits the while loop.
                }
                counter++; // Adds one to the 'counter' variable should the if statement, which results in a break, is not be executed.
                Console.WriteLine("Current people count is {0}", counter); // Current counter.
            }
            Console.WriteLine("{0}", counter); // This is not needed. I was just checking to ensure that the 'break' on line 18 worked lol.
        }
    }
}
