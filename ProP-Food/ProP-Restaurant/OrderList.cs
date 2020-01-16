using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProP_Restaurant
{
    class OrderList
    {
        private int id;
        List<Order> orderLines;

        public OrderList(int id)
        {
            this.id = id;
            orderLines = new List<Order>();
        }

        public void InsertOrderIn()
        {
            foreach (Order o in Order.GetOrders())
            {
                if (o.OrderId == this.id)
                {
                    orderLines.Add(o);
                }
            }
        }

        public int orderListId { get { return this.id; } }

        public List<Order> OrderLines()
        {
            return this.orderLines;
        }

        public static List<OrderList> GetOrderList()
        {
            OrderList order = null;
            List<OrderList> orderList = new List<OrderList>();
            DBHelper.connection.Open();
            try
            {
                MySql.Data.MySqlClient.MySqlCommand command;

                command = DBHelper.connection.CreateCommand();
                command.CommandText = "Select distinct order_id from order_line";
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    order = new OrderList(reader.GetInt32("order_id"));
                    orderList.Add(order);
                }
                
                return orderList; 
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

        public static bool RemoveOrderList(int id)
        {
            DBHelper.connection.Open();
            try
            {
                MySql.Data.MySqlClient.MySqlCommand command;

                command = DBHelper.connection.CreateCommand();
                command.CommandText = "DELETE FROM order_line WHERE order_id = @id";
                command.Parameters.AddWithValue("id", id);
                var rows_deleted = command.ExecuteNonQuery();
                if (rows_deleted < 1) return false;
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
