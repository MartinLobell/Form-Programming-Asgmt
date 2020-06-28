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
    class Lion : Mammal
    {
        public int maneAwesomeness;

        /// <summary>
        /// Lion constructor
        /// </summary>
        public Lion(string name, int age, Gender gender, Category category, int noofteeth, int maneawesomeness)
            : base(name, age, gender, category, noofteeth)
        {
            maneAwesomeness = maneawesomeness;
        }

        public FoodSchedule FoodDescription { get; } = new FoodSchedule();

        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }
        public override FoodSchedule GetFoodSchedule()
        {
            FoodDescription.AddScheduleItem("Morning: Meat, Lunch: Meat, Dinner: Steak (meat)");
            return FoodDescription;
        }

        public override string GetSpecies()
        {
            return "Lion";
        }


        /// <summary>
        /// Prints data from animal- and mammal classes and this class' also exclusive data.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Mane awesomeness is " + maneAwesomeness + ".";
        }
    }
}
