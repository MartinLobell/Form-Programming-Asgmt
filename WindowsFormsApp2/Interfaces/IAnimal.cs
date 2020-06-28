//Assignment 4
//Martin Lobell
//2020-04-27

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Interfaces
{

    /// <summary>
    /// Interface för animal-klassen
    /// Innehållandes de egenskaper (variabler som gäller för basklassen animal
    /// samt de abstrakta metoder som ska användas av species-klasserna
    /// </summary>
    public interface IAnimal
    {
        string name { get; set; }
        string id { get; set;  }
        Gender gender { get; set; }

        EaterType GetEaterType();

        FoodSchedule GetFoodSchedule();

        string GetSpecies();
    }
}
