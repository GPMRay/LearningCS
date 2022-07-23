using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.Clear();
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calcuate the average");

                input = Console.ReadLine();

                if (input.Equals("-1"))
                {
                    Console.WriteLine("----------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 10000000000000)
                {
                    total += currentNumber;
                    //total = total + currentNumber; (other way of doing it)
                }
                else
                {
                    if (!input.Equals("-1"))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }

                count++;
              
            }


        }
    }
}
