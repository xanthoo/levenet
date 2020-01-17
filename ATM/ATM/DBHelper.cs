using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace ATM
{
   public class DBHelper
    {
        private static MySqlConnection connection;
        public DBHelper()
        {
            String connectioninfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi410674;" +
                                    "user id=dbi410674;" +
                                    "password=asdqwe123;" +
                                    "connect timeout=60;";

            connection = new MySqlConnection(connectioninfo);
        }

        public void SaveDepositsData(List<Deposits> listOfDeposits, string startDate, string endDate)
        {

            try
            {
                connection.Open();
                foreach (Deposits deposit in listOfDeposits)
                {
                    String sql = String.Format("INSERT INTO `atm_logs` (`user_id`, `amount`, `bank_nr`, `start_date`, `end_date`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                                                        deposit.AccountNr, deposit.GetMoney(), deposit.GetBankAccount(), startDate, endDate);
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}

