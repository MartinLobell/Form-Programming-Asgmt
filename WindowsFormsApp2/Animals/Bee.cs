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
    class Bee : Insect
    {
        public int stingSharpness;

        /// <summary>
        /// Bee constructor
        /// </summary>
        public Bee(string name, int age, Gender gender, Category category, int noofeyes, int stingsharpness)
            : base(name, age, gender, category, noofeyes)
        {
            stingSharpness = stingsharpness;
        }

        public FoodSchedule FoodDescription { get; } = new FoodSchedule();

        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }
        public override FoodSchedule GetFoodSchedule()
        {
            FoodDescription.AddScheduleItem("Morning: Honey, Lunch: Nectar, Dinner: Air");
            return FoodDescription;
        }

        public override string GetSpecies()
        {
            return "Bee";
        }

        /// <summary>
        /// Prints data from animal- and insect classes and this class' also exclusive data.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Sting is " + stingSharpness + " units sharp.";
        }
    }
}
