using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProP_Restaurant
{
    class Burger : Food
    {
        public Burger(int id, string name, double price, int quantityAvailable) : base(id, name, price, quantityAvailable)
        {
        }
    }
}
