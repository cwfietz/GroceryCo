using System;

namespace GroceryCoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello.";
            Console.WriteLine(greeting);
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate}");
            Console.Write($"{Environment.NewLine}Press a key to exit.{Environment.NewLine}");
            Console.ReadKey(true);
        }
    }
}
