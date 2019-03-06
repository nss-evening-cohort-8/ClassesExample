using System;
using System.Collections.Generic;
using System.Text;
using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Legs;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples.Legos
{
    class Minifigure
    {

        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public LegsBase Legs { get; set; }

        /// <summary>
        /// Construct a minifigure
        /// </summary>
        /// <param name="name">The name of the MiniFigure</param>
        /// <param name="head">Takes and instance of Head, the base class for all heads.
        /// Because all heads inherit from Head any head can be passed in to the minifigure.</param>
        /// <param name="body">Takes an instance of Torso, the base class for all Torsos.  Because all heads inherit from this,
        /// any head can be passed in to the minifigure.</param>
        public Minifigure(string name, Head head, Torso body, LegsBase legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}

        public void Greet()
        {
            Legs.Walk();

            Body.Wave();

            //Will not work, Torso doesn't have a Crunch() method, only FitTorso does
            //Body.Crunch();
            
            Head.Talk();
        }
    }
}
