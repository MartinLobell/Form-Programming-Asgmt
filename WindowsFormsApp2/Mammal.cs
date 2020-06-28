//Assignment 4
//Martin Lobell
//2020-04-27

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]

    abstract class Mammal : Animal
    {
        public int noOfTeeth;

        public Mammal()
        {
            noOfTeeth = 0;
        }

        /// <summary>
        /// Mammal constructor
        /// </summary>
        public Mammal(string name, int age, Gender gender, Category category, int noofteeth)
            : base(name, age, gender, category)
        {
            noOfTeeth = noofteeth;
        }

        /// <summary>
        /// Prints data from animal class and also exclusive number of teeth.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Has " + noOfTeeth + " teeth. ";
        }
    }
}
