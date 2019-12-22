using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingApp
{
    public class Item
    {
        public int ID { get; private set; }
        public String Name { get; private set; }
        public decimal PricePerHour { get; private set; }
        public decimal PricePerDay { get; private set; }
        public int BorrowedBy { get; private set; }
        public DateTime BorrowedDate { get; set; }

        public Item(int id, String name, decimal pricePerHour, decimal pricePerDay, int borrowedBy, DateTime borrowedDate)
        {
            this.ID = id;
            this.Name = name;
            this.PricePerHour = pricePerHour;
            this.PricePerDay = pricePerDay;
            this.BorrowedBy = borrowedBy;
            this.BorrowedDate = borrowedDate;
        }

        public override string ToString()
        {
            switch (Name)
            {
                case "polaroid":
                    return "Polaroid";
                case "fridge_box":
                    return "Fridge box";
                case "battery":
                    return "Battery";
                case "adapter":
                    return "Adapter";
                default:
                    return "Unknown";
            }
        }
    }
}
