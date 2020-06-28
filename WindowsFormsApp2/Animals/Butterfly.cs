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
    class Butterfly : Insect
    {
        public int wingStrokesPerMinute;

        /// <summary>
        /// Butterfly constructor
        /// </summary>
        public Butterfly(string name, int age, Gender gender, Category category, int noofeyes, int wingstrokesperminute)
            : base(name, age, gender, category, noofeyes)
        {
            wingStrokesPerMinute = wingstrokesperminute;
        }

        public FoodSchedule FoodDescription { get; } = new FoodSchedule();

        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }
        public override FoodSchedule GetFoodSchedule()
        {
            FoodDescription.AddScheduleItem("Morning: Nectar, Lunch: Air, Dinner: Nectar");
            return FoodDescription;
        }

        public override string GetSpecies()
        {
            return "Butterfly";
        }

        /// <summary>
        /// Prints data from animal- and insect classes and this class' also exclusive data.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Strikes " + wingStrokesPerMinute + " wingstrokes per minute.";
        }
    }
}
