using System;

namespace ClassesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10);
            taffy.SetRating(5, "Just kinda liked it.");

            Console.WriteLine(taffy.ToString());

            Console.WriteLine("Hello World!");
        }
    }
}
