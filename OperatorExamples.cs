using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1; // Converts num1 to a negative and makes it equal to num3
            Console.WriteLine("num3 is {0}", num3); // {0} imports whatever variable is after the comma

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny); // Same as above, but converts isSunny to false (negates it's value '!')

            // incrememnt operators (also works the same as decrement)
            int num = 0;
            num++; // Increases the variable by 1
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); // Increments by 1 but displayed on the next line
            Console.WriteLine("num is {0}", ++num); // Increments by 1 but shows on the same line

            // relational and type operators
            bool isLower;
            isLower = num1 > num2; // Defines variable 'isLower' to True or False
            Console.WriteLine("Is num1 > num2 {0}", isLower); // Returns true or false

            // equality operator
            bool isEqual;
            isEqual = num1 == num2; // Compares if whatever is on the right is the same as whatever is on the left
            Console.WriteLine("Result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny; // Both variables would have to be true for this to be true
            Console.WriteLine("Result of isLower && isSunny {0}", isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny; // One or both variables would have to be true. If both are false then isLowerAndSunny would be false.
            Console.WriteLine("result of isLower || isSunny {0}", isLowerAndSunny);


            Console.ReadKey();
        }

    }
}
