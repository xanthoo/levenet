using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProP_Restaurant.Controls.CreateOrder;

namespace ProP_Restaurant.Controls
{
    public partial class SelectType : UserControl
    {
        public delegate void MenuHelper(Control menu);

        public event MenuHelper Menu_Selected;

        public SelectType()
        {
            InitializeComponent();

            var btn = new Button();

            btn.Text = "Burgers";
            btn.Image = Burger.TypeImage;
            btn.Size = new Size(300, 206);

            btn.Click += (s, e) => this.Menu_Selected?.Invoke(new SelectBurger(new Burger[] { Burger.DefaultBurgers.Hamburger, Burger.DefaultBurgers.Cheeseburger, Burger.DefaultBurgers.Veggieburger }));

            this.pnTypeButtons.Controls.Add(btn);
        }
    }
}
