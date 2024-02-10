using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            Console.Clear();

            while (again)
            {
                Console.Clear();
                Console.WriteLine("Welcome To Converter <3");
                Console.WriteLine(" 1- Currency Exchange \n 2- Length Conversion");
                Console.Write("Plz Enter your choies : ");
                var answer = Console.ReadLine();

                if (answer == "1")
                {
                    var currencyExchange = new Conversion();
                    currencyExchange.Currency();
                }
                else if (answer == "2")
                {
                    var lengthConversion = new Conversion();
                    lengthConversion.Length();
                }

                else
                {
                    Console.WriteLine("Your answer is false . Plz try again...");
                }

                Console.Write("Are you want to choies again ? (Y = Yes / N = No) : ");
                var toAgain = Console.ReadLine().ToUpper();
                if (!(toAgain == "Y"))
                {
                    again = false;
                }
                else
                {
                    again = true;
                }
            }
            Console.Clear();
            Console.WriteLine("Thanks for try it :)");
        }
    }
}
