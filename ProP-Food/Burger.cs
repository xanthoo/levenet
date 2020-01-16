using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProP_Restaurant
{
    public class Burger : Food
    {
        public static class DefaultBurgers
        {
            public static readonly Burger Hamburger = new Burger("Hamburger", false, 2.00d, Properties.Resources.Burgers_Hamburger);
            public static readonly Burger Cheeseburger = new Burger("Cheese Burger", false, 2.20d, Properties.Resources.Burgers_Cheeseburger);
            public static readonly Burger Veggieburger = new Burger("Veggie Burger", false, 2.50d, Properties.Resources.Burgers_VeggieBurger);
        }

        public static readonly Image TypeImage = Properties.Resources.Burgers;

        private string name;
        private bool isAlcoholic;
        private double price;
        private Image thumbnail;

        public Burger(string name, bool isAlcoholic, double price, Image thumbnail)
        {
            this.name = name;
            this.isAlcoholic = isAlcoholic;
            this.price = price;
            this.thumbnail = thumbnail;
        }

        public string GetDetails()
        {
            return $"{this.name} is a burger, it costs {this.price:C2}.";
        }
        public string GetName()
        {
            return this.name;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public Image GetThumbnail()
        {
            return this.thumbnail;
        }
        public bool IsAlcoholic()
        {
            return this.isAlcoholic;
        }
        public void SetPrice(double value)
        {
            this.price = value;
        }
    }
}
