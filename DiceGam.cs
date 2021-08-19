using System;
using System.Threading;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool on = true;
            while (on)
            {
                int wait = 1000;
                Console.WriteLine("Rolling your dice...");
                Console.WriteLine(@"  ____
 /\' .\    _____");
                Thread.Sleep(wait);
                Console.WriteLine(@"/: \___\  / .  /\
\' / . / /____/..\");
                Thread.Sleep(wait);
                Console.WriteLine(@" \/___/  \'  '\  /
          \'__'\/");
                Thread.Sleep(wait);


                Random pd1 = new Random();
                int playerDice1 = pd1.Next(1, 7);

                Random pd2 = new Random();
                int playerDice2 = pd2.Next(1, 7);

                int result1 = playerDice1 + playerDice2;
                Console.WriteLine("Your rolled a {0} and {1}. Your total: {2}", playerDice1, playerDice2, result1);
                Console.WriteLine("Press any button to continue");
                Console.ReadLine();

                Console.WriteLine("Rolling your openent's dice...");
                Console.WriteLine(@"  ____
 /\' .\    _____");
                Thread.Sleep(wait);
                Console.WriteLine(@"/: \___\  / .  /\
\' / . / /____/..\");
                Thread.Sleep(wait);
                Console.WriteLine(@" \/___/  \'  '\  /
          \'__'\/");
                Thread.Sleep(wait);

                Random od1 = new Random();
                int oponentDice1 = od1.Next(1, 7);

                Random od2 = new Random();
                int oponentDice2 = od2.Next(1, 7);

                int result2 = oponentDice1 + oponentDice2;
                Console.WriteLine("Your oponent rolled a {0} and {1}. Your oponenet's total: {2}", oponentDice1, oponentDice2, result2);

                if (result1 > result2)
                {
                    Console.WriteLine("\nCongrats! You won!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (result1 == result2)
                {
                    Console.WriteLine("\nYou tied... Sucks right?");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nYou lost...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
    }
}
