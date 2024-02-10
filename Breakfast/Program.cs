using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace breakfast
{
    public class Bacon { }
    public class Coffee { }
    public class Egg { }
    public class Juice { }
    public class Toast { }
    
    class Program
    {
        static async Task Main(string[] args)
        {
            var cup = ReadyCoffee();
            Console.WriteLine("coffee is ready");

            var eggs = FryEggsAsync(2);
            var bacon = FryBaconAsync(3);
            var toast = MakeToast(2);
            
            var breakfast = new List<Task> { eggs, bacon, toast };
            while (breakfast.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfast);
                if (finishedTask == eggs)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == bacon)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toast)
                {
                    Console.WriteLine("toast is ready");
                }
                breakfast.Remove(finishedTask);
            }
            
            var juice = ReadyJuice();
            Console.WriteLine("Juice is ready");
            Console.WriteLine("Breakfast is ready! :)");
        }
        
        static async Task<Toast> MakeToast(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }
        private static Juice ReadyJuice()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) => Console.WriteLine("Putting jam on the toast"); 

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");   
        }

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of break in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");
            
            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");
            
            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan ...");
            await Task.Delay(3000);

            return new Egg();
        }

        private static Coffee ReadyCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
