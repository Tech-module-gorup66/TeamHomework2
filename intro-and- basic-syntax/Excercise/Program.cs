//Confirmed from EnislavEnchev14
using System;

namespace BasicSytaxExercises2301
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive from the console the four numbers of the debit card
            var numFirst = int.Parse(Console.ReadLine());
            var numSecond = int.Parse(Console.ReadLine());
            var numThird = int.Parse(Console.ReadLine());
            var numFourth = int.Parse(Console.ReadLine());
            //Then we print the numbers, seperated by a space, with the necessary 0 in front of them
            Console.WriteLine($"{numFirst:D4} {numSecond:D4} {numThird:D4} {numFourth:D4}");

        }
    }
}
