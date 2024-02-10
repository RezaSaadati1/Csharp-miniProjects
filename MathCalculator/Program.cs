using System;

namespace MathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           bool again = true;
           Console.Clear();

           while(again)
           {
            
            Console.Clear();
            Console.WriteLine("Welcome to Math Calculator");
            Console.WriteLine(" 1- Factoriel \n 2- Pythagorean \n 3- Fibonacci \n 4- Find max & min \n 5- Power");
            Console.Write("Enter your choies : ");
            var result = Console.ReadLine();

            switch (result)
            {
                case "1" : 
                    var factorial = new MathCalculate();
                    factorial.Factorial();
                    break;
                case "2" :
                    var Pythagorean = new MathCalculate();
                    Pythagorean.PythagoreanTheorem();
                    break;
                case "3" :
                    var fibonacci = new MathCalculate();
                    fibonacci.Fibonacci();
                    break;
                case "4" :
                    var findMaxAndMin = new MathCalculate();
                    findMaxAndMin.FindMinAndMax();
                    break;
                case "5" :
                    var power = new MathCalculate();
                    power.Power();
                    break;   
                default:
                    Console.WriteLine("Your entered is false, try again ...");
                    break;
            }

            Console.Write("Are you want choies again ? (Y = Yes / N = No) : ");
            var toAgain = Console.ReadLine().ToUpper();

            if(!(toAgain == "Y"))
            {
                again = false;
            }
            else
            {
                again = true;
            }

            Console.Clear();
            Console.WriteLine("Thanks for try it <3 ");

           }
        }
    }
}
