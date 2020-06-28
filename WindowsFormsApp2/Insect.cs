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
    abstract class Insect : Animal
    {
        public int noOfEyes;

        public Insect()
        {
            noOfEyes = 0;
        }

        /// <summary>
        /// Insect constructor
        /// </summary>
        public Insect(string name, int age, Gender gender, Category category, int noofeyes)
            : base(name, age, gender, category)
        {
            noOfEyes = noofeyes;
        }

        /// <summary>
        /// Prints data from animal class and also exclusive number of eyes.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Has " + noOfEyes + " eyes. ";
        }
        
    }
}
