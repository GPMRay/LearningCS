using System;

namespace HelloWorld
{
    // Basic counter system.
    class Program
    {

        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals("")) // Will keep running as long as the condition is met.
            {
                Console.WriteLine("Please press Enter to increase amount by one. On the last count, press any other key.");
                enteredText = Console.ReadLine();
                counter++; // Keeps adding the int by 1
                Console.WriteLine("Current people count {0}", counter);
            }
            Console.WriteLine("The final value is {0}", counter);
            Console.Read();
        }

    }
}
