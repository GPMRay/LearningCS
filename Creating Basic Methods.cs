using System;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 15; // Declaring two int varibles.
            int two = 31;

            int result = Add(one, two); // This calls the "Add" method with the arguments in the (). It also stores the return value in "result"

            Console.WriteLine(result); // Displays the "result".
            Console.ReadLine();
        }

        public static int Add(int num1, int num2) // Parameters from inside the call method. (access modifer, static, return type, method name, parameters)
        {
            return num1 + num2; // Does some math and returns the result to int result.
        }
    }
}
