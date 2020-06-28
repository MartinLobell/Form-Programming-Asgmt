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
    public class Recipe
    {
        private List<string> m_ingredients;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Ingredients
        {
            get { return m_ingredients; }
            set { m_ingredients = value; }
        }

        public Recipe() { }

        public Recipe(string name, List<string> m_ingredients) {
            Name = name;
            Ingredients = m_ingredients;
        }

        public override string ToString() 
        {
            string str = "";
            for (int i = 0; i < m_ingredients.Count; i++)
            {
                str += m_ingredients[i];
            }

            return name + ": " + str;
        }
    }
}
