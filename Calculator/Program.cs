using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculate();

            do
            {

                Console.Clear();
                Console.WriteLine("____________________\n");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("____________________\n");

                Calculate.SetCalculatorOperators(calculator);

                calculator.PrintOptions();

                calculator.Operand = Console.ReadLine();

                try
                {
                    calculator.Process();
                    Console.WriteLine(calculator);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Wuold you like to continue (Y = Yes, N = No) : ");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.Clear();
            Console.WriteLine("Bye :)");

        }
    }
}
