using System;
using ClassesExamples.Legos;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Legs;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var taffy = new Candy("OrangeLegs", "OrangeLegs Saltwater Taffy", CandyType.Stretchy);

            //taffy.SetRating(10);
            //taffy.SetRating(5, "Just kinda liked it.");

            //Console.WriteLine(taffy.ToString());

            var myDogHead = new Dog();

            myDogHead.Talk();

            var martinHead = new Bald();
            var astronaught = new Astronaut();

            var fitTorso = new FitTorso(2);
            fitTorso.Crunch(12);

            var adamsLegs = new OrangeLegs(Length.Short);

            var minifigure = new Minifigure("Adam", astronaught, fitTorso, adamsLegs);

            minifigure.Greet();

            Console.ReadLine();
        }
    }
}
