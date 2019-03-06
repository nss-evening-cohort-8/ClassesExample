using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Legs
{
    class PegLeg : LegsBase
    {
        public PegLeg(Length legLength) 
            : base(legLength, Colors.Tan)
        {
        }

        public override void Jump()
        {
            Console.WriteLine($"The {(Hairy ? "hairy " : "")}peg legs don't jump.");
        }


    }
}
