using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProP_Restaurant
{
    class AlcoholicDrink : Food
    {
        public AlcoholicDrink(int id, string name, double price, int quantityAvailable) : base(id, name, price, quantityAvailable)
        {
        }
    }
}
