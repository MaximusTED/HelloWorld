﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); //hello there
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {date:d} at {date:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
