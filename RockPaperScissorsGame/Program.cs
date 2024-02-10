using System;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            bool play = true;
            string computer, player;

            while (play)
            {
                Console.Clear();
                player = SetPlayerRound();
                computer = SetComputerRound(random);

                Console.WriteLine($"Player : {player}");
                Console.WriteLine($"Computer : {computer}");

                WinDetector(player, computer);

                play = ConfirmPlayAgain();

                Console.WriteLine("Thanks for playing :)");

            }
        }

        static bool ConfirmPlayAgain()
        {
            
            Console.Write("Would you like to play again (Y = Yes, N = NO) : ");
            var answer = Console.ReadLine().ToUpper();
            return answer == "Y";

           
        }

        static void WinDetector(string player, string computer)
        {
            switch (player)
            {
                case "ROCK":
                    if(computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if(computer == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else 
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if(computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if(computer == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else 
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSORS":
                    if(computer == "SCISSORS")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if(computer == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else 
                    {
                        Console.WriteLine("You lose!");
                    }
                    break; 
                default:
                    Console.WriteLine("Error...");
                    break;
            }
        }

        static string SetComputerRound(Random random)
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
                default:
                    return "";
            }
        }

        static string SetPlayerRound()
        {
            string player = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.Write("Enter ROCK, PAPER or SCISSORS : ");
                player = Console.ReadLine().ToUpper();
            }
            return player;
        }
    }
}
