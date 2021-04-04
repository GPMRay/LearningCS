using System;


namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What's the tempreture?");
            string tempreture = Console.ReadLine();
            int numTemp;
            int number;

            if(int.TryParse(tempreture, out number)) // Using 'TryParse' to avoid a crash in the event the user enters a invalid value. It's converting a string to an int.
            {
                numTemp = number; // If the user input was able to be converted, this will make it equal to each other.
            }
            else
            {
                numTemp = 0; // If the user input was not able to be converted, then numTemp is set to 0
                Console.WriteLine("Value enetered was null. 0 set as tempreture.");
            }

            if (numTemp < 60)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numTemp == 60)
            {
                Console.WriteLine("It's 60 degrees C");
            }
            else if (numTemp > 60)
            {
                Console.WriteLine("Cozy & warm");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }

    }
}
