﻿using System;

namespace BasicSytaxExercises2301
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1:D4} {num2:D4} {num3:D4} {num4:D4}");

        }
    }
}
