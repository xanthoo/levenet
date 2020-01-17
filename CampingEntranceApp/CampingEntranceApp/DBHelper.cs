using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CampingEntranceApp
{
    class DBHelper
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
                int camp_id = -1;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    camp_id= Convert.ToInt32(reader["camp_id"]);
                }

                User user = new User(id, camp_id);

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



        public static Ticket GetTicket(String rfidTag)
        {

            String sql = "Select t.ticket_type FROM `tickets` t " +
                "WHERE t.rfid_code = '" + rfidTag + "'";
            

            Console.WriteLine("SQL: " + sql);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int user_id = -1;
                int ticket_type = -1;

                while (reader.Read())
                {
                    user_id = Convert.ToInt32(reader["user_id"]);
                    ticket_type = Convert.ToInt32(reader["camp_id"]);
                }

                Ticket ticket = new Ticket(user_id, ticket_type);

                Console.WriteLine(ticket);

                return ticket;
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


        public static Camping GetCamping(String rfidTag)
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
                int availability = -1;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    availability = Convert.ToInt32(reader["availability"]);
                }

                Camping camping = new Camping(id, availability);

                Console.WriteLine(camping);

                return camping;
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



        public static bool isEligableForCamp(String rfidtag)
        {
            
            return true;
        }
        
    }
}
