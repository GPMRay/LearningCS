using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1") // If the user enters '-1' then that signifies that they are done entering values
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter '-1' once you are ready to calculate the average.");

                input = Console.ReadLine(); 

                if (input == "-1") // You can also do 'if (input.Equals("-1"))`. This checks the input of the string to see if they are done.
                {
                    Console.WriteLine("----------------------");
                    double average = (double)total / (double)count; // Converts two int variables to double, and does the calculation. Sets it equal to 'average'.
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0  && currentNumber < 21)
                {
                    total = total + currentNumber;
                }
                else
                {
                    if(!(input.Equals("-1"))) // If unable to parse & checks to make sure they did not enter -1.
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }

                count++; // Increases the counter. We do this outside the while loop to ensure it's not ran incorrectly.
            }

            Console.ReadLine();
        }

    }
}
