using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingEntranceApp
{
    class Camping
    {
        public int ID { get; set; }
        public int Availability { get; set; }

        public Camping(int id, int availability)
        {
            this.ID = id;
            this.Availability = availability;
        }
    }
}
