using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            int lenghtOfText = 0; // Default value
            string wholeText = string.Empty; // Default value

            do // Will continue looping while the condition within 'while' is met.
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine(); // Reads user input
                int currentLenght = nameOfAFriend.Length; // Checks the lenght of 'nameOfAFriend' and converts that to int 'currentLenght'
                lenghtOfText += currentLenght; // By default this is 0. 
                wholeText += nameOfAFriend; // This adds wholeText + nameOfAFriend to view at the end.     
            } while (lenghtOfText < 20); // Checks if lenght if the variable is less than 20
            Console.WriteLine("Thanks, that was enough! " + wholeText);

            Console.Read();
        }

    }
}
