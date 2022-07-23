using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static int counter; // Created a global variable so that line 14 can show the final value of 'counter'.
        static void Main(string[] args)
        {
            for(counter = 0; counter < 10; counter++) // We set a value to zero, then we check if the condition is true, if it's true, it runs the code block (cw). After the code block is executed, the third statemnt (counter++) will execute.
            {
                Console.WriteLine(counter); // Executed before (counter++). After this code bloock is executed, the third statement is executed.
            }
            Console.WriteLine(counter);
        }
    }
}
