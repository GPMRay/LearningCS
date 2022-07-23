using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the weather?");
            string temprature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temprature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temprature.");
            }

            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and pull over should be great.");
            }
            else if(numTemp > 30)
            {
                Console.WriteLine("It's super hot!");
            }
            else
            {
                Console.WriteLine("Shorts are okay.");
            }


        }
    }
}
