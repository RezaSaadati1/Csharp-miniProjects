using System;

namespace BMICalculatorWithCLI
{
    class Program
    {
        /*
            sampele exec command : 
            dotnet run --weight 70 --height 178
        */
        static void Main(string[] args)
        {
            Console.Clear();
            Validations(args);
            Execute(args);
        }



        static void Execute(string[] args)
        {
            var firsSwitch = args[1];
            var firstArg = args[2];

            var secondSwitch = args[3];
            var secondArg = args[4];

            double weight, height;

            switch (firsSwitch)
            {
                case "--weight":
                    if (secondSwitch != "--height")
                    {
                        BadCommand();
                        break;
                    }
                    weight = Convert.ToDouble(firstArg);
                    height = Convert.ToDouble(secondArg);
                    CalculateBmi(height, weight);
                    break;

                case "--height":
                    if (secondSwitch != "--weight")
                    {
                        BadCommand();
                        break;
                    }
                    height = Convert.ToDouble(firstArg);
                    weight = Convert.ToDouble(secondArg);
                    CalculateBmi(height, weight);
                    break;

                default:
                    BadCommand();
                    break;
            }

        }
        static void CalculateBmi(double height, double weight)
        {
            Console.WriteLine("\nYour BMI Score is : ");
            var bmi = Math.Round(weight / (height * height));
            var status = "";

            if (bmi <= 18.4)
            {
                status = "Underweight";
            }
            else if (bmi > 18.4 && bmi < 24.9)
            {
                status = "Normal";
            }
            else if (bmi > 25 && bmi < 39.9)
            {
                status = "Overweight";
            }
            else if (bmi >= 40)
            {
                status = "Obese";
            }

            Console.WriteLine(bmi);
            Console.WriteLine($"Your status is : {status}");


        }
        static void Validations(string[] args)
        {
            if (args.Length == 0 || args[0] != "bmi")
            {
                BadCommand();
                Environment.Exit(0);
            }
            else if (args[1] == "--helps")
            {
                ShowHelp();
                Environment.Exit(0);
            }
            else if (args[1] == "--version")
            {
                ShowCurrentVersion();
                Environment.Exit(0);
            }
        }
        static void ShowHelp()
        {
            Console.WriteLine("\n Use these switch to run program : ");
            Console.WriteLine("--height\tYour height (meters)");
            Console.WriteLine("--weight\tYour weight (kilograms)");
            Console.WriteLine("--version\tShow current version");
            Console.WriteLine("--helps\t\tShow command lis");
        }
        static void BadCommand()
        {
            Console.WriteLine("\n Invalid command :(");
            Console.WriteLine("Use --helps switch to show help");
        }
        static void ShowCurrentVersion()
        {
            Console.WriteLine("\nCurrent version is : 1.0");
        }
    }
}
