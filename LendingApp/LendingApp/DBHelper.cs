using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LendingApp
{
    public class DBHelper
    { 
        private static MySqlConnection connection;

        public static void initialize()
        {
            String connectioninfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi410674;" +
                                    "user id=dbi410674;" +
                                    "password=asdqwe123;" +
                                    "connect timeout=60;";

            connection = new MySqlConnection(connectioninfo);
        }

        public static User getUser(String rfidTag)
        {
            String sql = "Select * FROM `users` u " +
                         "JOIN `tickets` t ON t.user_id = u.id " +
                         "WHERE t.rfid_code = '" + rfidTag + "'";

            Console.WriteLine("SQL: " + sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int id = -1;
                String name = "";
                DateTime dob = new DateTime();
                decimal credit = 0;
                int hasLoanedItem = -1;
                bool loanedItem = false;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]);
                    dob = Convert.ToDateTime(reader["dob"]);
                    credit = Convert.ToDecimal(reader["credit"]);
                    hasLoanedItem = Convert.ToInt32(reader["has_loaned_item"]);

                    if (hasLoanedItem != 0) { loanedItem = true; }
                }

                User user = new User(id, name, dob, credit, loanedItem);

                Console.WriteLine(user);

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Item getItemInfo(string type)
        {
            String itemSql = "Select * FROM `items` i " +
                         $"WHERE i.name = '{type}' " +
                         "AND i.borrowed_by IS NULL;";

            Console.WriteLine("SQL: " + itemSql);

            MySqlCommand command = new MySqlCommand(itemSql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int id = -1;
                String name = "";
                decimal pricePerHour = 0;
                decimal pricePerDay = 0;
                int borrowedBy = -1;
                DateTime borrowedDate = DateTime.MinValue;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["item_id"]);
                    name = Convert.ToString(reader["name"]);
                    pricePerHour = Convert.ToDecimal(reader["price_per_Hour"]);
                    pricePerDay = Convert.ToDecimal(reader["price_per_day"]);

                    if(reader["borrowed_by"] != DBNull.Value)
                    {
                        borrowedBy = Convert.ToInt32(reader["borrowed_by"]);
                    }
                    else
                    {
                        borrowedBy = 10;
                    }
                }

                Item item = new Item(id, name, pricePerHour, pricePerDay, borrowedBy, borrowedDate);

                Console.WriteLine(item);

                return item;
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);

                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Item> getLoanedItems(int userID)
        {
            String getItemsSQL = "Select * FROM `items` i " +
                         $"WHERE i.borrowed_by = '{userID}';";

            Console.WriteLine("SQL: " + getItemsSQL);

            MySqlCommand command = new MySqlCommand(getItemsSQL, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int id = -1;
                String name = "";
                decimal pricePerHour = 0;
                decimal pricePerDay = 0;
                int borrowedBy = -1;
                DateTime borrowedDate = DateTime.MinValue;

                List<Item> loanedItems = new List<Item>();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["item_id"]);
                    name = Convert.ToString(reader["name"]);
                    pricePerHour = Convert.ToDecimal(reader["price_per_Hour"]);
                    pricePerDay = Convert.ToDecimal(reader["price_per_day"]);
                    borrowedBy = Convert.ToInt32(reader["borrowed_by"]);
                    borrowedDate = Convert.ToDateTime(reader["borrowed_date"]);

                    Item currentItem = new Item(id, name, pricePerHour, pricePerDay, borrowedBy, borrowedDate);

                    Console.WriteLine(currentItem);

                    loanedItems.Add(currentItem);
                }

                return loanedItems;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool borrowItem(Item item, User user)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm";

            String borrowItemSQL = "UPDATE `items` i " +
                             $"SET i.borrowed_by = '{user.ID}', i.borrowed_date = '" + time.ToString(format) + "' " +
                             $"WHERE i.item_id = '{item.ID}';";

            try
            {
                executeQuery(borrowItemSQL);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool setHasLoanedItem(User user)
        {
            String itemLoan = "UPDATE `users` u " +
                             $"SET u.has_loaned_item = 1 " +
                             $"WHERE u.id= '{user.ID}';";

            try
            {
                executeQuery(itemLoan);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private static void executeQuery(String query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            connection.Close();          
        }
    }
}
