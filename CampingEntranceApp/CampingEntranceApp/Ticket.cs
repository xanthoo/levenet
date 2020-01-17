using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingEntranceApp
{
    class Ticket
    {
        public int UserId;
        public int TicketType;

        public Ticket(int userId, int ticketType)
        {
            this.UserId = userId;
            this.TicketType = ticketType;
        }


    }
}
