using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            for(int counter = 0; counter < 50; counter +=5) // first value is the int value, second is the conditon (what it's checking), then after it's checked it increases the variable as defined.
            {
                Console.WriteLine(counter + " is lower than 50"); // Displays the current value while the loop is ran
            }
            Console.WriteLine("For loop is done"); // Prints that the loop is done for a better visualizer of what's happening
            Console.Read();
        }

    }
}
