using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            bool play = true;
            int min = 1;
            int max = 100;
            do
            {
                Console.Clear();
                int guess = 0;
                int round = 0;
                int number = random.Next(min, max + 1);

                while (number != guess)
                {

                    Console.Write($"Guess number between {min} - {max} : ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Guess = {guess}");

                    if (number > guess)
                    {
                        Console.WriteLine($"{guess} is too low!");
                    }
                    else if (number < guess)
                    {
                        Console.WriteLine($"{guess} is too high!");
                    }
                    round++;
                }
                Console.Clear();
                Console.WriteLine($"Number : {number}");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine($"Round : {round}");

                Console.Write("Would you like to play again ? (Y = Yes, N = No) :");
                var result = Console.ReadLine().ToUpper();

                play = result == "Y";
            } while (play);

            Console.Clear();
            Console.WriteLine("Thanks for playing... :)");
        }
    }
}
