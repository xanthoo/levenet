using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EntranceLeavingApp
{
    public class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlConnection connection1;

        public static void initialize()
        {
            String connectioninfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi410674;" +
                                    "user id=dbi410674;" +
                                    "password=asdqwe123;" +
                                    "connect timeout=60;";

            connection = new MySqlConnection(connectioninfo);
            connection1 = new MySqlConnection(connectioninfo);
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
            connection.Open();
            try
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT t.id, t.user_id, t.ticket_type, t.ticket_age_type FROM 'tickets' t WHERE t.id=@id LIMIT =1";
                command.Parameters.AddWithValue("id", qr);
                var reader = command.ExecuteReader();
                reader.Read();
                var ticket = new Ticket(reader.GetInt32("id"), reader.GetInt32("user_id"), reader.GetInt32("ticket_type"), reader.GetString("ticket_age_type"));
                return ticket;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool insertRFIDcodetoDB(string rfid, int rq)
        {
            //bool success = false;


            connection.Open();
            connection1.Open();
            try
            {


                //MySql.Data.MySqlClient.MySqlCommand command;

                //command = connection.CreateCommand();
                //command.CommandText = "Select u.id, u.is_checked_in from `users` u join `tickets` t on(u.id = t.user_id) where t.id = @qr_code LIMIT 1";
                //command.Parameters.AddWithValue("qr_code", rq);

                //var reader = command.ExecuteReader();

                //reader.Read();

                //if (reader.GetInt32("is_checked_in") == 0)
                //{



                    MySql.Data.MySqlClient.MySqlCommand command1;

                    command1 = connection1.CreateCommand();
                    command1.CommandText = "UPDATE `tickets` SET rfid_code = @rfid_code WHERE id = @ticket_id";
                    command1.Parameters.AddWithValue("rfid_code", rfid);
                    command1.Parameters.AddWithValue("ticket_id", rq);

                var reader = command1.ExecuteNonQuery();
                return true;


                //var rows_inserted = command1.ExecuteNonQuery();
                //if (rows_inserted < 1) return false;
                //success = true;

                //MySql.Data.MySqlClient.MySqlCommand command2;

                //command2 = connection1.CreateCommand();
                //command2.CommandText = "Update `users` SET is_checked_in = '1' where id = @user_id";
                //command2.Parameters.AddWithValue("user_id", reader.GetInt32("id"));
                //}
                //return success;



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                connection1.Close();
            }
        }
        
        private static void executeQuery(String query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            connection.Close();
        }

        public static bool checkIn(User user)
        {

            String checkInSQL = "UPDATE 'users' u" +
                $"SET u.is_checked_in ='{1}'" +
                $"WHERE u.id='{user.ID}'"; ;

            //"Select u.id, u.is_checked_in from `users` u join `tickets` t on(u.id = t.user_id) where t.id = @qr_code LIMIT 1"


            try
            {
                executeQuery(checkInSQL);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public static bool setCheckOut(User user)
        {
            String notcheckedQuery = "UPDATE `users` u " +
                                 "SET u.is_checked_in = 0 " +
                                 $"WHERE u.id= '{user.ID}';";

            try
            {
                executeQuery(notcheckedQuery);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool setMinorType(Ticket ticket)
        {
            String changeToMinor = "UPDATE `tickets` t " +
                                 "SET t.ticket_age_type = minor" +
                                 $"WHERE t.id= '{ticket.ID}';";

            try
            {
                executeQuery(changeToMinor);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool checkInCurrentUser(User user)
        {
            String checkInUser = "UPDATE `users` u " +
                             "SET u.is_checked_in = 1, " +
                             $"WHERE u.id= '{user.ID}';";

            try
            {
                executeQuery(checkInUser);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool assignUserToBracelet(String rfidTag, int qrcode)
        {
            String assignUser = "Select * FROM `users` u " +
                         "JOIN `tickets` t ON t.user_id = u.id " +
                         "WHERE t.rfid_code = '" + rfidTag + "'" +
                         "AND t.id= '" + qrcode + "" + "'";

            try
            {
                executeQuery(assignUser);
                return true;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        ////assigning user to qr-code
        //public static void assignUserToQR(string code)
        //{
        //    String assignToQr = "Select * FROM `users` u " +
        //                 "JOIN `tickets` t ON t.user_id = u.id " +
        //                    "WHERE t.id = '" + code + "'";

        //    try
        //    {
        //        executeQuery(assignToQr);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}
