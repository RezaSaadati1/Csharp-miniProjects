using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {

        public static void SetCalculatorOperators(Calculate calculate)
        {
            Console.Write("Enter number 1 : ");
            calculate.FirstOperator = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2 : ");
            calculate.SecondOperator = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintOptions()
        {
            Console.WriteLine("Options : ");
            Console.WriteLine("\t + : Add");
            Console.WriteLine("\t - : Subtract");
            Console.WriteLine("\t * : Multiply");
            Console.WriteLine("\t / : Divide");
            Console.WriteLine("\t % : remainder");
            Console.Write("Enter an option : ");
        }

        public void Process()
        {
            switch (_operand)
            {
                case "+":
                    _result = FirstOperator + SecondOperator;
                    break;
                case "-":
                    _result = FirstOperator - SecondOperator;
                    break;
                case "*":
                    _result = FirstOperator * SecondOperator;
                    break;
                case "/":
                    _result = FirstOperator / SecondOperator;
                    break;
                case "%":
                    _result = FirstOperator % SecondOperator;
                    break;
                default:
                    throw new Exception("That was not a valid option");
            }
        }

        public double FirstOperator { get; set; }
        public double SecondOperator { get; set; }
        private double _result { get; set; }
        private string _operand;

        public string Operand
        {
            set
            {
                if (value == "+" ||
                    value == "-" ||
                    value == "*" ||
                    value == "/" ||
                    value == "%")
                {
                    _operand = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Your result : {FirstOperator} {_operand} {SecondOperator} = {_result}";
        }


    }
}