using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        public static int Calculate()
        {

            Console.WriteLine("Enter the first number");
            string sInput1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string sInput2 = Console.ReadLine();

            // This converts the string 'sInput1' and 'sInput2' to an int by using Parse.
            int num1 = int.Parse(sInput1); 
            int num2 = int.Parse(sInput2);

            int result = num1 + num2;

            Console.Clear();
            Console.WriteLine(result);

            return result;
        }

    }
}
