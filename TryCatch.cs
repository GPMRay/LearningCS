using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!"); // Write's the string into the console.
            string userInput = Console.ReadLine(); // Create's a string variable named 'userInput' and reads the line.
            Console.WriteLine("Please enter a second number");
            string userinput2 = Console.ReadLine();

            try // This is a Try and Catch. It tries to run what's inside the brackets and returns a certain error if unable to. 
            {
                int userInputAsInt = int.Parse(userInput); // Creates a new int variable named 'userInputAsInt' and imports the string variable 'userInput' into the new int variable.
                int userInputAsInt2 = int.Parse(userinput2);
                int result = userInputAsInt / userInputAsInt2;
                Console.WriteLine(result);
                Console.Read();
            }
            catch (FormatException) // If the code above (try) runs into an error the following messages depending on the type of error will be displayed
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number is too long or short for an int32.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty.");
            } 
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch (Exception) // This 'Exception' is only displayed if there are any other errors not specified above. You can replace the console writeline to "throw;" to find the correct Excemption if needed.
            {
                Console.WriteLine("An unknwon error occured.");
            }
            finally // 'Finally' is optional. Just an example below.
            {
                Console.WriteLine("This is called anyways!");
            }
        }

    }
}
