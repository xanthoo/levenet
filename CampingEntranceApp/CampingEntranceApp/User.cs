using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingEntranceApp
{
    class User
    {
        public int ID { get; private set; }
        public int Camp_id { get; set; }

        public User(int id, int camp_id)
        {
            this.ID = id;
            this.Camp_id = camp_id;
        }

        

    }
}
