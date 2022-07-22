using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Denis";
        static void Main(string[] args)
        {
            InputInformation(); // Goes to the InputInformation method.
        }

        public static void InputInformation()
        {
            Console.WriteLine("What is the first player's name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What was " + firstName + "'s score?");
            int firstNameScore;
            bool firstScore = int.TryParse(Console.ReadLine(), out firstNameScore); // Checks the user input to ensure it can be changed into an int. If not, the bool will be set to false.

            if (firstScore) // Could it be converted to an int?
            {
                Console.WriteLine("What is the second player's name?");
                string secondName = Console.ReadLine();
                Console.WriteLine("What was " + secondName + "'s score?");
                int secondNameScore;
                bool secondScore = int.TryParse(Console.ReadLine(), out secondNameScore);

                if (secondScore)
                {
                    CheckHighScore(firstNameScore, firstName);
                    CheckHighScore(secondNameScore, secondName);
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number for " + secondName + "'s score");
                    InputInformation();
                }
            }
            else
            {
                Console.WriteLine("You did not enter a valid number for " + firstName + "'s score");
                InputInformation();
            }
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken by " + playerName + ". It is still " + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}
