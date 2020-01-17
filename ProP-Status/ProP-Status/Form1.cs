using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProP_Status
{
    public partial class Form1 : Form
    {
        List<Food> burgerList = new List<Food>();
        List<Food> pizzaList = new List<Food>();
        List<Food> friesList = new List<Food>();
        List<Food> softDrinkList = new List<Food>();
        List<Food> alcoholicDrinkList = new List<Food>();
        List<Food> desertList = new List<Food>();

        List<Shop> shopList = new List<Shop>();

        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            MakeFoodQuantityFunctionalityInvisible();
            MakeTotalMoneyPerShopInvisible();
            MakeCampingSpotsFunctionalityInvisible();
            MakeUserStatisticsChartInvisible();

            AddItemsToTheFoodLists();
            AddItemsToTheShopList();
        }

        private void btnShowFoodQuantity_Click(object sender, EventArgs e)
        {
            MakeFoodQuantityFunctionalityVisible();
            MakeTotalMoneyPerShopInvisible();
            MakeCampingSpotsFunctionalityInvisible();
            MakeUserStatisticsChartInvisible();
        }

        private void btnMoneyPerShop_Click(object sender, EventArgs e)
        {
            MakeTotalMoneyPerShopVisible();
            MakeFoodQuantityFunctionalityInvisible();
            MakeCampingSpotsFunctionalityInvisible();
            MakeUserStatisticsChartInvisible();

            ClearTheChart(chMoneyPerShop);

            AddShopsToTheChart(shopList);
        }

        private void btnCampingSpots_Click(object sender, EventArgs e)
        {
            MakeCampingSpotsFunctionalityVisible();
            MakeTotalMoneyPerShopInvisible();
            MakeFoodQuantityFunctionalityInvisible();
            MakeUserStatisticsChartInvisible();

            ClearTheChart(chCampingSpots);

            AddCampingSpotsToTheChart(Camping.GetAllCampingSpots());
        }

        private void btnUsersOverview_Click(object sender, EventArgs e)
        {
            MakeCampingSpotsFunctionalityInvisible();
            MakeTotalMoneyPerShopInvisible();
            MakeFoodQuantityFunctionalityInvisible();
            MakeUserStatisticsChartVisible();

            ClearTheChart(chUsersMoney);
            lblUsersCheckedIn.Text = "Amount of visitors checked-in: " + User.CountCheckedInUsers().ToString();
            lblAllUsers.Text = "Amount of visitors to attend the event: " + User.CountAllUsers().ToString();

            chUsersMoney.Series["Money"].Points.AddXY("Balance: " + User.TotalBallanceOfUsers().ToString("C"), User.TotalBallanceOfUsers());

            double total = User.CalculateTotalMoneySpentOnFood() + 0; //where instead of 0 should a double representing the total money spent on loaned items
            chUsersMoney.Series["Money"].Points.AddXY("Money spent: " + total.ToString("C"), total);
        }

        private void rbBurgers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBurgers.Checked)
            {
                ClearTheChart(chFoodQuantity);

                AddFoodToTheChart(burgerList);
                Food.CheckIfQuantityIsNotCritical(burgerList);

                rbBurgers.Checked = false;
            }
        }


        private void rbPizzas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPizzas.Checked)
            {
                ClearTheChart(chFoodQuantity);

                AddFoodToTheChart(pizzaList);
                Food.CheckIfQuantityIsNotCritical(pizzaList);

                rbPizzas.Checked = false;
            }
        }

        private void rbFries_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFries.Checked)
            {
                ClearTheChart(chFoodQuantity);

                AddFoodToTheChart(friesList);
                Food.CheckIfQuantityIsNotCritical(friesList);

                rbFries.Checked = false;
            }
        }

        private void rbSoftDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSoftDrinks.Checked)
            {
                ClearTheChart(chFoodQuantity);

                AddFoodToTheChart(softDrinkList);
                Food.CheckIfQuantityIsNotCritical(softDrinkList);

                rbSoftDrinks.Checked = false;
            }
        }

        private void rbAlcoholicDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlcoholicDrinks.Checked)
            {
                ClearTheChart(chFoodQuantity);

                AddFoodToTheChart(alcoholicDrinkList);
                Food.CheckIfQuantityIsNotCritical(alcoholicDrinkList);

                rbAlcoholicDrinks.Checked = false;
            }
        }

        private void rbDeserts_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeserts.Checked)
            {
                ClearTheChart(chFoodQuantity);

                AddFoodToTheChart(desertList);
                Food.CheckIfQuantityIsNotCritical(desertList);

                rbDeserts.Checked = false;
            }
        }

        private void ClearTheChart(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
        }

        private void MakeFoodQuantityFunctionalityVisible()
        {
            this.chFoodQuantity.Location = new Point(66, 129);
            this.chFoodQuantity.Size = new Size(1368, 649);

            rbBurgers.Location = new Point(248, 93);
            rbPizzas.Location = new Point(339, 93);
            rbFries.Location = new Point(416, 93);
            rbSoftDrinks.Location = new Point(488, 93);
            rbAlcoholicDrinks.Location = new Point(588, 93);
            rbDeserts.Location = new Point(704, 93);

            this.chFoodQuantity.Visible = true;

            this.rbBurgers.Visible = true;
            this.rbPizzas.Visible = true;
            this.rbFries.Visible = true;
            this.rbSoftDrinks.Visible = true;
            this.rbAlcoholicDrinks.Visible = true;
            this.rbDeserts.Visible = true;
        }

        private void MakeFoodQuantityFunctionalityInvisible()
        {
            this.chFoodQuantity.Visible = false;

            this.rbBurgers.Visible = false;
            this.rbPizzas.Visible = false;
            this.rbFries.Visible = false;
            this.rbSoftDrinks.Visible = false;
            this.rbAlcoholicDrinks.Visible = false;
            this.rbDeserts.Visible = false;
        }

        private void MakeTotalMoneyPerShopVisible()
        {
            this.chMoneyPerShop.Location = new Point(66, 129);
            this.chMoneyPerShop.Size = new Size(1368, 649);

            this.chMoneyPerShop.Visible = true;
        }

        private void MakeTotalMoneyPerShopInvisible()
        {
            this.chMoneyPerShop.Visible = false;
        }

        private void MakeUserStatisticsChartVisible()
        {
            this.chUsersMoney.Location = new Point(100, 220);
            this.chUsersMoney.Size = new Size(1000, 500);

            this.lblAllUsers.Visible = true;
            this.lblUsersCheckedIn.Visible = true;
            this.chUsersMoney.Visible = true;
        }

        private void MakeUserStatisticsChartInvisible()
        {
            this.lblAllUsers.Visible = false;
            this.lblUsersCheckedIn.Visible = false;
            this.chUsersMoney.Visible = false;
        }

        private void MakeCampingSpotsFunctionalityVisible()
        {
            this.chCampingSpots.Location = new Point(66, 129);
            this.chCampingSpots.Size = new Size(1368, 649);

            this.chCampingSpots.Visible = true;
        }

        private void MakeCampingSpotsFunctionalityInvisible()
        {
            this.chCampingSpots.Visible = false;
        }

        private void AddItemsToTheFoodLists()
        {

            //Adding burgers to the list
            burgerList.Add(Food.FromID(1));
            burgerList.Add(Food.FromID(2));
            burgerList.Add(Food.FromID(3));

            //Adding pizzas to the list
            pizzaList.Add(Food.FromID(4));
            pizzaList.Add(Food.FromID(5));
            pizzaList.Add(Food.FromID(6));
            pizzaList.Add(Food.FromID(7));
            pizzaList.Add(Food.FromID(8));

            //Adding fries to the list
            friesList.Add(Food.FromID(9));
            friesList.Add(Food.FromID(10));

            //Adding soft drinks to the list
            softDrinkList.Add(Food.FromID(11));
            softDrinkList.Add(Food.FromID(12));
            softDrinkList.Add(Food.FromID(13));
            softDrinkList.Add(Food.FromID(14));
            softDrinkList.Add(Food.FromID(15));
            softDrinkList.Add(Food.FromID(16));

            //Adding alcoholic drinks to the list
            alcoholicDrinkList.Add(Food.FromID(17));
            alcoholicDrinkList.Add(Food.FromID(18));
            alcoholicDrinkList.Add(Food.FromID(19));

            //Adding deserts to the list
            desertList.Add(Food.FromID(20));
            desertList.Add(Food.FromID(21));
            desertList.Add(Food.FromID(22));
        }

        private void AddItemsToTheShopList()
        {
            shopList.Add(Shop.FromId(1));
            shopList.Add(Shop.FromId(2));
        }

        private void AddFoodToTheChart(List<Food> foodList)
        {
            foreach (Food f in foodList)
            {
                this.chFoodQuantity.Series["Quantity"].Points.AddXY(f.Name + "\r\n" + f.QuantityAvailable, f.QuantityAvailable);
            }
        }

        private void AddShopsToTheChart(List<Shop> shopList)
        {
            foreach(Shop s in shopList)
            {
                if (s.Id == 1)
                {
                    this.chMoneyPerShop.Series["Money"].Points.AddXY(s.Name + "\r\n" + Shop.CalculateTotalMoneyMadePerShop(1).ToString("C"), Shop.CalculateTotalMoneyMadePerShop(1));
                }

                if(s.Id == 2)
                {
                    this.chMoneyPerShop.Series["Money"].Points.AddXY(s.Name + "\r\n" + Shop.CalculateTotalMoneyMadePerShop(2).ToString("C"), Shop.CalculateTotalMoneyMadePerShop(2));
                }
            }
        }

        private void AddCampingSpotsToTheChart(List<Camping> campingList)
        {
            this.chCampingSpots.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            var x_axis = this.chCampingSpots.ChartAreas[0].Axes[0];
            var y_axis = this.chCampingSpots.ChartAreas[0].Axes[1];

            x_axis.Interval = 1;
            y_axis.Interval = 1;
            y_axis.Maximum = 6;

            foreach (Camping c in campingList)
            {
                this.chCampingSpots.Series["Availability"].Points.AddXY("Camping id: " + c.Id, c.Availability);
            }
        }
    }
}
