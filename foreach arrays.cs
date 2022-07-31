using System;

namespace arrays_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10]; // Creates a new array with 10 total values. Since we do not specify the values for each int the system auto assigns "0" for each int.

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k); counter++;
            }

            // Challenge

            string[] friends = {"Jackson", "Ray", "Ronnie", "Michael", "Jake"};

            foreach(string f in friends)
            {
                Console.WriteLine("Hello {0}, my friend.", f);
            }

        }
    }
}
