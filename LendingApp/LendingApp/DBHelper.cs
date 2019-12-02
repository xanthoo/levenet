using MySql.Data.MySqlClient;
using System;

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
    }
}
