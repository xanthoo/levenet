using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProP_Restaurant
{
    class Shop
    {
        private List<Food> FoodTypes;
        private string name;
        
        public Shop(string name)
        {
            FoodTypes = new List<Food>();
        }

        public List<Food> GetBurgerTypes()
        {
            List<Food> temporary = new List<Food>();

            foreach(Food f in FoodTypes)
            {
                if(f is Burger)
                {
                    temporary.Add(f);
                }
            }

            return temporary;
        }
    }
}
