using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Restaurant.Controls.CreateOrder
{
    public partial class SelectBurger : UserControl
    {
        public delegate void BurgerHandler(Burger burger);

        public event BurgerHandler Burger_Selected;
        public event Action Cancelled;

        public SelectBurger(Burger[] available_burgers)
        {
            InitializeComponent();

            foreach (Burger burger in available_burgers)
            {
                var btn = new Button();

                btn.Text = burger.GetName() + "   " + burger.GetPrice().ToString("C2");
                btn.Size = new Size(300, 206);
                btn.Image = burger.GetThumbnail();

                btn.Click += (s, e) => this.Burger_Selected?.Invoke(burger);

                this.pnBurgerButtons.Controls.Add(btn);
            }

            this.btCancel.Click += (s, e) => this.Cancelled?.Invoke();
        }
    }
}
