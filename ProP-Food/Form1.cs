using ProP_Restaurant.Controls;
using ProP_Restaurant.Controls.CreateOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Restaurant
{ 
    public partial class Form1 : Form
    {
        Order o;
        List<Food> OrderList = new List<Food>();
        private Shop myShop;

        public Form1()
        {
            InitializeComponent();

            pnlOrderDetails.Visible = false;
            btnEatIn.Location = new Point(465, 210);
            myShop = new Shop("L'event");
        }

        void SetMenu(AnchorStyles anchor, Size size, Point location, Control menu)
        {
            menu.Anchor = anchor;
            menu.Size = size;
            menu.Location = location;

            switch (menu)
            {
                case SelectType st:
                    st.Menu_Selected += (sel) =>
                    {
                        SetMenu(menu.Anchor, menu.Size, menu.Location, sel);
                        this.Controls.Remove(st);
                    };

                    this.Controls.Add(st);
                    break;
                case SelectBurger sb:
                    sb.Cancelled += () =>
                    {
                        SetMenu(menu.Anchor, menu.Size, menu.Location, new SelectType());
                        this.Controls.Remove(sb);
                    };
                    sb.Burger_Selected += (burger) => MessageBox.Show("do something here");

                    this.Controls.Add(sb);
                    break;
            }
        }

        private void btnEatIn_Click(object sender, EventArgs e)
        {
            pnlOrderDetails.Visible = true;

            this.SetMenu(this.pnMenuSelect.Anchor, this.pnMenuSelect.Size, this.pnMenuSelect.Location, new SelectType());
            this.Controls.Remove(this.pnMenuSelect);

            this.Controls.Remove(btnEatIn);
        }
    }
}
