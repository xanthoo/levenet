using System;
using MySql.Data.MySqlClient;

namespace EntranceLeavingApp
{
    public class DBHelper
    {
        private static MySqlConnection connection;

        public static void Initialize()
        {
            String connectioninfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi410674;" +
                                    "user id=dbi410674;" +
                                    "password=asdqwe123;" +
                                    "connect timeout=60;";

            connection = new MySqlConnection(connectioninfo);
        }

        public static User GetUser(String rfidTag)
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
                int checkedIn = -1;
                bool ischeckedIn = false;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]);
                    dob = Convert.ToDateTime(reader["dob"]);
                    credit = Convert.ToDecimal(reader["credit"]);
                    hasLoanedItem = Convert.ToInt32(reader["has_loaned_item"]);
                    checkedIn = Convert.ToInt32(reader["is_checked_in"]);
                    if (hasLoanedItem != 0) { loanedItem = true; }
                    if (checkedIn != 0) { ischeckedIn = true; }
                }

                User user = new User(id, name, dob, credit, loanedItem, ischeckedIn);

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

        public static Ticket TicketFromQR(int qr)
        {
            int id = 0;
            int user_id = 0;
            int ticket_type = 0;
            String ticket_age_type = "";

            connection.Open();
            try
            {
                var query = connection.CreateCommand();
                query.CommandText = $"SELECT t.id, t.user_id, t.ticket_type, t.ticket_age_type FROM tickets t WHERE t.id={qr} LIMIT 1;";
                var reader = query.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    user_id = Convert.ToInt32(reader["user_id"]);
                    ticket_type = Convert.ToInt32(reader["ticket_type"]);
                    ticket_age_type = Convert.ToString(reader["ticket_age_type"]);
                }

                var ticket = new Ticket(id, user_id, ticket_type, ticket_age_type);
                return ticket;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AssignTagToTicket(string rfid, int rq)
        {
            connection.Open();
            try
            {
                MySqlCommand query;

                query = connection.CreateCommand();
                query.CommandText = "UPDATE `tickets` SET rfid_code = @rfid_code WHERE id = @ticket_id";
                query.Parameters.AddWithValue("rfid_code", rfid);
                query.Parameters.AddWithValue("ticket_id", rq);

                var reader = query.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        
        private static void ExecuteQuery(String query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();

            connection.Close();
        }

        public static bool CheckInUser(User user)
        {
            String query = $"UPDATE users u SET u.is_checked_in = 1 WHERE u.id = {user.ID} ;";

            try
            {
                ExecuteQuery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckOutUser(User user)
        {
            String query = $"UPDATE users u SET u.is_checked_in = 0 WHERE u.id = {user.ID} ;";

            try
            {
                ExecuteQuery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ChangeToMinor(Ticket ticket)
        {
            String changeToMinor = "UPDATE tickets t SET t.ticket_age_type = 'minor' " +
                                 $"WHERE t.id= '{ticket.ID}';";

            try
            {
                ExecuteQuery(changeToMinor);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
