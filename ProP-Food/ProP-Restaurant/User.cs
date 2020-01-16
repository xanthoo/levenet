using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Restaurant
{
    public class User
    {
        public class InsuficientMoneyException : Exception { public InsuficientMoneyException() : base("The visitor has insuficient money in his account.") { } }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public DateTime DoB { get; private set; }
        public double Credit { get; private set; }
        public bool HasLoanedItem { get; set; }

        protected User()
        {

        }
        public User(int id, String name, DateTime dob, double credit, bool hasLoanedItem) : this()
        {
            this.ID = id;
            this.Name = name;
            this.DoB = dob;
            this.Credit = credit;
            this.HasLoanedItem = hasLoanedItem;
        }

        public static User FromID(int id)
        {
            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();

                command.CommandText = "Select * FROM `users` u WHERE u.id = @id LIMIT 1";

                command.Parameters.AddWithValue("id", id);
                
                var reader = command.ExecuteReader();
                
                reader.Read();
                var user = new User
                {
                    ID = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    DoB = reader.GetDateTime("dob"),
                    Credit = reader.GetDouble("credit"),
                    HasLoanedItem = reader.GetBoolean("has_loaned_item")
                };
                
                return user;
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
        public static User FromRFID(string rfid)
        {
            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "Select * FROM `users` u JOIN `tickets` t ON t.user_id = u.id WHERE t.rfid_code = @rfid";
                command.Parameters.AddWithValue("rfid", rfid);

                var reader = command.ExecuteReader();

                reader.Read();
                var user = new User
                {
                    ID = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    DoB = reader.GetDateTime("dob"),
                    Credit = reader.GetDouble("credit"),
                    HasLoanedItem = reader.GetBoolean("has_loaned_item")
                };
                
                return user;
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

        public bool Charge(double amount)
        {
            if (this.Credit < amount) throw new InsuficientMoneyException();

            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "UPDATE `users` u SET u.credit = u.credit - @amount WHERE u.id = @id";
                command.Parameters.AddWithValue("amount", amount);
                command.Parameters.AddWithValue("id", this.ID);

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

        public override String ToString()
        {
            return "ID: " + ID +
                   ", Name: " + Name +
                   ", DoB: " + DoB +
                   ", Credit: " + Credit +
                   ", HasLoanedItem: " + HasLoanedItem;
        }
    }
}
