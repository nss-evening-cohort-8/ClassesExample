using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    abstract class Head
    {
        public HairLength HairLength { get; protected set; }
        public Colors Color { get; protected set; }
        public string EarSize { get; protected set; }

        public virtual string Talk()
        {
            return "I'm a talking head.";
        }
    }
}
