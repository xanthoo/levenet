using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceLeavingApp
{
    public class User
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public DateTime DoB { get; }
        public decimal Credit { get; }
        public bool HasLoanedItem { get; set; }
        public bool IsCheckedIn { get; set; }

        public User(int id, String name, DateTime dob, decimal credit, bool hasLoanedItem, bool isCheckedIn)
        {
            this.ID = id;
            this.Name = name;
            this.DoB = dob;
            this.Credit = credit;
            this.HasLoanedItem = hasLoanedItem;
            this.IsCheckedIn = isCheckedIn;
        }

        public override String ToString()
        {
            return "ID: " + ID +
                   ", Name: " + Name +
                   ", DoB: " + DoB +
                   ", Credit: " + Credit +
                   ", HasLoanedItem: " + HasLoanedItem +
                   ", IsCheckedIn" + IsCheckedIn;
        }
    }
}
