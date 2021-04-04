using System;

namespace HelloWorld
{
    class Program
    {
        // These are global variables
        static int highscore = 300; // The current highscore
        static string highscorePlayer = "Ray"; // The current player with the highest score

        static void Main(string[] args)
        {
            CheckHighscore(250, "Maria"); // This calls 'CheckHighscore' and sends the int (in this case 250 = score), and sends the string (in this case Maria = playerName).
            CheckHighscore(315, "Michael");
            CheckHighscore(314, "Ray");

            Console.Read();

        }

        public static void CheckHighscore(int score, string playerName) // Checks to see if the information being sent is a new highscore against the global variables
        {
            if(score > highscore) // If the int is higher than the current highscore, continue below.
            {
                highscore = score; // Updates the old highscore to the score by the player.
                highscorePlayer = playerName; // Updates the old highScorePlayer to the current playerName.

                Console.WriteLine("New highscore is " + score); // Outputs the new score followed by the playerName
                Console.WriteLine("It is now held by " + playerName);
            }
            else // If the score sent to the class is less than the highscore, then this is what is ran.
            {
                Console.WriteLine("The old highscore could not be broken. It is still " + highscore + " it is held by " + highscorePlayer); // Outputs the current highscore data.
            }
        }
    }
}
