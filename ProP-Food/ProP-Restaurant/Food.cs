using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Restaurant
{
    class Food
    {
        private int id;
        private double price;
        private string name;
        private int quantityAvailable;

        private int quantityOrdered;

        protected Food()
        {

        }

        public Food(int id, string name, double price, int quantityAvailable)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantityAvailable = quantityAvailable;
            quantityOrdered = 0;
        }

        protected Food(double price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } }
        public double Price { get { return this.price; } }
        public int QuantityOrdered { get { return this.quantityOrdered; } set { this.quantityOrdered = value; } }

        public double FinalPrice()
        {
            double finalPrice = price * QuantityOrdered;
            return finalPrice;
        }
        public override string ToString()
        {
            return "You ordered " + this.quantityOrdered + " " + this.name + ". The cost is " + FinalPrice().ToString("C");
        }

        public static Food FromID(int id)
        {
            try
            {  
                DBHelper.connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Connect to cisco and restart the application.");
            }

            try
            {
                var command = DBHelper.connection.CreateCommand();

                command.CommandText = "Select * FROM `products` p WHERE p.product_id = @id LIMIT 1";

                command.Parameters.AddWithValue("id", id);

                var reader = command.ExecuteReader();

                reader.Read();
                var food = new Food
                {
                    id = reader.GetInt32("product_id"),
                    name = reader.GetString("name"),
                    price = reader.GetDouble("price"),
                    quantityAvailable = reader.GetInt32("quantity_available"),
                };

                return food;
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

        public bool UpdateQuantityAvailable(int quantityOrdered)
        {
            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "UPDATE `products` p SET p.quantity_available = p.quantity_available - @quantityOrdered WHERE p.product_id = @product_id";
                command.Parameters.AddWithValue("quantityOrdered", quantityOrdered);
                command.Parameters.AddWithValue("product_id", this.id);

                var rows_updated = command.ExecuteNonQuery();
                if (rows_updated < 1) return false;

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
    }
}
