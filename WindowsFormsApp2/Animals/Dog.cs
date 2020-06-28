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
    class Dog : Mammal
    {
        public double tailLength;

        /// <summary>
        /// Dog constructor
        /// </summary>
        public Dog(string name, int age, Gender gender, Category category, int noofteeth, double taillength)
            : base(name, age, gender, category, noofteeth)
        {
            tailLength = taillength;
        }

        public FoodSchedule FoodDescription { get; } = new FoodSchedule();

        /// <summary>
        /// Returnerar djurets ättyp-enum
        /// </summary>
        /// <returns></returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Omnivore;
        }

        /// <summary>
        ///  Här skrivs matinstruktionerna in och läggs ihop till en matschema som returneras
        ///  Instruktionerna kan bestå av en eller flera strängar, jag har valt att formatera det som en.
        /// </summary>
        /// <returns></returns>
        public override FoodSchedule GetFoodSchedule()
        {
            FoodDescription.AddScheduleItem("Morning: Dry, Lunch: Meat with processed sour milk, Dinner: More dry");
            return FoodDescription;
        }

        /// <summary>
        ///  Returnerar en sträng som talar om djurets art
        /// </summary>
        /// <returns></returns>
        public override string GetSpecies()
        {
            return "Dog";
        }

        /// <summary>
        /// Prints data from animal- and mammal classes and this class' also exclusive data.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Tail length is " + tailLength + ".";
        }
    }
}
