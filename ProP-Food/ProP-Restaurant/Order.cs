using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Restaurant
{
    class Order
    { 
        private int orderId;
        //private int productId;
        //private int quantity;

        List<Food> foodOrdered;
        private Food[] products;

        public Order()
        {
            foodOrdered = new List<Food>();
            this.orderId = Order.GetOrderId();
        }

        public Order(int id, Food[] products)
        {
            this.orderId = id;
            this.products = products;
        }

        public int OrderId { get { return this.orderId; } }
        //public int ProductId { get { return this.productId; } }
        //public int Quantity { get { return this.quantity; } }

        public List<Food> OrderedFood()
        {
            return this.foodOrdered;
        }

        public Food[] ProductsOrdered()
        {
            return this.products;
        }
        public bool CreateOrder(double totalPrice, int userId, int shopId)
        {
            bool success = true;
            DBHelper.connection.Open();
            try
            {
                MySql.Data.MySqlClient.MySqlCommand command;

                command = DBHelper.connection.CreateCommand();
                command.CommandText = "INSERT INTO user_order(order_id, total_price, date, user_id, shop_id) VALUES(@order_id, @totalPrice, @date, @userId, @shopId)";
                command.Parameters.AddWithValue("order_id", this.orderId);
                command.Parameters.AddWithValue("totalPrice", totalPrice);
                command.Parameters.AddWithValue("date", DateTime.Now);
                command.Parameters.AddWithValue("userId", userId);
                command.Parameters.AddWithValue("shopId", shopId);
                var rows_inserted = command.ExecuteNonQuery();
                if (rows_inserted < 1) return false;
                success = true;

                return success;
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

        public bool CreateOrderLine(int productId, int quantity)
        {
            bool success = true;
            DBHelper.connection.Open();
            try
            {
                MySql.Data.MySqlClient.MySqlCommand command;

                command = DBHelper.connection.CreateCommand();
                command.CommandText = "INSERT INTO order_line(order_id, product_id, quantity) VALUES(@order_id, @product_id, @quantity)";
                command.Parameters.AddWithValue("order_id", this.orderId);
                command.Parameters.AddWithValue("product_id", productId);
                command.Parameters.AddWithValue("quantity", quantity);
                var rows_inserted = command.ExecuteNonQuery();
                if (rows_inserted < 1) return false;
                success = true;

                return success;
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

        public static int GetOrderId()
        {
            int OrderId = -1;
            DBHelper.connection.Open();
            try
            {
                MySql.Data.MySqlClient.MySqlCommand command;

                command = DBHelper.connection.CreateCommand();
                command.CommandText = "Select order_id from user_order order by order_id desc LIMIT 1";
                var reader = command.ExecuteReader();

                reader.Read();

                return OrderId = reader.GetInt32("order_id") + 1;
            }
            catch
            {
                return OrderId;
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }

        public static Order[] GetOrders()
        {
            Food food = null;
            Food[] products = null;
            Order order = null;
            List<Order> orders = new List<Order>();

            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "Select ol.order_id, p.product_id, p.name, p.price, p.quantity_available, ol.quantity FROM `order_line` ol join `products` p on p.product_id = ol.product_id";
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    food = new Food(reader.GetInt32("product_id"), reader.GetString("name"), reader.GetDouble("price"), reader.GetInt32("quantity_available"));
                    food.QuantityOrdered = reader.GetInt32("quantity");
                    products = new Food[] { food };

                    order = new Order(reader.GetInt32("order_id"), products);
                    orders.Add(order);
                }

                return orders.ToArray();
            }
            catch
            {
                return new Order[0];
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
    }
}
