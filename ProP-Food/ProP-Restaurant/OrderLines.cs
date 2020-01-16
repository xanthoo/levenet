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
    public partial class OrderLines : Form
    {
        private Button myButtonsOrderLines;

        private List<Button> orderLinesButtons = new List<Button>();

        public OrderLines()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoTheRefresh();

            int widthOfAButton = 200;
            int heightOfAButton = 200;
            int spaceBetweenButtons = 30;
            int xB = 10;
            int yB = 0;

            foreach (Button b in orderLinesButtons.GetRange(0, orderLinesButtons.Count))
            {
                yB = 10;

                b.Location = new System.Drawing.Point(xB, yB);
                b.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);

                xB = xB + widthOfAButton + spaceBetweenButtons;
            }

            if (orderLinesButtons.Count > 5)
            {
                xB = 10;
                foreach (Button b in orderLinesButtons.GetRange(5, orderLinesButtons.Count - 5))
                {
                    yB = 220;

                    b.Location = new System.Drawing.Point(xB, yB);
                    b.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);

                    xB = xB + widthOfAButton + spaceBetweenButtons;
                }
            }

            if (orderLinesButtons.Count > 10)
            {
                xB = 10;
                foreach (Button b in orderLinesButtons.GetRange(10, orderLinesButtons.Count - 10))
                {

                    yB = 440;

                    b.Location = new System.Drawing.Point(xB, yB);
                    b.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);

                    xB = xB + widthOfAButton + spaceBetweenButtons;
                }
            }

            foreach (Button b in orderLinesButtons)
            {
                this.Controls.Add(b);

                b.Click += (s, e1) => orderLinesButtons.Remove(b);
                b.Click += (s, e1) => this.Controls.Remove(b);
            }
        }

        private void DoTheRefresh()
        {
            foreach (Button b in orderLinesButtons)
            {
                this.Controls.Remove(b);
            }
            orderLinesButtons.Clear();
            AddButtonsToTheList();
        }

        private void AddButtonsToTheList()
        {

            foreach (OrderList ol in OrderList.GetOrderList())
            {
                ol.InsertOrderIn();

                myButtonsOrderLines = new Button();
                myButtonsOrderLines.Text += "Order number: " + ol.orderListId + "\r\n";
                myButtonsOrderLines.Text += "" + "\r\n";
                myButtonsOrderLines.Tag = ol.orderListId;
                myButtonsOrderLines.Visible = true;

                foreach (Order o in ol.OrderLines())
                {
                    foreach (Food f in o.ProductsOrdered())
                    {
                        myButtonsOrderLines.Text += f.Name + " quantity: " + f.QuantityOrdered + "\r\n";
                    }
                }

                myButtonsOrderLines.Click += (s, e1) => OrderList.RemoveOrderList(ol.orderListId);

                //xB = xB + widthOfAButton + spaceBetweenButtons;

                orderLinesButtons.Add(myButtonsOrderLines);
            }
        }
    }
}
