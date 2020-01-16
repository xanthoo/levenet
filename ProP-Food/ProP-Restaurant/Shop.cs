using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Restaurant
{
    class Shop
    {
        private List<Food> FoodTypes;
        private int id;
        private string name;

        protected Shop()
        {

        }
        
        public Shop(int id, string name)
        {
            AddFoodTypes();
            this.id = id;
            this.name = name;
        }

        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } }

        public List<Food> GetFoodTypes()
        {
            return FoodTypes;
        }

        private void AddFoodTypes()
        {
            FoodTypes = new List<Food>();
            try
            {
                FoodTypes.Add(new Burger(Food.FromID(1).Id, Food.FromID(1).Name, Food.FromID(1).Price, Food.FromID(1).QuantityOrdered));
                FoodTypes.Add(new Burger(Food.FromID(2).Id, Food.FromID(2).Name, Food.FromID(2).Price, Food.FromID(2).QuantityOrdered));
                FoodTypes.Add(new Burger(Food.FromID(3).Id, Food.FromID(3).Name, Food.FromID(3).Price, Food.FromID(3).QuantityOrdered));
                FoodTypes.Add(new Pizza(Food.FromID(4).Id, Food.FromID(4).Name, Food.FromID(4).Price, Food.FromID(4).QuantityOrdered));
                FoodTypes.Add(new Pizza(Food.FromID(5).Id, Food.FromID(5).Name, Food.FromID(5).Price, Food.FromID(5).QuantityOrdered));
                FoodTypes.Add(new Pizza(Food.FromID(6).Id, Food.FromID(6).Name, Food.FromID(6).Price, Food.FromID(6).QuantityOrdered));
                FoodTypes.Add(new Pizza(Food.FromID(7).Id, Food.FromID(7).Name, Food.FromID(7).Price, Food.FromID(7).QuantityOrdered));
                FoodTypes.Add(new Pizza(Food.FromID(8).Id, Food.FromID(8).Name, Food.FromID(8).Price, Food.FromID(8).QuantityOrdered));
                FoodTypes.Add(new FrenchFries(Food.FromID(9).Id, Food.FromID(9).Name, Food.FromID(9).Price, Food.FromID(9).QuantityOrdered));
                FoodTypes.Add(new FrenchFries(Food.FromID(10).Id, Food.FromID(10).Name, Food.FromID(10).Price, Food.FromID(10).QuantityOrdered));
                FoodTypes.Add(new SoftDrink(Food.FromID(11).Id, Food.FromID(11).Name, Food.FromID(11).Price, Food.FromID(11).QuantityOrdered));
                FoodTypes.Add(new SoftDrink(Food.FromID(12).Id, Food.FromID(12).Name, Food.FromID(12).Price, Food.FromID(12).QuantityOrdered));
                FoodTypes.Add(new SoftDrink(Food.FromID(13).Id, Food.FromID(13).Name, Food.FromID(13).Price, Food.FromID(13).QuantityOrdered));
                FoodTypes.Add(new SoftDrink(Food.FromID(14).Id, Food.FromID(14).Name, Food.FromID(14).Price, Food.FromID(14).QuantityOrdered));
                FoodTypes.Add(new SoftDrink(Food.FromID(15).Id, Food.FromID(15).Name, Food.FromID(15).Price, Food.FromID(15).QuantityOrdered));
                FoodTypes.Add(new SoftDrink(Food.FromID(16).Id, Food.FromID(16).Name, Food.FromID(16).Price, Food.FromID(16).QuantityOrdered));
                FoodTypes.Add(new AlcoholicDrink(Food.FromID(17).Id, Food.FromID(17).Name, Food.FromID(17).Price, Food.FromID(17).QuantityOrdered));
                FoodTypes.Add(new AlcoholicDrink(Food.FromID(18).Id, Food.FromID(18).Name, Food.FromID(18).Price, Food.FromID(18).QuantityOrdered));
                FoodTypes.Add(new AlcoholicDrink(Food.FromID(19).Id, Food.FromID(19).Name, Food.FromID(19).Price, Food.FromID(19).QuantityOrdered));
                FoodTypes.Add(new Desert(Food.FromID(20).Id, Food.FromID(20).Name, Food.FromID(20).Price, Food.FromID(20).QuantityOrdered));
                FoodTypes.Add(new Desert(Food.FromID(21).Id, Food.FromID(21).Name, Food.FromID(21).Price, Food.FromID(21).QuantityOrdered));
                FoodTypes.Add(new Desert(Food.FromID(22).Id, Food.FromID(22).Name, Food.FromID(22).Price, Food.FromID(22).QuantityOrdered));
            }
            catch (NullReferenceException) { }
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

        public List<Food> GetPizzaTypes()
        {
            List<Food> temporary = new List<Food>();

            foreach(Food f in FoodTypes)
            {
                if(f is Pizza)
                {
                    temporary.Add(f);
                }
            }

            return temporary;
        }

        public List<Food> GetFriesTypes()
        {
            List<Food> temporary = new List<Food>();

            foreach(Food f in FoodTypes)
            {
                if(f is FrenchFries)
                {
                    temporary.Add(f);
                }
            }

            return temporary;
        }

        public List<Food> GetSoftDrinksTypes()
        {
            List<Food> temporary = new List<Food>();

            foreach (Food f in FoodTypes)
            {
                if (f is SoftDrink)
                {
                    temporary.Add(f);
                }
            }

            return temporary;
        }

        public List<Food> GetAlcoholicDrinksTypes()
        {
            List<Food> temporary = new List<Food>();

            foreach (Food f in FoodTypes)
            {
                if (f is AlcoholicDrink)
                {
                    temporary.Add(f);
                }
            }

            return temporary;
        }

        public List<Food> GetDesertTypes()
        {
            List<Food> temporary = new List<Food>();

            foreach (Food f in FoodTypes)
            {
                if (f is Desert)
                {
                    temporary.Add(f);
                }
            }

            return temporary;
        }

        public static Shop FromId(int id)
        {
            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "Select * FROM 'shops' s WHERE s.shop_id = @id";
                command.Parameters.AddWithValue("id", id);

                var reader = command.ExecuteReader();

                reader.Read();

                var shop = new Shop { id = reader.GetInt32("shop_id"), name = reader.GetString("shop_name") };

                return shop;
            }
            catch
            {
                return null;
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
    }
}
