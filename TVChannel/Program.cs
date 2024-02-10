using System;

namespace TVChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            var channel = 0;
            do
            {
                Console.Clear();
                Console.WriteLine($"** CHANNEL {++channel} **");
                Console.WriteLine("Do you love this channel ? (Y = Yes, N = No) :");
                var result = Console.ReadLine().ToUpper();

                play = result == "N" ? true : false;


            } while (play);

            Console.WriteLine($" Enjoy watching CHANNEL {channel}\n ^_^");
        }
    }
}
