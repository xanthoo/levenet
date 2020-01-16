using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProP_Restaurant
{
    class FrenchFries : Food
    {
        public FrenchFries(int id, string name, double price, int quantityAvailable) : base(id, name, price, quantityAvailable)
        {
        }
    }
}
