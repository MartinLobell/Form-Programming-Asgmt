//Assignment 4
//Martin Lobell
//2020-03-28

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class AnimalManager : ListManager<Animal>
    {
        private int animalIds = 001;

        /// <summary>
        /// Animalmanager constructor, creating new list
        /// </summary>
        public AnimalManager()
        {
            m_list = new List<Animal>();
        }

        public List<Animal> getAnimalList()
        {
            return m_list;
        }

        /// <summary>
        /// Creates a new ID, based on the number of animals there are in the list
        /// Registers the new number of animals in the animalsIds-variable
        /// </summary>
        private string GenerateId(Category category)
        {
            string id;
            if (category == 0)
            {
                id = "Mmml" + animalIds;
                animalIds++;
            }
            else
            {
                id = "Nsct" + animalIds;
                animalIds++;
            }
            return id;
        }

        public void AddAnimal(Animal animal)
        {
            animal.Id = GenerateId(animal.category);
            Add(animal);
        }
    }
}
