using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertNumber
{
    public class Convert
    {
        public void Converter()
        {
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome");
                Console.WriteLine("Enter a number to execute : ");
                Console.WriteLine("1- Convert number to alphabet \n2- Convert number to days of week \n3- Exit");
                Console.Write("--> ");
                var choice =Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter a number between 1 to 10 : ");
                        var input = Console.ReadLine();

                        var result = "";

                        switch(input)
                        {
                            case "1" : 
                                result = "One";
                                break;
                            case "2" : 
                                result = "Two";
                                break;
                            case "3" : 
                                result = "Three";
                                break;
                            case "4" : 
                                result = "Four";
                                break;
                            case "5" : 
                                result = "Five";
                                break;
                            case "6" : 
                                result = "Six";
                                break;
                            case "7" : 
                                result = "Seven";
                                break;
                            case "8" : 
                                result = "Eight";
                                break;
                            case "9" : 
                                result = "Nine";
                                break;
                            case "10" : 
                                result = "Ten";
                                break;
                            default :
                                Console.WriteLine("You entered out of range!");
                                break;
                        }
                        
                        if (!string.IsNullOrEmpty(result))
                        {
                            Console.WriteLine($"--> Result : {result}");
                        }
                        Console.ReadKey();
                        break;


                    case "2":
                    Console.Clear();
                    Console.Write("Enter a number between 1 to 7 for days of the week : ");
                    var inputDay = Console.ReadLine();
                    var days = "";
                    switch(inputDay)
                    {
                        case "1" : 
                            days = "Saturday";
                            break;
                        case "2" : 
                            days = "Sunday";
                            break;
                        case "3" : 
                            days = "Monday";
                            break;
                        case "4" : 
                            days = "Tuesday";
                            break;
                        case "5" : 
                            days = "Wednesday";
                            break;
                        case "6" : 
                            days = "Thursday";
                            break;
                        case "7" : 
                            days = "Friday";
                            break;
                        default :
                            Console.WriteLine("You entered out of range!");
                            break;
                    }

                    if (!string.IsNullOrEmpty(days))
                        {
                            Console.WriteLine($"--> Result : {days}");
                        }
                    Console.ReadKey();
                        break;

                        
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Good Bye :)");
                        exit = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You entered wrong item. \nTry again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}