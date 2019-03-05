using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Torsos
{
    class ScaleyTorso : Torso
    {
        public ScaleyTorso() 
            : base (4,Sex.Other,Colors.Red,"Hard as a rock")
        {
        }

        public override void Wave()
        {
            Console.WriteLine(@"Fragile waving \0/");
        }
    }
}
