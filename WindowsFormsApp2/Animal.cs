//Assignment 4
//Martin Lobell
//2020-04-27

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Interfaces;

namespace WindowsFormsApp2
{

    [Serializable]
    public abstract class Animal : IAnimal
    {
        protected string id;
        public string name;
        public int age;
        public Gender gender;
        public Category category;

        /// <summary>
        /// Default animal constructor
        /// </summary>
        public Animal()
        {
            Name = "No name";
            Age = 0;
        }

        /// <summary>
        /// Animal constructor
        /// </summary>
        public Animal(string name, int age, Gender gender, Category category)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Category = category;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        string IAnimal.name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAnimal.id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Gender IAnimal.gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract EaterType GetEaterType();

        public abstract FoodSchedule GetFoodSchedule();

        public abstract string GetSpecies();


        /// <summary>
        /// Returns string with data contained in base (this) class
        /// </summary>
        public override string ToString()
        {
            return id + ", " + name + ", " + age + ", " + gender + ", ";
        }

        EaterType IAnimal.GetEaterType()
        {
            throw new NotImplementedException();
        }

        FoodSchedule IAnimal.GetFoodSchedule()
        {
            throw new NotImplementedException();
        }

        string IAnimal.GetSpecies()
        {
            throw new NotImplementedException();
        }
    }
}
