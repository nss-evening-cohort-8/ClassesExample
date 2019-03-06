using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;

namespace ClassesExamples.Legos.Legs
{
    abstract class LegsBase
    {
        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        protected LegsBase(Length length, Colors color)
        {
            Length = length;
            Color = color;
        }

        public virtual void Jump()
        {
            Console.WriteLine("WEEEEEEEEEEEE!!!!!!!!");
        }

        public void Kick(Minifigure personToKick)
        {
            Console.WriteLine($"{personToKick.Name} just got kicked by {GetType().Name}. Ha Ha Ha.  " +
                              $"You're not even a scientist.");
        }

        public void Walk()
        {
            Console.WriteLine($"{GetType().Name} took a few steps.");
        }

    }

    enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}
