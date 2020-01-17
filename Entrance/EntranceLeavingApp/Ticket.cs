using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceLeavingApp
{
    public class Ticket
    {
        public int ID { get; set; }
        public int UserId;
        public int TicketType;
        public String TicketAgeType;

        public Ticket(int id, int userId, int ticketType,  string ticketAgeType)
        {
            this.ID = id;
            this.UserId = userId;
            this.TicketType = ticketType;
            this.TicketAgeType = ticketAgeType;
        }


    }
}
