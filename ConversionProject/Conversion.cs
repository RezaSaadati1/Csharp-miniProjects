using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conversion
{
    public class Conversion
    {
        public void Currency()
        {
            Console.WriteLine(" 1- Iranian Rial => USA Doller \n 2- USA Doller => Iranian Rial  \n 3- Euro => Iranain Rial ");
            Console.Write("plz enter your choies : ");
            var result = Console.ReadLine();
            Console.Write("plz enter your real number : ");
            var answer = Convert.ToDouble(Console.ReadLine());
            switch (result)
            {
                case "1":
                    var a = answer * 0.000024;
                    Console.WriteLine($"Yoru result is : {a} Doller");
                    break;
                case "2":
                    var b = answer * 540000;
                    Console.WriteLine($"Yoru result is : {b} Rial");
                    break;
                case "3":
                    var c = answer * 590000;
                    Console.WriteLine($"Yoru result is : {c} Rial");
                    break;
                default:
                    Console.WriteLine("ooooops... ):");
                    break;
            }
        }

        public void Length()
        {
            Console.WriteLine(" 1- Inch => Meter \n 2- inch => foot  \n 3- Meter => foot \n 4- Mile => inch \n 5- Mile => KiloMeter ");
            Console.Write("plz enter your choies : ");
            var result = Console.ReadLine();
            Console.Write("plz enter your real number : ");
            var answer = Convert.ToDouble(Console.ReadLine());
            switch (result)
            {
                case "1":
                    var a = answer * 0.0254;
                    Console.WriteLine($"Yoru result is : {a}");
                    break;
                case "2":
                    var b = answer * 0.0833;
                    Console.WriteLine($"Yoru result is : {b}");
                    break;
                case "3":
                    var c = answer * 3.28;
                    Console.WriteLine($"Yoru result is : {c}");
                    break;
                case "4":
                    var d = answer * 63360;
                    Console.WriteLine($"Yoru result is : {d}");
                    break;
                case "5":
                    var f = answer * 1.609;
                    Console.WriteLine($"Yoru result is : {f}");
                    break;
                default:
                    Console.WriteLine("ooooops... ):");
                    break;
            }
        }    
    }
}