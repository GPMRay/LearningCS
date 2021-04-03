using System;

/* In this example, we are using 'if' statements to check the value of 'tempretureInt'. Below is how it works.
 * 1. Text displays on the console asking what the tempreture is (F)
 * 2. A new string is created named tempreture (variable name tempreture)
 * 3. A new int varibale is created. Which converts the string variable 'tempreture' to an int variable 'tempretureInt'
 * 4. Although this code is the basics of 'If' statements, the 'if' statements are checked for their value.
*/

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What's the tempreture?");
            string tempreture = Console.ReadLine();
            int tempretureInt = int.Parse(tempreture);  

            if(tempretureInt < 60)
            {
                Console.WriteLine("Take the coat");
            }

            if(tempretureInt == 60)
            {
                Console.WriteLine("It's 60 degrees C");
            }

            if(tempretureInt > 60)
            {
                Console.WriteLine("Cozy & warm");
            }

            Console.Read();
        }

    }
}
