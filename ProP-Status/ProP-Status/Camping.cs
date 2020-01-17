using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Status
{
    class Camping
    {
        private int id;
        private int availability;

        protected Camping()
        {

        }

        public Camping(int id, int availability)
        {
            this.id = id;
            this.availability = availability;
        }

        public int Id { get { return this.id; } }
        public int Availability { get { return this.availability; } }

        public static List<Camping> GetAllCampingSpots()
        {
            Camping camping = null;
            List<Camping> campingSpots = new List<Camping>();

            DBHelper.connection.Open();

            try
            {
                var command = DBHelper.connection.CreateCommand();
                command.CommandText = "Select id, availability from `camping`";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    camping = new Camping(reader.GetInt32("id"), reader.GetInt32("availability"));
                    campingSpots.Add(camping);
                }

                return campingSpots;
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
    }
}
