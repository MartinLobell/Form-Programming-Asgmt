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
    public class FoodSchedule
    {

        public List<string> FoodDescriptionList;

        /// <summary>
        /// Konstruktor som bildar en ny lista innehållandes textsträngar med instruktioner
        /// </summary>
        public FoodSchedule()
        {
            FoodDescriptionList = new List<string>();
        }

        public int Count
        {
            get
            {
                if ((FoodDescriptionList != null))
                {
                    return FoodDescriptionList.Count;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Lägger till den/de sträng(ar) som utgör matschema för ett särskilt djur
        /// returnerar antalet objekt i listan
        /// </summary>
        /// <param name="scheduleItem"></param>
        /// <returns></returns>
        public int AddScheduleItem(string scheduleItem)
        {

            FoodDescriptionList.Add(scheduleItem);
            return FoodDescriptionList.Count;
        }

        public string GetFoodSchedule(int i)
        {
            if (ValidateIndex(i))
            {
                return FoodDescriptionList[i];
            }
            else
            {
                return null;
            }
        }



        public bool ValidateIndex(int index)
        {
            bool ok;
            if ((index < 0) & (index > FoodDescriptionList.Count))
            {
                ok = false;
            }
            else
            {
                ok = true;
            }
            return ok;
        }
    }
}
