using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace ProP_Restaurant
{
    public partial class Form1 : Form
    {
        private Shop myShop;
        private Shop myShop1 = new Shop(1, "Levent Shop One");
        private Shop myShop2 = new Shop(2, "Levent Shop Two");
        private RFID rfid;
        private Order myOrder;

        private OrderLines orderLines;

        private List<Button> burgerButtons = new List<Button>();
        private List<Button> pizzaButtons = new List<Button>();
        private List<Button> friesButtons = new List<Button>();
        private List<Button> softDrinksButtons = new List<Button>();
        private List<Button> alcoholicDrinksButtons = new List<Button>();
        private List<Button> desertButtons = new List<Button>();

        private Button CancellButton;
        private Button SwitchButton;

        private Button myButtonsBurgers;
        private Button myButtonsPizzas;
        private Button myButtonsSoftDrinks;
        private Button myButtonsFries;
        private Button myButtonsAlcoholicDrinks;
        private Button myButtonsDeserts;

        private Food selectedFood;
        private int toSwitch = 0;

        Font myFont = new Font("Verdana", 14);

        public Form1()
        {
            InitializeComponent();
            this.Text = "L'event";
            MakeOrderDetailsAndManipulationInvisible();
            StartingButtonsLocation();
            MakeFoodButtonsInvisible();
            MakeBurgerLabelsInvisible();
            MakePizzaLabelsInvisible();
            MakeFriesLabelsInvisible();
            MakeSoftDrinksLabelsInvisible();
            MakeAlcoholicDrinksLabelsInvisible();
            MakeDesertsLabelsInvisible();
            MakeQuantityFunctionalityInvisible();
            MakeTheProceedOrderFunctionalityInvisible();
            MakeTheProceedToPaymentFunctionalityInvisible();

            pnlSelectShop.Location = new Point(425, 100);
            rbShopOne.Checked = true;
        }

        private void btnEatIn_Click(object sender, EventArgs e)
        {
            MakeTheStartButtonInvisible();
            MakeFoodButtonsVisible();
            MakeOrderDetailsAndManipulationVisible();

            if (rbShopOne.Checked)
            {
                myShop = myShop1;
                this.Text = myShop1.Name;
            }

            if (rbShopTwo.Checked)
            {
                myShop = myShop2;
                this.Text = myShop2.Name;
            }

            if (myShop.GetFoodTypes().Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel the order?", "Attention message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Food f in myShop.GetFoodTypes())
                {
                    f.QuantityOrdered = 0;
                }

                UpdateTotalCostLabel();
                UpdateTotalAmountOfProducts();

                MakeAlcoholicDrinksButtonsInvisible();
                MakeBurgerButtonsInvisible();
                MakeDesertButtonsInvisible();
                MakeFriesButtonsInvisible();
                MakePizzaButtonsInvisible();
                MakeSoftDrinksButtonsInvisible();
                MakeFoodButtonsInvisible();
                MakeQuantityFunctionalityInvisible();
                MakeTheProceedOrderFunctionalityInvisible();
                MakeTheProceedToPaymentFunctionalityInvisible();

                if (SwitchButton != null)
                {
                    SwitchButton.Visible = false;
                }
                if (CancellButton != null)
                {
                    CancellButton.Visible = false;
                }

                MakeAlcoholicDrinksLabelsInvisible();
                MakeBurgerLabelsInvisible();
                MakeDesertsLabelsInvisible();
                MakeFriesLabelsInvisible();
                MakePizzaLabelsInvisible();
                MakeSoftDrinksLabelsInvisible();

                MakeOrderDetailsAndManipulationInvisible();

                MakeTheStartButtonVisible();
            }
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            MakeFoodButtonsInvisible();
            if (CancellButton == null)
            {
                MakeTheCancelButton();
            }
            else
            {
                CancellButton.Visible = true;
            }
            MakeQuantityFunctionalityVisible();

            if (myButtonsBurgers == null)
            {
                int widthOfAButton = 300, heightOfAButton = 206;
                int spaceBetweenButtons = 60;
                int xB = 60;
                int yB = 190;

                foreach (Food f in this.myShop.GetBurgerTypes())
                {

                    myButtonsBurgers = new Button();
                    myButtonsBurgers.Location = new System.Drawing.Point(xB, yB);
                    myButtonsBurgers.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                    myButtonsBurgers.Text = "";
                    myButtonsBurgers.Tag = f.Price;
                    myButtonsBurgers.Visible = true;

                    if (f.Name.Contains("Hamburger"))
                    {
                        myButtonsBurgers.Image = ProP_Restaurant.Properties.Resources.hamburger_resized;
                        myButtonsBurgers.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsBurgers.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsBurgers.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsBurgers.Click += (s, e1) => MakeTheQuantityOne();

                        lblHamburger.Visible = true;
                        lblHamburger.Text = "Hamburger " + f.Price.ToString("C");
                        lblHamburger.Location = new Point(80, 400);
                        lblHamburger.Font = myFont;
                        burgerButtons.Add(myButtonsBurgers);
                    }
                    if (f.Name.Contains("Cheeseburger"))
                    {
                        myButtonsBurgers.Image = ProP_Restaurant.Properties.Resources.cheeseburger_resized;
                        myButtonsBurgers.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsBurgers.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsBurgers.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsBurgers.Click += (s, e1) => MakeTheQuantityOne();

                        lblCheeseburger.Visible = true;
                        lblCheeseburger.Text = "Cheeseburger " + f.Price.ToString("C");
                        lblCheeseburger.Location = new Point(440, 400);
                        lblCheeseburger.Font = myFont;
                        burgerButtons.Add(myButtonsBurgers);
                    }
                    if (f.Name.Contains("Veggieburger"))
                    {
                        myButtonsBurgers.Image = ProP_Restaurant.Properties.Resources.Veggie_Burger_resized;
                        myButtonsBurgers.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsBurgers.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsBurgers.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsBurgers.Click += (s, e1) => MakeTheQuantityOne();

                        lblVeggieBurger.Visible = true;
                        lblVeggieBurger.Text = f.Name + " " + f.Price.ToString("C");
                        lblVeggieBurger.Location = new Point(800, 400);
                        lblVeggieBurger.Font = myFont;
                        burgerButtons.Add(myButtonsBurgers);
                    }

                    this.Controls.Add(myButtonsBurgers);

                    xB = xB + widthOfAButton + spaceBetweenButtons;
                }
            }
            else
            {
                foreach (Button b in burgerButtons)
                {
                    b.Visible = true;
                }
                lblHamburger.Visible = true;
                lblCheeseburger.Visible = true;
                lblVeggieBurger.Visible = true;
            }
        }


        private void btnPizza_Click(object sender, EventArgs e)
        {
            MakeFoodButtonsInvisible();

            if (SwitchButton == null)
            {
                MakeTheSwitchButton();
            }
            else
            {
                SwitchButton.Visible = true;
            }

            if (CancellButton == null)
            {
                MakeTheCancelButton();
            }
            else
            {
                CancellButton.Visible = true;
            }
            CancellButton.Click += (s, e1) => SwitchButton.Visible = false;
            MakeQuantityFunctionalityVisible();


            if (myButtonsPizzas == null)
            {
                int widthOfAButton = 300, heightOfAButton = 206;
                int spaceBetweenButtons = 60;
                int xB = 60;
                int yB = 190;

                foreach (Food f in this.myShop.GetPizzaTypes())
                {
                    myButtonsPizzas = new Button();
                    myButtonsPizzas.Location = new System.Drawing.Point(xB, yB);
                    myButtonsPizzas.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                    myButtonsPizzas.Text = "";
                    myButtonsPizzas.Tag = f.Price;
                    myButtonsPizzas.Visible = true;

                    if (f.Name.Contains("Prosciutto"))
                    {
                        myButtonsPizzas.Image = ProP_Restaurant.Properties.Resources.prosciutto_resized;
                        myButtonsPizzas.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsPizzas.Name = "Prosciutto";
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsPizzas.Click += (s, e1) => MakeTheQuantityOne();

                        pizzaButtons.Add(myButtonsPizzas);

                        lblProsciutto.Text = f.Name + " " + f.Price.ToString("C");
                        lblProsciutto.Visible = true;
                        lblProsciutto.Location = new Point(80, 400);
                        lblProsciutto.Font = myFont;

                    }

                    if (f.Name.Contains("Diavola"))
                    {
                        myButtonsPizzas.Image = ProP_Restaurant.Properties.Resources.diavola_resized;
                        myButtonsPizzas.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsPizzas.Name = "Diavola";
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsPizzas.Click += (s, e1) => MakeTheQuantityOne();

                        pizzaButtons.Add(myButtonsPizzas);

                        lblDiavola.Text = f.Name + " " + f.Price.ToString("C");
                        lblDiavola.Visible = true;
                        lblDiavola.Location = new Point(470, 400);
                        lblDiavola.Font = myFont;
                    }

                    if (f.Name.Contains("Romana"))
                    {
                        myButtonsPizzas.Image = ProP_Restaurant.Properties.Resources.romana_resized;
                        myButtonsPizzas.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsPizzas.Name = "Romana";
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsPizzas.Click += (s, e1) => MakeTheQuantityOne();

                        pizzaButtons.Add(myButtonsPizzas);

                        lblRomana.Text = f.Name + " " + f.Price.ToString("C");
                        lblRomana.Visible = true;
                        lblRomana.Location = new Point(830, 400);
                        lblRomana.Font = myFont;
                    }

                    if (f.Name.Contains("Americana"))
                    {
                        myButtonsPizzas.Image = ProP_Restaurant.Properties.Resources.americana_resized;
                        myButtonsPizzas.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsPizzas.Name = "Americana";
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsPizzas.Click += (s, e1) => MakeTheQuantityOne();

                        pizzaButtons.Add(myButtonsPizzas);

                        lblAmericana.Text = f.Name + " " + f.Price.ToString("C");
                        lblAmericana.Visible = false;
                        lblAmericana.Location = new Point(450, 400);
                        lblAmericana.Font = myFont;
                    }

                    if (f.Name.Contains("Tonno"))
                    {
                        myButtonsPizzas.Image = ProP_Restaurant.Properties.Resources.tonno_resized;
                        myButtonsPizzas.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsPizzas.Name = "Tonno";
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsPizzas.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsPizzas.Click += (s, e1) => MakeTheQuantityOne();
                        pizzaButtons.Add(myButtonsPizzas);

                        lblTonno.Text = f.Name + " " + f.Price.ToString("C");
                        lblTonno.Visible = false;
                        lblTonno.Location = new Point(110, 400);
                        lblTonno.Font = myFont;
                    }

                    this.Controls.Add(myButtonsPizzas);

                    xB = xB + widthOfAButton + spaceBetweenButtons;

                }
            }
            else
            {
                foreach (Button b in pizzaButtons)
                {
                    b.Visible = true;
                }
                lblProsciutto.Visible = true;
                lblDiavola.Visible = true;
                lblRomana.Visible = true;
                lblTonno.Visible = false;
                lblAmericana.Visible = false;
            }
            GetPizzaButton("Tonno").Visible = false;
            GetPizzaButton("Americana").Visible = false;
        }

        private void btnSoftDrinks_Click(object sender, EventArgs e)
        {
            MakeFoodButtonsInvisible();

            if (SwitchButton == null)
            {
                MakeTheSwitchButton();
            }
            else
            {
                SwitchButton.Visible = true;
            }

            if (CancellButton == null)
            {
                MakeTheCancelButton();
            }
            else
            {
                CancellButton.Visible = true;
            }
            CancellButton.Click += (s, e1) => SwitchButton.Visible = false;
            MakeQuantityFunctionalityVisible();

            if (myButtonsSoftDrinks == null)
            {
                int widthOfAButton = 300, heightOfAButton = 206;
                int spaceBetweenButtons = 60;
                int xB = 60;
                int yB = 190;

                foreach (Food f in this.myShop.GetSoftDrinksTypes())
                {
                    myButtonsSoftDrinks = new Button();
                    myButtonsSoftDrinks.Location = new System.Drawing.Point(xB, yB);
                    myButtonsSoftDrinks.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                    myButtonsSoftDrinks.Text = "";
                    myButtonsSoftDrinks.Tag = f.Price;
                    myButtonsSoftDrinks.Visible = true;

                    if (f.Name.Contains("Coca Cola"))
                    {
                        myButtonsSoftDrinks.Image = ProP_Restaurant.Properties.Resources.CocaColaCan_resized;
                        myButtonsSoftDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsSoftDrinks.Name = "CocaCola";
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsSoftDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        softDrinksButtons.Add(myButtonsSoftDrinks);

                        lblCocaCola.Text = f.Name + " " + f.Price.ToString("C");
                        lblCocaCola.Visible = true;
                        lblCocaCola.Location = new Point(80, 400);
                        lblCocaCola.Font = myFont;
                    }

                    if (f.Name.Contains("Pepsi"))
                    {
                        myButtonsSoftDrinks.Image = ProP_Restaurant.Properties.Resources.PepsiCan_Cropped_resized;
                        myButtonsSoftDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsSoftDrinks.Name = "Pepsi";
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsSoftDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        softDrinksButtons.Add(myButtonsSoftDrinks);

                        lblPepsi.Text = f.Name + " " + f.Price.ToString("C");
                        lblPepsi.Visible = true;
                        lblPepsi.Location = new Point(470, 400);
                        lblPepsi.Font = myFont;
                    }

                    if (f.Name.Contains("Fanta"))
                    {
                        myButtonsSoftDrinks.Image = ProP_Restaurant.Properties.Resources.FantaCan_resized;
                        myButtonsSoftDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsSoftDrinks.Name = "Fanta";
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsSoftDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        softDrinksButtons.Add(myButtonsSoftDrinks);

                        lblFanta.Text = f.Name + " " + f.Price.ToString("C");
                        lblFanta.Visible = true;
                        lblFanta.Location = new Point(830, 400);
                        lblFanta.Font = myFont;
                    }

                    if (f.Name.Contains("Dr Pepper"))
                    {
                        myButtonsSoftDrinks.Image = ProP_Restaurant.Properties.Resources.DrPepperCan_resized;
                        myButtonsSoftDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsSoftDrinks.Name = "DrPepper";
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsSoftDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        softDrinksButtons.Add(myButtonsSoftDrinks);

                        lblDrPepper.Text = f.Name + " " + f.Price.ToString("C");
                        lblDrPepper.Visible = true;
                        lblDrPepper.Location = new Point(80, 400);
                        lblDrPepper.Font = myFont;
                    }

                    if (f.Name.Contains("Sprite"))
                    {
                        myButtonsSoftDrinks.Image = ProP_Restaurant.Properties.Resources.SpriteCan_resized;
                        myButtonsSoftDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsSoftDrinks.Name = "Sprite";
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsSoftDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        softDrinksButtons.Add(myButtonsSoftDrinks);

                        lblSprite.Text = f.Name + " " + f.Price.ToString("C");
                        lblSprite.Visible = true;
                        lblSprite.Location = new Point(830, 400);
                        lblSprite.Font = myFont;
                    }

                    if (f.Name.Contains("7Up"))
                    {
                        myButtonsSoftDrinks.Image = ProP_Restaurant.Properties.Resources._7UpCan_resized;
                        myButtonsSoftDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsSoftDrinks.Name = "SevenUp";
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsSoftDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsSoftDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        softDrinksButtons.Add(myButtonsSoftDrinks);

                        lbl7Up.Text = f.Name + " " + f.Price.ToString("C");
                        lbl7Up.Visible = false;
                        lbl7Up.Location = new Point(470, 400);
                        lbl7Up.Font = myFont;
                    }

                    this.Controls.Add(myButtonsSoftDrinks);

                    xB = xB + widthOfAButton + spaceBetweenButtons;
                }
            }
            else
            {
                foreach (Button b in softDrinksButtons)
                {
                    b.Visible = true;
                }
                lblCocaCola.Visible = true;
                lblPepsi.Visible = true;
                lblFanta.Visible = true;
                lblDrPepper.Visible = false;
                lblSprite.Visible = false;
                lbl7Up.Visible = false;
            }
            GetSoftDrinksButton("SevenUp").Visible = false;
            GetSoftDrinksButton("DrPepper").Visible = false;
            GetSoftDrinksButton("Sprite").Visible = false;
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            MakeFoodButtonsInvisible();
            if (CancellButton == null)
            {
                MakeTheCancelButton();
            }
            else
            {
                CancellButton.Visible = true;
            }
            MakeQuantityFunctionalityVisible();

            if (myButtonsFries == null)
            {
                int widthOfAButton = 300, heightOfAButton = 206;
                int spaceBetweenButtons = 60;
                int xB = 60;
                int yB = 190;

                foreach (Food f in myShop.GetFriesTypes())
                {
                    myButtonsFries = new Button();
                    myButtonsFries.Location = new System.Drawing.Point(xB, yB);
                    myButtonsFries.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                    myButtonsFries.Text = "";
                    myButtonsFries.Tag = f.Price;
                    myButtonsFries.Visible = true;

                    if (f.Name.Contains("Small Fries"))
                    {
                        myButtonsFries.Image = ProP_Restaurant.Properties.Resources.fries_resized;
                        myButtonsFries.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsFries.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsFries.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsFries.Click += (s, e1) => MakeTheQuantityOne();
                        friesButtons.Add(myButtonsFries);

                        lblSmallFries.Text = f.Name + " " + f.Price.ToString("C");
                        lblSmallFries.Visible = true;
                        lblSmallFries.Location = new Point(80, 400);
                        lblSmallFries.Font = myFont;
                    }

                    if (f.Name.Contains("Big Fries"))
                    {
                        myButtonsFries.Image = ProP_Restaurant.Properties.Resources.fries_resized;
                        myButtonsFries.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsFries.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsFries.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsFries.Click += (s, e1) => MakeTheQuantityOne();
                        friesButtons.Add(myButtonsFries);

                        lblBigFries.Text = f.Name + " " + f.Price.ToString("C");
                        lblBigFries.Visible = true;
                        lblBigFries.Location = new Point(470, 400);
                        lblBigFries.Font = myFont;
                    }

                    this.Controls.Add(myButtonsFries);
                    xB = xB + widthOfAButton + spaceBetweenButtons;
                }
            }
            else
            {
                foreach (Button b in friesButtons)
                {
                    b.Visible = true;
                }

                lblSmallFries.Visible = true;
                lblBigFries.Visible = true;
            }
        }

        private void btnAlcoholicDrinks_Click(object sender, EventArgs e)
        {
            MakeFoodButtonsInvisible();
            if (CancellButton == null)
            {
                MakeTheCancelButton();
            }
            else
            {
                CancellButton.Visible = true;
            }
            MakeQuantityFunctionalityVisible();

            if (myButtonsAlcoholicDrinks == null)
            {
                int widthOfAButton = 300, heightOfAButton = 206;
                int spaceBetweenButtons = 60;
                int xB = 60;
                int yB = 190;

                foreach (Food f in myShop.GetAlcoholicDrinksTypes())
                {
                    myButtonsAlcoholicDrinks = new Button();
                    myButtonsAlcoholicDrinks.Location = new System.Drawing.Point(xB, yB);
                    myButtonsAlcoholicDrinks.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                    myButtonsAlcoholicDrinks.Text = "";
                    myButtonsAlcoholicDrinks.Tag = f.Price;
                    myButtonsAlcoholicDrinks.Visible = true;

                    if (f.Name.Contains("Levent Beer"))
                    {
                        myButtonsAlcoholicDrinks.Image = ProP_Restaurant.Properties.Resources.LeventBeer_resized;
                        myButtonsAlcoholicDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsAlcoholicDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsAlcoholicDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsAlcoholicDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        alcoholicDrinksButtons.Add(myButtonsAlcoholicDrinks);

                        lblLeventBeer.Text = f.Name + " " + f.Price.ToString("C");
                        lblLeventBeer.Visible = true;
                        lblLeventBeer.Location = new Point(80, 400);
                        lblLeventBeer.Font = myFont;
                    }

                    if (f.Name.Contains("Mojito"))
                    {
                        myButtonsAlcoholicDrinks.Image = ProP_Restaurant.Properties.Resources.Mojito_resized;
                        myButtonsAlcoholicDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsAlcoholicDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsAlcoholicDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsAlcoholicDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        alcoholicDrinksButtons.Add(myButtonsAlcoholicDrinks);

                        lblMojito.Text = f.Name + " " + f.Price.ToString("C");
                        lblMojito.Visible = true;
                        lblMojito.Location = new Point(470, 400);
                        lblMojito.Font = myFont;
                    }

                    if (f.Name.Contains("Kir Royale"))
                    {
                        myButtonsAlcoholicDrinks.Image = ProP_Restaurant.Properties.Resources.KirRoyale_resized;
                        myButtonsAlcoholicDrinks.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsAlcoholicDrinks.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsAlcoholicDrinks.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsAlcoholicDrinks.Click += (s, e1) => MakeTheQuantityOne();
                        alcoholicDrinksButtons.Add(myButtonsAlcoholicDrinks);

                        lblKirRoyale.Text = f.Name + " " + f.Price.ToString("C");
                        lblKirRoyale.Visible = true;
                        lblKirRoyale.Location = new Point(810, 400);
                        lblKirRoyale.Font = myFont;
                    }

                    this.Controls.Add(myButtonsAlcoholicDrinks);

                    xB = xB + widthOfAButton + spaceBetweenButtons;
                }
            }
            else
            {
                foreach (Button b in alcoholicDrinksButtons)
                {
                    b.Visible = true;
                }

                lblLeventBeer.Visible = true;
                lblMojito.Visible = true;
                lblKirRoyale.Visible = true;
            }
        }
        private void btnDesert_Click(object sender, EventArgs e)
        {
            MakeFoodButtonsInvisible();
            if (CancellButton == null)
            {
                MakeTheCancelButton();
            }
            else
            {
                CancellButton.Visible = true;
            }
            MakeQuantityFunctionalityVisible();

            if (myButtonsDeserts == null)
            {
                int widthOfAButton = 300, heightOfAButton = 206;
                int spaceBetweenButtons = 60;
                int xB = 60;
                int yB = 190;

                foreach (Food f in myShop.GetDesertTypes())
                {
                    myButtonsDeserts = new Button();
                    myButtonsDeserts.Location = new System.Drawing.Point(xB, yB);
                    myButtonsDeserts.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                    myButtonsDeserts.Text = "";
                    myButtonsDeserts.Tag = f.Price;
                    myButtonsDeserts.Visible = true;

                    if (f.Name.Contains("Cheese Cake"))
                    {
                        myButtonsDeserts.Image = ProP_Restaurant.Properties.Resources.CheeseCake_resized;
                        myButtonsDeserts.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsDeserts.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsDeserts.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsDeserts.Click += (s, e1) => MakeTheQuantityOne();
                        desertButtons.Add(myButtonsDeserts);

                        lblCheeseCake.Text = f.Name + " " + f.Price.ToString("C");
                        lblCheeseCake.Visible = true;
                        lblCheeseCake.Location = new Point(80, 400);
                        lblCheeseCake.Font = myFont;
                    }

                    if (f.Name.Contains("Tiramisu"))
                    {
                        myButtonsDeserts.Image = ProP_Restaurant.Properties.Resources.Tiramisu_resized;
                        myButtonsDeserts.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsDeserts.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsDeserts.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsDeserts.Click += (s, e1) => MakeTheQuantityOne();
                        desertButtons.Add(myButtonsDeserts);

                        lblTiramisu.Text = f.Name + " " + f.Price.ToString("C");
                        lblTiramisu.Visible = true;
                        lblTiramisu.Location = new Point(460, 400);
                        lblTiramisu.Font = myFont;
                    }

                    if (f.Name.Contains("Ice Cream"))
                    {
                        myButtonsDeserts.Image = ProP_Restaurant.Properties.Resources.IceCream_resized;
                        myButtonsDeserts.Click += (s, e1) => f.QuantityOrdered += int.Parse(lblQuantity.Text);
                        myButtonsDeserts.Click += (s, e1) => UpdateTotalCostLabel();
                        myButtonsDeserts.Click += (s, e1) => UpdateTotalAmountOfProducts();
                        myButtonsDeserts.Click += (s, e1) => MakeTheQuantityOne();
                        desertButtons.Add(myButtonsDeserts);

                        lblIceCream.Text = f.Name + " " + f.Price.ToString("C");
                        lblIceCream.Visible = true;
                        lblIceCream.Location = new Point(810, 400);
                        lblIceCream.Font = myFont;
                    }

                    this.Controls.Add(myButtonsDeserts);

                    xB = xB + widthOfAButton + spaceBetweenButtons;
                }
            }
            else
            {
                foreach (Button b in desertButtons)
                {
                    b.Visible = true;
                }

                lblIceCream.Visible = true;
                lblTiramisu.Visible = true;
                lblCheeseCake.Visible = true;
            }
        }


        private void MakeTheCancelButton()
        {
            CancellButton = new Button();
            int widthOfAButton = 250, heightOfAButton = 50;
            int x = 10;
            int y = 20;

            CancellButton.Location = new System.Drawing.Point(x, y);
            CancellButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            CancellButton.Text = "Back";
            CancellButton.BackColor = Color.Firebrick;
            CancellButton.ForeColor = Color.White;
            CancellButton.Font = myFont;

            CancellButton.Click += (s, e) => MakeBurgerButtonsInvisible();
            CancellButton.Click += (s, e) => MakePizzaButtonsInvisible();
            CancellButton.Click += (s, e) => MakeFriesButtonsInvisible();
            CancellButton.Click += (s, e) => MakeSoftDrinksButtonsInvisible();
            CancellButton.Click += (s, e) => MakeAlcoholicDrinksButtonsInvisible();
            CancellButton.Click += (s, e) => MakeDesertButtonsInvisible();

            CancellButton.Click += (s, e) => MakeBurgerLabelsInvisible();
            CancellButton.Click += (s, e) => MakePizzaLabelsInvisible();
            CancellButton.Click += (s, e) => MakeFriesLabelsInvisible();
            CancellButton.Click += (s, e) => MakeSoftDrinksLabelsInvisible();
            CancellButton.Click += (s, e) => MakeAlcoholicDrinksLabelsInvisible();
            CancellButton.Click += (s, e) => MakeDesertsLabelsInvisible();

            CancellButton.Click += (s, e) => MakeFoodButtonsVisible();
            CancellButton.Click += (s, e) => MakeTheProceedOrderFunctionalityInvisible();
            CancellButton.Click += (s, e) => MakeQuantityFunctionalityInvisible();
            CancellButton.Click += (s, e) => MakeTheProceedToPaymentFunctionalityInvisible();

            CancellButton.Click += (s, e) => MakeOrderDetailsAndManipulationVisible();
            CancellButton.Click += (s, e) => lblQuantity.Text = 1.ToString();
            CancellButton.Click += (s, e) => toSwitch = 0;

            CancellButton.Click += (s, e) => CancellButton.Visible = false;

            this.Controls.Add(CancellButton);
        }

        private void MakeTheSwitchButton()
        {
            SwitchButton = new Button();
            int widthOfAButton = 100, heightOfAButton = 50;
            int x = 520;
            int y = 445;

            SwitchButton.Location = new System.Drawing.Point(x, y);
            SwitchButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
            SwitchButton.Text = ">>";
            SwitchButton.Name = "SwitchButton";
            SwitchButton.ForeColor = Color.White;
            SwitchButton.Visible = true;
            SwitchButton.BackColor = Color.Firebrick;
            SwitchButton.Font = myFont;

            SwitchButton.Click += (s, e) => SwitchSoftDrinksButtonsBetweenVisibleAndInvisible();
            SwitchButton.Click += (s, e) => SwitchPizzaButtonsBetweenVisibleAndInvisible();

            this.Controls.Add(SwitchButton);
        }

        private void MakeTheQuantityOne()
        {
            lblQuantity.Text = "1";
        }

        private void MakeTheStartButtonInvisible()
        {
            btnEatIn.Visible = false;
            pnlSelectShop.Visible = false;
        }

        private void MakeTheStartButtonVisible()
        {
            btnEatIn.Visible = true;
        }

        private void MakeOrderDetailsAndManipulationInvisible()
        {
            btnCancelOrder.Visible = false;
            btnFinishOrder.Visible = false;
            lblTotalCost.Visible = false;
            lblAmountOfProducts.Visible = false;
        }

        private void MakeOrderDetailsAndManipulationVisible()
        {
            btnCancelOrder.Visible = true;
            btnFinishOrder.Visible = true;
            lblTotalCost.Visible = true;
            lblAmountOfProducts.Visible = true;
        }

        private void MakeTheProceedOrderFunctionalityInvisible()
        {
            lbOrderDetails.Visible = false;
            btnProceedToPayment.Visible = false;
        }

        private void MakeTheProceedOrderFunctionalityVisible()
        {
            lbOrderDetails.Visible = true;
            MakeOrderDetailsAndManipulationInvisible();
            btnCancelOrder.Visible = true;
            btnProceedToPayment.Visible = true;
        }

        private void MakeTheProceedToPaymentFunctionalityInvisible()
        {

            if (lblScanBraceletMessage.IsHandleCreated != false)
            {
                lblScanBraceletMessage.Invoke((MethodInvoker)delegate { lblScanBraceletMessage.Visible = false; });
            }
            else
            {
                lblScanBraceletMessage.Visible = false;
            }
        }

        private void MakeTheProceedToPaymentFunctionalityVisible()
        {
            lblScanBraceletMessage.Visible = true;

            lblScanBraceletMessage.Text = "Please scan your bracelet in order to pay.";
            lblScanBraceletMessage.Font = myFont;
            lblScanBraceletMessage.Location = new Point(380, 150);
        }

        private void MakeFoodButtonsInvisible()
        {
            btnPizza.Visible = false;
            btnHamburger.Visible = false;
            btnSoftDrinks.Visible = false;
            btnFries.Visible = false;
            btnAlcoholicDrinks.Visible = false;
            btnDesert.Visible = false;
        }

        private void MakeFoodButtonsVisible()
        {
            btnPizza.Visible = true;
            btnHamburger.Visible = true;
            btnSoftDrinks.Visible = true;
            btnFries.Visible = true;
            btnAlcoholicDrinks.Visible = true;
            btnDesert.Visible = true;
        }

        private void MakeQuantityFunctionalityVisible()
        {
            lblChooseQuantity.Location = new Point(465, 70);
            lblChooseQuantity.Font = myFont;

            btnQuantityDecrease.Location = new Point(450, 100);
            lblQuantity.Location = new Point(550, 110);
            btnQuantityIncrease.Location = new Point(600, 100);

            btnQuantityDecrease.Visible = true;
            btnQuantityIncrease.Visible = true;
            lblQuantity.Visible = true;
            lblChooseQuantity.Visible = true;
        }

        private void MakeQuantityFunctionalityInvisible()
        {
            btnQuantityDecrease.Visible = false;
            btnQuantityIncrease.Visible = false;
            lblQuantity.Visible = false;
            lblChooseQuantity.Visible = false;
        }

        private void MakeBurgerLabelsInvisible()
        {
            lblHamburger.Visible = false;
            lblCheeseburger.Visible = false;
            lblVeggieBurger.Visible = false;
        }

        private void MakePizzaLabelsInvisible()
        {
            lblProsciutto.Visible = false;
            lblRomana.Visible = false;
            lblDiavola.Visible = false;
            lblTonno.Visible = false;
            lblAmericana.Visible = false;
        }

        private void MakeFriesLabelsInvisible()
        {
            lblSmallFries.Visible = false;
            lblBigFries.Visible = false;
        }

        private void MakeSoftDrinksLabelsInvisible()
        {
            lbl7Up.Visible = false;
            lblCocaCola.Visible = false;
            lblFanta.Visible = false;
            lblDrPepper.Visible = false;
            lblPepsi.Visible = false;
            lblSprite.Visible = false;
        }

        private void MakeAlcoholicDrinksLabelsInvisible()
        {
            lblLeventBeer.Visible = false;
            lblMojito.Visible = false;
            lblKirRoyale.Visible = false;
        }

        private void MakeDesertsLabelsInvisible()
        {
            lblCheeseCake.Visible = false;
            lblTiramisu.Visible = false;
            lblIceCream.Visible = false;
        }

        private void MakeBurgerButtonsInvisible()
        {
            foreach (Button b in burgerButtons)
            {
                b.Visible = false;
            }
        }

        private void MakePizzaButtonsInvisible()
        {
            foreach (Button b in pizzaButtons)
            {
                b.Visible = false;
            }
        }

        private void MakeFriesButtonsInvisible()
        {
            foreach (Button b in friesButtons)
            {
                b.Visible = false;
            }
        }

        private void MakeSoftDrinksButtonsInvisible()
        {
            foreach (Button b in softDrinksButtons)
            {
                b.Visible = false;
            }
        }

        private void MakeAlcoholicDrinksButtonsInvisible()
        {
            foreach (Button b in alcoholicDrinksButtons)
            {
                b.Visible = false;
            }
        }

        private void MakeDesertButtonsInvisible()
        {
            foreach (Button b in desertButtons)
            {
                b.Visible = false;
            }
        }

        private Button GetPizzaButton(string name)
        {
            foreach (Button b in pizzaButtons)
            {
                if (b.Name.Contains(name))
                {
                    return b;
                }
            }
            return null;
        }

        private Button GetSoftDrinksButton(string name)
        {
            foreach (Button b in softDrinksButtons)
            {
                if (b.Name.Contains(name))
                {
                    return b;
                }
            }
            return null;
        }

        private void SwitchPizzaButtonsBetweenVisibleAndInvisible()
        {
            if (pizzaButtons.Count > 0)
            {
                if (GetPizzaButton("Prosciutto").Visible == true && GetPizzaButton("Diavola").Visible == true &&
                    GetPizzaButton("Romana").Visible == true)
                {
                    GetPizzaButton("Tonno").Visible = true;
                    GetPizzaButton("Americana").Visible = true;
                    GetPizzaButton("Prosciutto").Visible = false;
                    GetPizzaButton("Diavola").Visible = false;
                    GetPizzaButton("Romana").Visible = false;

                    lblTonno.Visible = true;
                    lblAmericana.Visible = true;
                    lblProsciutto.Visible = false;
                    lblDiavola.Visible = false;
                    lblRomana.Visible = false;

                    GetPizzaButton("Tonno").Location = GetPizzaButton("Prosciutto").Location;
                    GetPizzaButton("Americana").Location = GetPizzaButton("Diavola").Location;
                }
                else if (GetPizzaButton("Tonno").Visible == true && GetPizzaButton("Americana").Visible == true)
                {
                    GetPizzaButton("Tonno").Visible = false;
                    GetPizzaButton("Americana").Visible = false;
                    GetPizzaButton("Prosciutto").Visible = true;
                    GetPizzaButton("Diavola").Visible = true;
                    GetPizzaButton("Romana").Visible = true;

                    lblProsciutto.Visible = true;
                    lblDiavola.Visible = true;
                    lblRomana.Visible = true;
                    lblTonno.Visible = false;
                    lblAmericana.Visible = false;
                }
            }
        }
        private void SwitchSoftDrinksButtonsBetweenVisibleAndInvisible()
        {
            if (softDrinksButtons.Count > 0)
            {
                if (GetSoftDrinksButton("Pepsi").Visible == true && GetSoftDrinksButton("CocaCola").Visible == true &&
                    GetSoftDrinksButton("Fanta").Visible == true)
                {
                    GetSoftDrinksButton("SevenUp").Visible = true;
                    GetSoftDrinksButton("DrPepper").Visible = true;
                    GetSoftDrinksButton("CocaCola").Visible = false;
                    GetSoftDrinksButton("Pepsi").Visible = false;
                    GetSoftDrinksButton("Sprite").Visible = true;
                    GetSoftDrinksButton("Fanta").Visible = false;

                    lblCocaCola.Visible = false;
                    lblDrPepper.Visible = true;
                    lbl7Up.Visible = true;
                    lblPepsi.Visible = false;
                    lblSprite.Visible = true;
                    lblFanta.Visible = false;

                    GetSoftDrinksButton("DrPepper").Location = GetSoftDrinksButton("CocaCola").Location;
                    GetSoftDrinksButton("SevenUp").Location = GetSoftDrinksButton("Pepsi").Location;
                    GetSoftDrinksButton("Sprite").Location = GetSoftDrinksButton("Fanta").Location;
                }
                else if (GetSoftDrinksButton("Sprite").Visible == true && GetSoftDrinksButton("DrPepper").Visible == true &&
                         GetSoftDrinksButton("SevenUp").Visible == true)
                {
                    GetSoftDrinksButton("SevenUp").Visible = false;
                    GetSoftDrinksButton("DrPepper").Visible = false;
                    GetSoftDrinksButton("CocaCola").Visible = true;
                    GetSoftDrinksButton("Pepsi").Visible = true;
                    GetSoftDrinksButton("Sprite").Visible = false;
                    GetSoftDrinksButton("Fanta").Visible = true;

                    lblCocaCola.Visible = true;
                    lblDrPepper.Visible = false;
                    lbl7Up.Visible = false;
                    lblPepsi.Visible = true;
                    lblSprite.Visible = false;
                    lblFanta.Visible = true;
                }
            }
        }

        private void StartingButtonsLocation()
        {
            btnEatIn.Location = new Point(465, 210);
            btnHamburger.Location = new Point(95, 25);
            btnPizza.Location = new Point(435, 25);
            btnFries.Location = new Point(775, 25);
            btnSoftDrinks.Location = new Point(95, 255);
            btnAlcoholicDrinks.Location = new Point(435, 255);
            btnDesert.Location = new Point(775, 255);
        }

        private void UpdateTotalCostLabel()
        {
            double price = 0;

            foreach (Food f in myShop.GetFoodTypes())
            {
                price += f.FinalPrice();
            }



            //lblTotalCost.Text = "Total cost is " + price.ToString("C");
            lblTotalCost.Invoke((MethodInvoker)delegate { lblTotalCost.Text = "Total cost is " + price.ToString("C"); });
        }

        private void UpdateTotalAmountOfProducts()
        {
            int itemsOrdered = 0;

            foreach (Food f in myShop.GetFoodTypes())
            {
                itemsOrdered += f.QuantityOrdered;
            }

            //lblAmountOfProducts.Text = "You have ordered " + itemsOrdered + " products.";
            lblAmountOfProducts.Invoke((MethodInvoker)delegate { lblAmountOfProducts.Text = "You have ordered " + itemsOrdered + " products."; });
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            if (CancellButton == null)
            {
                MakeTheCancelButton();
            }
            else
            {
                CancellButton.Visible = true;
            }

            toSwitch = 1;

            MakeTheProceedOrderFunctionalityVisible();
            MakeQuantityFunctionalityVisible();
            lblChooseQuantity.Location = new Point(910, 200);
            lblChooseQuantity.Text = "Change the quantity";
            btnQuantityDecrease.Location = new Point(910, 230);
            lblQuantity.Location = new Point(1005, 240);
            btnQuantityIncrease.Location = new Point(1050, 230);
            btnProceedToPayment.Location = btnFinishOrder.Location;

            MakeAlcoholicDrinksButtonsInvisible();
            MakeBurgerButtonsInvisible();
            MakeDesertButtonsInvisible();
            MakeFriesButtonsInvisible();
            MakePizzaButtonsInvisible();
            MakeSoftDrinksButtonsInvisible();
            MakeFoodButtonsInvisible();
            if (SwitchButton != null)
            {
                SwitchButton.Visible = false;
            }

            MakeAlcoholicDrinksLabelsInvisible();
            MakeBurgerLabelsInvisible();
            MakeDesertsLabelsInvisible();
            MakeFriesLabelsInvisible();
            MakePizzaLabelsInvisible();
            MakeSoftDrinksLabelsInvisible();

            lbOrderDetails.Font = myFont;
            lbOrderDetails.Location = new Point(100, 85);
            lbOrderDetails.Width = 800;
            lbOrderDetails.Height = 450;
            int makeSpace = 5;

            lbOrderDetails.Items.Clear();

            lbOrderDetails.Items.Add("Select an item from the list to change its quantity.");

            while (makeSpace != 3)
            {
                makeSpace--;
                lbOrderDetails.Items.Add("");
            }

            foreach (Food f in myShop.GetFoodTypes())
            {
                if (f.QuantityOrdered > 0)
                {
                    lbOrderDetails.Items.Add(f);
                }
            }
            while (makeSpace != 0)
            {
                makeSpace--;
                lbOrderDetails.Items.Add("");
            }
            lbOrderDetails.Items.Add(lblTotalCost.Text);
        }

        private void btnQuantityDecrease_Click(object sender, EventArgs e)
        {
            if (toSwitch == 0)
            {
                int quantity = int.Parse(lblQuantity.Text);

                if (quantity > 1)
                {
                    quantity--;
                }

                lblQuantity.Text = quantity.ToString();
            }

            try
            {
                if (toSwitch == 1)
                {
                    if (selectedFood.QuantityOrdered >= 1)
                    {
                        selectedFood.QuantityOrdered--;
                    }

                    int makeSpace = 5;

                    lbOrderDetails.Items.Clear();

                    lbOrderDetails.Items.Add("Select an item from the list to change its quantity.");

                    while (makeSpace != 3)
                    {
                        makeSpace--;
                        lbOrderDetails.Items.Add("");
                    }

                    foreach (Food f in myShop.GetFoodTypes())
                    {
                        if (f.QuantityOrdered > 0)
                        {
                            lbOrderDetails.Items.Add(f);
                        }
                    }
                    UpdateTotalCostLabel();
                    UpdateTotalAmountOfProducts();
                    while (makeSpace != 0)
                    {
                        makeSpace--;
                        lbOrderDetails.Items.Add("");
                    }
                    lbOrderDetails.Items.Add(lblTotalCost.Text);
                    lblQuantity.Text = selectedFood.QuantityOrdered.ToString();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a food type item from the list in order to decrease/increase it's quantity.");
            }
        }

        private void btnQuantityIncrease_Click(object sender, EventArgs e)
        {
            if (toSwitch == 0)
            {
                int quantity = int.Parse(lblQuantity.Text);

                quantity++;

                lblQuantity.Text = quantity.ToString();
            }

            try
            {
                if (toSwitch == 1)
                {
                    selectedFood.QuantityOrdered++;
                    int makeSpace = 5;

                    lbOrderDetails.Items.Clear();

                    lbOrderDetails.Items.Add("Select an item from the list to change its quantity.");

                    while (makeSpace != 3)
                    {
                        makeSpace--;
                        lbOrderDetails.Items.Add("");
                    }

                    foreach (Food f in myShop.GetFoodTypes())
                    {
                        if (f.QuantityOrdered > 0)
                        {
                            lbOrderDetails.Items.Add(f);
                        }
                    }
                    UpdateTotalCostLabel();
                    UpdateTotalAmountOfProducts();
                    while (makeSpace != 0)
                    {
                        makeSpace--;
                        lbOrderDetails.Items.Add("");
                    }
                    lbOrderDetails.Items.Add(lblTotalCost.Text);
                    lblQuantity.Text = selectedFood.QuantityOrdered.ToString();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a food type item from the list in order to decrease/increase it's quantity.");
            }
        }


        private void lbOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedFood = (Food)lbOrderDetails.SelectedItem;
                lblQuantity.Text = selectedFood.QuantityOrdered.ToString();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Please select a food type item from the list in order to decrease/increase it's quantity.");
            }
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {

            double totalCost = myShop.GetFoodTypes().Sum((Food f) => f.FinalPrice());

            if (totalCost > 0)
            {
                MakeTheProceedOrderFunctionalityInvisible();
                MakeTheProceedToPaymentFunctionalityVisible();
                MakeQuantityFunctionalityInvisible();
                rfid = new RFID();
                rfid.Open();

                void ScanThenChargeUser(object sender_, RFIDTagEventArgs e_)
                {
                    try
                    {
                        var user = User.FromRFID(e_.Tag);
                        TimeSpan checkIsMajor = DateTime.Now - user.DoB;
                        if (checkIsMajor.Days <= 6570 && CheckIfAlcoholicDrinkGotBought())
                        {
                            MessageBox.Show("Minors are not allowed to buy alcoholic drinks");
                        }
                        else
                        {
                            if (user.Charge(totalCost))
                            {
                                myOrder = new Order();
                                MessageBox.Show("Payment success");
                                rfid.Close();

                                double price = 0;

                                foreach (Food f in myShop.GetFoodTypes())
                                {
                                    price += f.FinalPrice();
                                }

                                myOrder.CreateOrder(price, user.ID, myShop.Id);
                                foreach (Food f in myShop.GetFoodTypes())
                                {
                                    if (f.QuantityOrdered > 0)
                                    {
                                        f.UpdateQuantityAvailable(f.QuantityOrdered);
                                        myOrder.OrderedFood().Add(f);
                                        myOrder.CreateOrderLine(f.Id, f.QuantityOrdered);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Payment failed");
                            }
                            UpdateMyFormAfterPayment();
                            rfid.Tag -= ScanThenChargeUser;
                        }
                    }
                    catch(User.InsuficientMoneyException message) 
                    {
                        MessageBox.Show(message.Message);
                    }
                }

                rfid.Tag += ScanThenChargeUser;
            }
            else
            {
                MessageBox.Show("The order list must contain at least one food type to proceed to the payment.");
            }

        }

        private bool CheckIfAlcoholicDrinkGotBought()
        {
            foreach(Food f in myShop.GetAlcoholicDrinksTypes())
            {
                if (f.QuantityOrdered > 0) { return true; }
            }
            return false;
        }

        private void UpdateMyFormAfterPayment()
        {

            foreach (Food f in myShop.GetFoodTypes())
            {
                f.QuantityOrdered = 0;
            }


            UpdateTotalCostLabel();
            UpdateTotalAmountOfProducts();

            CancellButton.Invoke((MethodInvoker)delegate { CancellButton.Visible = false; });
            btnCancelOrder.Invoke((MethodInvoker)delegate { btnCancelOrder.Visible = false; });
            MakeTheProceedToPaymentFunctionalityInvisible();
            btnEatIn.Invoke((MethodInvoker)delegate { btnEatIn.Visible = true; });
        }

        private void btnShowOrderLines_Click(object sender, EventArgs e)
        {
            orderLines = new OrderLines();
            orderLines.Show();
            btnShowOrderLines.Visible = false;

            orderLines.FormClosed += (s, e1) => btnShowOrderLines.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
} 

