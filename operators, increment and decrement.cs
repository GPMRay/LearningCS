using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("IS it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num); // Displays '1'
            // post increment
            Console.WriteLine("num is {0}", num++); // Displays '1' even though it's now '2' BECAUSE the increment occurs in the next line. So technicaly it's already been incremented, but not displayed.
            // pre increment
            Console.WriteLine("num is {0}", ++num); // Displays '3' BECAUSE we used '++' at the start

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            // post increment
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result); // Devides but returns the remainder

            // relational and type operators
            bool isLower;
            isLower = num1 < num2; // Comparing if 'isLower' should be changed to true or false.
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2; // Checks to see if num1 and num2 are equal, if so changes to true or false.
            Console.WriteLine("result of num1 == num2 is {0}", isLower);

            isEqual = num1 != num2; // Checks to see if num1 and num2 are NOT equal to each other. If so, changes to true or false.
            Console.WriteLine("result of num1 != num2 is {0}", isLower);

            // conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny {0}", isLowerAndSunny);


        }
    }
}
