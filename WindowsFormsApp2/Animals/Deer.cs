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
    class Deer : Mammal
    {
        public double antlerHeight;

        /// <summary>
        /// Deer constructor
        /// </summary>
        public Deer(string name, int age, Gender gender, Category category, int noofteeth, double antlerheight)
            : base(name, age, gender, category, noofteeth)
        {
            antlerHeight = antlerheight;
        }

        public FoodSchedule FoodDescription { get; } = new FoodSchedule();

        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }
        public override FoodSchedule GetFoodSchedule()
        {
            FoodDescription.AddScheduleItem("Morning: Leaves, Lunch: Leaves, Dinner: Leaves");
            return FoodDescription;
        }

        public override string GetSpecies()
        {
            return "Deer";
        }

        /// <summary>
        /// Prints data from animal- and mammal classes and this class' also exclusive data.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Antler height is " + antlerHeight + ".";
        }
    }
}
