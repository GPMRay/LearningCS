using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number you wish to add: ");
            int num1 = int.Parse(Console.ReadLine()); // Assigns the user input to the variable num1. We are also converting the string input into an int.
            // int num1 = Convert.ToInt32(Console.ReadLine()); (could also do this too)
            Console.WriteLine("Enter the first number you wish to add: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2); // Calls the method 'Add', passes off the arguments of 'num1' and 'num2' and saves the information to int result.
            Console.WriteLine(result); // Displays the answer.

            // Console.WriteLine(Add(num1, num2)); (could also do this to avoid creating a varible on line 14. Best to use this convention when no needing to store the data)

        }

        public static int Add(int num1, int num2) // New method. It will be returing type 'int', and has two int parameters needed for it to run.
        {
            return num1 + num2; // The action and performed and returned to 'result' on line 14
        } 
    }
}
