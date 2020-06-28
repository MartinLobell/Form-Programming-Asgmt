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
    class Cat : Mammal
    {
        public int whiskerAmount;

        /// <summary>
        /// Cat constructor
        /// </summary>
        public Cat(string name, int age, Gender gender, Category category, int noofteeth, int whiskeramount)
            : base(name, age, gender, category, noofteeth)
        {
            whiskerAmount = whiskeramount;
        }

        public FoodSchedule FoodDescription { get; } = new FoodSchedule();

        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }
        public override FoodSchedule GetFoodSchedule()
        {
            FoodDescription.AddScheduleItem("Morning: Milk, Lunch: Pellets, Dinner: Mice");
            return FoodDescription;
        }

        public override string GetSpecies()
        {
            return "Cat";
        }

        /// <summary>
        /// Prints data from animal- and mammal classes and this class' also exclusive data.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Amount of whiskers is " + whiskerAmount + ".";
        }
    }
}
