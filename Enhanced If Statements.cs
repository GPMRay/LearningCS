using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            /* condition ? first_expression : second_expression;
            condition has to be either true or false
            The conditional operator is right - associative
            The expression a ? b: c? d : e
            is evaluated as a ? b : (c ? d : 3),
            not as (a? b : c) ? d: 3.
            The conditional operator cannot be overloaded.
            */

            int temperature = -5;
            string stateOfMatter;

            // Simple/short way
            stateOfMatter = temperature < 0 ? "solid" : "liquid"; // If 'tempreture' is below 0. The variable 'sateOfMatter' will be given the string by true/false.

            // Added a 'Gas' option.
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.Write("State of matter is {0}", stateOfMatter);
            Console.ReadKey();

        }

    }
}
