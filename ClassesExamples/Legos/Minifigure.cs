using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples.Legos
{
    class Minifigure
    {
        public Head Head { get; set; }
        public Torso Body { get; set; }
        //Legs

        /// <summary>
        /// Construct a minifigure
        /// </summary>
        /// <param name="head">Takes and instance of Head, the base class for all heads.
        /// Because all heads inherit from Head any head can be passed in to the minifigure.</param>
        /// <param name="body">Takes an instance of Torso, the base class for all Torsos.  Because all heads inherit from this,
        /// any head can be passed in to the minifigure.</param>
        public Minifigure(Head head, Torso body)
        {
            Head = head;
            Body = body;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}

        public void Greet()
        {
            Body.Wave();

            //Will not work, Torso doesn't have a Crunch() method, only FitTorso does
            //Body.Crunch();
            
            Head.Talk();
        }
    }
}
