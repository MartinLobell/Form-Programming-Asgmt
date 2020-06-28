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
    public class RecipeManager : ListManager<Recipe>
    {
        public List<Recipe> m_foodList;

        public RecipeManager()
        {
            m_foodList = new List<Recipe>();
        }
    }
}
