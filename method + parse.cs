using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the tempreture?");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(temp));
            string result = Check(temp);
        }

        public static string Check(int test)
        {
            if (test < 50)
            {
                string david = "Very cold!";
                return david;
            }
            else
            {
                Console.WriteLine("Very hot!");
                return null;
            }
        }
    }
}
