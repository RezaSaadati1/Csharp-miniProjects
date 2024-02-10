using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathCalculator
{
    public class MathCalculate
    {
        public void Factorial()
        {
            Console.Write("Enter your real number for calculate factorial : ");
            var result = int.Parse(Console.ReadLine());
            var fact = 1;
            int i;

            for (i = 1; i <= result; ++i)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {result} is : {fact}");

        }

        public void Fibonacci()
        {
            Console.Write("Enter your real number for calculate fibonacci : ");
            var result = int.Parse(Console.ReadLine());
            var s = 0;
            int i;

            for (i = 1; i <= result; ++i)
            {
                s += i;
            }
            Console.WriteLine($"Fibonacci of {result} is : {s}");
        }


        public void FindMinAndMax()
        {
            var numbers = new double[5];
            Console.WriteLine("Enter 5 number (Enter between each number you entered...) : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            var maximum = FindMaximum(numbers);
            var minimum = FindMinimum(numbers);

            Console.WriteLine($"The Maximum number is : {maximum}");
            Console.WriteLine($"The Minimum number is : {minimum}");


            static double FindMaximum(double[] numbers)
            {
                var max = numbers[0];
                foreach (var number in numbers)
                {
                    if (max < number)
                    {
                        max = number;
                    }
                }
                return max;
            }
            static double FindMinimum(double[] numbers)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (min > number)
                    {
                        min = number;
                    }
                }
                return min;
            }
        }



        public void Power()
        {

            Console.WriteLine("Enter two number power it ");

            Console.WriteLine("Enter the first number : ");
            var x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            var y = Convert.ToDouble(Console.ReadLine());

            var power = Pow(x, y);
            Console.WriteLine($"{x} power {y} : {power}");

        }

        static double Pow(double x, double y)
        {
            double result = 1;
            for (int i = 0; i <= y - 1; i++)
            {
                result = result * x;
            }
            return result;

        }



        public void PythagoreanTheorem()
        {
            Console.Write("Enter side A : ");
            var sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side B : ");
            var sideB = Convert.ToDouble(Console.ReadLine());

            var result = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);

            Console.WriteLine($"The hypotenuse is : {result}");
        }
    }
}