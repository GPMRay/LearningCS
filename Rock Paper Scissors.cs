using System;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 100;
            bool on = true;

            while (on)
            {
                Console.Clear();
                Console.WriteLine("How much do you want to wager? You currently have ${0}", balance);
                int bet = Convert.ToInt32(Console.ReadLine());

                Random player = new Random();
                int playerResult = player.Next(1, 3);

                Random opponent = new Random();
                int opponentResult = player.Next(1, 3);

                if (playerResult.Equals(1) && opponentResult.Equals(1))
                {
                    Console.WriteLine("Player: Rock.\nOpponent: Rock.");
                    Console.WriteLine("Tie!");
                }
                else if (playerResult.Equals(1) && opponentResult.Equals(2))
                {
                    Console.WriteLine("Player: Rock.\nOpponent: Paper.");
                    Console.WriteLine("Opponent wins!");
                    int newBalance = balance - bet;
                    balance = newBalance;
                }
                else if (playerResult.Equals(1) && opponentResult.Equals(3))
                {
                    Console.WriteLine("Player: Rock.\nOpponent: Scissors.");
                    Console.WriteLine("Player wins!");
                    int newBalance = balance + bet;
                    balance = newBalance;
                }
                else if (playerResult.Equals(2) && opponentResult.Equals(1))
                {
                    Console.WriteLine("Player: Paper.\nOpponent: Rock.");
                    Console.WriteLine("Player wins!");
                    int newBalance = balance + bet;
                    balance = newBalance;
                }
                else if (playerResult.Equals(2) && opponentResult.Equals(2))
                {
                    Console.WriteLine("Player: Paper.\nOpponent: Paper.");
                    Console.WriteLine("Tie!");
                }
                else if (playerResult.Equals(2) && opponentResult.Equals(3))
                {
                    Console.WriteLine("Player: Paper.\nOpponent: Scissors.");
                    Console.WriteLine("Opponent wins!");
                    int newBalance = balance - bet;
                    balance = newBalance;
                }
                else if (playerResult.Equals(3) && opponentResult.Equals(1))
                {
                    Console.WriteLine("Player: Scissors.\nOpponent: Rock.");
                    Console.WriteLine("Opponent wins!");
                    int newBalance = balance - bet;
                    balance = newBalance;
                }
                else if (playerResult.Equals(3) && opponentResult.Equals(2))
                {
                    Console.WriteLine("Player: Scissors.\nOpponent: Paper.");
                    Console.WriteLine("Player wins!");
                    int newBalance = balance + bet;
                    balance = newBalance;
                }
                else if (playerResult.Equals(3) && opponentResult.Equals(3))
                {
                    Console.WriteLine("Player: Scissors.\nOpponent: Scissors.");
                    Console.WriteLine("Tie!");
                }

                Console.ReadLine();
            }
        }
    }
}
