using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProP_Status
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
            //AddFoodTypes();
            this.id = id;
            this.name = name;
        }

        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } }

        public List<Food> GetFoodTypes()
        {
            return FoodTypes;
        }

        public static double CalculateTotalMoneyMadePerShop(int id)
        {
            double total = 0;
            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "select Sum(total_price) from `user_order` where shop_id = @id";
                command.Parameters.AddWithValue("id", id);

                var reader = command.ExecuteReader();

                reader.Read();

                total = reader.GetDouble("Sum(total_price)");

                return total;
            }
            catch
            {
                return total;
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }

        public static Shop FromId(int id)
        {
            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "Select * FROM `shops` s WHERE s.shop_id = @id";
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
