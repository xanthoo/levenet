namespace ProP_Restaurant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEatIn = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblAmountOfProducts = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.lblHamburger = new System.Windows.Forms.Label();
            this.lblCheeseburger = new System.Windows.Forms.Label();
            this.lblVeggieBurger = new System.Windows.Forms.Label();
            this.lblProsciutto = new System.Windows.Forms.Label();
            this.lblDiavola = new System.Windows.Forms.Label();
            this.lblRomana = new System.Windows.Forms.Label();
            this.lblAmericana = new System.Windows.Forms.Label();
            this.lblTonno = new System.Windows.Forms.Label();
            this.lblSmallFries = new System.Windows.Forms.Label();
            this.lblBigFries = new System.Windows.Forms.Label();
            this.lblCocaCola = new System.Windows.Forms.Label();
            this.lblFanta = new System.Windows.Forms.Label();
            this.lblSprite = new System.Windows.Forms.Label();
            this.lbl7Up = new System.Windows.Forms.Label();
            this.lblDrPepper = new System.Windows.Forms.Label();
            this.lblPepsi = new System.Windows.Forms.Label();
            this.btnDesert = new System.Windows.Forms.Button();
            this.btnAlcoholicDrinks = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.btnSoftDrinks = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnHamburger = new System.Windows.Forms.Button();
            this.lblLeventBeer = new System.Windows.Forms.Label();
            this.lblMojito = new System.Windows.Forms.Label();
            this.lblKirRoyale = new System.Windows.Forms.Label();
            this.lblCheeseCake = new System.Windows.Forms.Label();
            this.lblTiramisu = new System.Windows.Forms.Label();
            this.lblIceCream = new System.Windows.Forms.Label();
            this.btnQuantityDecrease = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnQuantityIncrease = new System.Windows.Forms.Button();
            this.lblChooseQuantity = new System.Windows.Forms.Label();
            this.lbOrderDetails = new System.Windows.Forms.ListBox();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
            this.lblScanBraceletMessage = new System.Windows.Forms.Label();
            this.dbi410674DataSet1 = new ProP_Restaurant.dbi410674DataSet();
            this.pnlSelectShop = new System.Windows.Forms.Panel();
            this.rbShopTwo = new System.Windows.Forms.RadioButton();
            this.rbShopOne = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowOrderLines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbi410674DataSet1)).BeginInit();
            this.pnlSelectShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEatIn
            // 
            this.btnEatIn.BackColor = System.Drawing.Color.Maroon;
            this.btnEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatIn.ForeColor = System.Drawing.Color.White;
            this.btnEatIn.Location = new System.Drawing.Point(709, 207);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(274, 196);
            this.btnEatIn.TabIndex = 0;
            this.btnEatIn.Text = "Start Order";
            this.btnEatIn.UseVisualStyleBackColor = false;
            this.btnEatIn.Click += new System.EventHandler(this.btnEatIn_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(26, 696);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(180, 29);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total cost is € 0";
            // 
            // lblAmountOfProducts
            // 
            this.lblAmountOfProducts.AutoSize = true;
            this.lblAmountOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfProducts.Location = new System.Drawing.Point(28, 654);
            this.lblAmountOfProducts.Name = "lblAmountOfProducts";
            this.lblAmountOfProducts.Size = new System.Drawing.Size(329, 29);
            this.lblAmountOfProducts.TabIndex = 2;
            this.lblAmountOfProducts.Text = "You have ordered 0 products.";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(249, 752);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(557, 79);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrder.ForeColor = System.Drawing.Color.White;
            this.btnFinishOrder.Location = new System.Drawing.Point(874, 752);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(557, 79);
            this.btnFinishOrder.TabIndex = 0;
            this.btnFinishOrder.Text = "Proceed Order";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // lblHamburger
            // 
            this.lblHamburger.AutoSize = true;
            this.lblHamburger.Location = new System.Drawing.Point(3, 476);
            this.lblHamburger.Name = "lblHamburger";
            this.lblHamburger.Size = new System.Drawing.Size(79, 17);
            this.lblHamburger.TabIndex = 9;
            this.lblHamburger.Text = "Hamburger";
            // 
            // lblCheeseburger
            // 
            this.lblCheeseburger.AutoSize = true;
            this.lblCheeseburger.Location = new System.Drawing.Point(3, 459);
            this.lblCheeseburger.Name = "lblCheeseburger";
            this.lblCheeseburger.Size = new System.Drawing.Size(98, 17);
            this.lblCheeseburger.TabIndex = 10;
            this.lblCheeseburger.Text = "Cheeseburger";
            // 
            // lblVeggieBurger
            // 
            this.lblVeggieBurger.AutoSize = true;
            this.lblVeggieBurger.Location = new System.Drawing.Point(3, 442);
            this.lblVeggieBurger.Name = "lblVeggieBurger";
            this.lblVeggieBurger.Size = new System.Drawing.Size(95, 17);
            this.lblVeggieBurger.TabIndex = 11;
            this.lblVeggieBurger.Text = "VeggieBurger";
            // 
            // lblProsciutto
            // 
            this.lblProsciutto.AutoSize = true;
            this.lblProsciutto.Location = new System.Drawing.Point(135, 442);
            this.lblProsciutto.Name = "lblProsciutto";
            this.lblProsciutto.Size = new System.Drawing.Size(71, 17);
            this.lblProsciutto.TabIndex = 13;
            this.lblProsciutto.Text = "Prosciutto";
            // 
            // lblDiavola
            // 
            this.lblDiavola.AutoSize = true;
            this.lblDiavola.Location = new System.Drawing.Point(135, 459);
            this.lblDiavola.Name = "lblDiavola";
            this.lblDiavola.Size = new System.Drawing.Size(55, 17);
            this.lblDiavola.TabIndex = 14;
            this.lblDiavola.Text = "Diavola";
            // 
            // lblRomana
            // 
            this.lblRomana.AutoSize = true;
            this.lblRomana.Location = new System.Drawing.Point(135, 476);
            this.lblRomana.Name = "lblRomana";
            this.lblRomana.Size = new System.Drawing.Size(61, 17);
            this.lblRomana.TabIndex = 15;
            this.lblRomana.Text = "Romana";
            // 
            // lblAmericana
            // 
            this.lblAmericana.AutoSize = true;
            this.lblAmericana.Location = new System.Drawing.Point(135, 493);
            this.lblAmericana.Name = "lblAmericana";
            this.lblAmericana.Size = new System.Drawing.Size(75, 17);
            this.lblAmericana.TabIndex = 16;
            this.lblAmericana.Text = "Americana";
            // 
            // lblTonno
            // 
            this.lblTonno.AutoSize = true;
            this.lblTonno.Location = new System.Drawing.Point(135, 510);
            this.lblTonno.Name = "lblTonno";
            this.lblTonno.Size = new System.Drawing.Size(49, 17);
            this.lblTonno.TabIndex = 17;
            this.lblTonno.Text = "Tonno";
            // 
            // lblSmallFries
            // 
            this.lblSmallFries.AutoSize = true;
            this.lblSmallFries.Location = new System.Drawing.Point(228, 442);
            this.lblSmallFries.Name = "lblSmallFries";
            this.lblSmallFries.Size = new System.Drawing.Size(77, 17);
            this.lblSmallFries.TabIndex = 18;
            this.lblSmallFries.Text = "Small Fries";
            // 
            // lblBigFries
            // 
            this.lblBigFries.AutoSize = true;
            this.lblBigFries.Location = new System.Drawing.Point(228, 459);
            this.lblBigFries.Name = "lblBigFries";
            this.lblBigFries.Size = new System.Drawing.Size(63, 17);
            this.lblBigFries.TabIndex = 19;
            this.lblBigFries.Text = "Big Fries";
            // 
            // lblCocaCola
            // 
            this.lblCocaCola.AutoSize = true;
            this.lblCocaCola.Location = new System.Drawing.Point(312, 442);
            this.lblCocaCola.Name = "lblCocaCola";
            this.lblCocaCola.Size = new System.Drawing.Size(72, 17);
            this.lblCocaCola.TabIndex = 20;
            this.lblCocaCola.Text = "Coca Cola";
            // 
            // lblFanta
            // 
            this.lblFanta.AutoSize = true;
            this.lblFanta.Location = new System.Drawing.Point(312, 459);
            this.lblFanta.Name = "lblFanta";
            this.lblFanta.Size = new System.Drawing.Size(44, 17);
            this.lblFanta.TabIndex = 21;
            this.lblFanta.Text = "Fanta";
            // 
            // lblSprite
            // 
            this.lblSprite.AutoSize = true;
            this.lblSprite.Location = new System.Drawing.Point(312, 476);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(45, 17);
            this.lblSprite.TabIndex = 22;
            this.lblSprite.Text = "Sprite";
            // 
            // lbl7Up
            // 
            this.lbl7Up.AutoSize = true;
            this.lbl7Up.Location = new System.Drawing.Point(312, 493);
            this.lbl7Up.Name = "lbl7Up";
            this.lbl7Up.Size = new System.Drawing.Size(38, 17);
            this.lbl7Up.TabIndex = 23;
            this.lbl7Up.Text = "7 Up";
            // 
            // lblDrPepper
            // 
            this.lblDrPepper.AutoSize = true;
            this.lblDrPepper.Location = new System.Drawing.Point(312, 510);
            this.lblDrPepper.Name = "lblDrPepper";
            this.lblDrPepper.Size = new System.Drawing.Size(73, 17);
            this.lblDrPepper.TabIndex = 24;
            this.lblDrPepper.Text = "Dr Pepper";
            // 
            // lblPepsi
            // 
            this.lblPepsi.AutoSize = true;
            this.lblPepsi.Location = new System.Drawing.Point(312, 527);
            this.lblPepsi.Name = "lblPepsi";
            this.lblPepsi.Size = new System.Drawing.Size(43, 17);
            this.lblPepsi.TabIndex = 25;
            this.lblPepsi.Text = "Pepsi";
            // 
            // btnDesert
            // 
            this.btnDesert.Image = global::ProP_Restaurant.Properties.Resources.desert_resized;
            this.btnDesert.Location = new System.Drawing.Point(563, 38);
            this.btnDesert.Name = "btnDesert";
            this.btnDesert.Size = new System.Drawing.Size(326, 248);
            this.btnDesert.TabIndex = 12;
            this.btnDesert.UseVisualStyleBackColor = true;
            this.btnDesert.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // btnAlcoholicDrinks
            // 
            this.btnAlcoholicDrinks.Image = global::ProP_Restaurant.Properties.Resources.alcoholic_drinks;
            this.btnAlcoholicDrinks.Location = new System.Drawing.Point(480, 38);
            this.btnAlcoholicDrinks.Name = "btnAlcoholicDrinks";
            this.btnAlcoholicDrinks.Size = new System.Drawing.Size(326, 248);
            this.btnAlcoholicDrinks.TabIndex = 7;
            this.btnAlcoholicDrinks.UseVisualStyleBackColor = true;
            this.btnAlcoholicDrinks.Click += new System.EventHandler(this.btnAlcoholicDrinks_Click);
            // 
            // btnFries
            // 
            this.btnFries.Image = global::ProP_Restaurant.Properties.Resources.fries_resized;
            this.btnFries.Location = new System.Drawing.Point(392, 38);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(326, 248);
            this.btnFries.TabIndex = 5;
            this.btnFries.UseVisualStyleBackColor = true;
            this.btnFries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // btnSoftDrinks
            // 
            this.btnSoftDrinks.Image = global::ProP_Restaurant.Properties.Resources.softdrinks;
            this.btnSoftDrinks.Location = new System.Drawing.Point(337, 38);
            this.btnSoftDrinks.Name = "btnSoftDrinks";
            this.btnSoftDrinks.Size = new System.Drawing.Size(326, 248);
            this.btnSoftDrinks.TabIndex = 4;
            this.btnSoftDrinks.UseVisualStyleBackColor = true;
            this.btnSoftDrinks.Click += new System.EventHandler(this.btnSoftDrinks_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Image = global::ProP_Restaurant.Properties.Resources.pizza_resized;
            this.btnPizza.Location = new System.Drawing.Point(281, 38);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(326, 248);
            this.btnPizza.TabIndex = 3;
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnHamburger
            // 
            this.btnHamburger.Image = global::ProP_Restaurant.Properties.Resources.burger_resized;
            this.btnHamburger.Location = new System.Drawing.Point(209, 38);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(326, 248);
            this.btnHamburger.TabIndex = 2;
            this.btnHamburger.UseVisualStyleBackColor = true;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            // 
            // lblLeventBeer
            // 
            this.lblLeventBeer.AutoSize = true;
            this.lblLeventBeer.Location = new System.Drawing.Point(392, 442);
            this.lblLeventBeer.Name = "lblLeventBeer";
            this.lblLeventBeer.Size = new System.Drawing.Size(81, 17);
            this.lblLeventBeer.TabIndex = 26;
            this.lblLeventBeer.Text = "LeventBeer";
            // 
            // lblMojito
            // 
            this.lblMojito.AutoSize = true;
            this.lblMojito.Location = new System.Drawing.Point(392, 459);
            this.lblMojito.Name = "lblMojito";
            this.lblMojito.Size = new System.Drawing.Size(45, 17);
            this.lblMojito.TabIndex = 27;
            this.lblMojito.Text = "Mojito";
            // 
            // lblKirRoyale
            // 
            this.lblKirRoyale.AutoSize = true;
            this.lblKirRoyale.Location = new System.Drawing.Point(392, 476);
            this.lblKirRoyale.Name = "lblKirRoyale";
            this.lblKirRoyale.Size = new System.Drawing.Size(73, 17);
            this.lblKirRoyale.TabIndex = 28;
            this.lblKirRoyale.Text = "Kir Royale";
            // 
            // lblCheeseCake
            // 
            this.lblCheeseCake.AutoSize = true;
            this.lblCheeseCake.Location = new System.Drawing.Point(500, 442);
            this.lblCheeseCake.Name = "lblCheeseCake";
            this.lblCheeseCake.Size = new System.Drawing.Size(88, 17);
            this.lblCheeseCake.TabIndex = 29;
            this.lblCheeseCake.Text = "CheeseCake";
            // 
            // lblTiramisu
            // 
            this.lblTiramisu.AutoSize = true;
            this.lblTiramisu.Location = new System.Drawing.Point(500, 459);
            this.lblTiramisu.Name = "lblTiramisu";
            this.lblTiramisu.Size = new System.Drawing.Size(62, 17);
            this.lblTiramisu.TabIndex = 30;
            this.lblTiramisu.Text = "Tiramisu";
            // 
            // lblIceCream
            // 
            this.lblIceCream.AutoSize = true;
            this.lblIceCream.Location = new System.Drawing.Point(500, 476);
            this.lblIceCream.Name = "lblIceCream";
            this.lblIceCream.Size = new System.Drawing.Size(67, 17);
            this.lblIceCream.TabIndex = 31;
            this.lblIceCream.Text = "IceCream";
            // 
            // btnQuantityDecrease
            // 
            this.btnQuantityDecrease.BackColor = System.Drawing.Color.Maroon;
            this.btnQuantityDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantityDecrease.ForeColor = System.Drawing.Color.White;
            this.btnQuantityDecrease.Location = new System.Drawing.Point(209, 339);
            this.btnQuantityDecrease.Name = "btnQuantityDecrease";
            this.btnQuantityDecrease.Size = new System.Drawing.Size(115, 64);
            this.btnQuantityDecrease.TabIndex = 32;
            this.btnQuantityDecrease.Text = "-";
            this.btnQuantityDecrease.UseVisualStyleBackColor = false;
            this.btnQuantityDecrease.Click += new System.EventHandler(this.btnQuantityDecrease_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(339, 352);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(35, 38);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "1";
            // 
            // btnQuantityIncrease
            // 
            this.btnQuantityIncrease.BackColor = System.Drawing.Color.Maroon;
            this.btnQuantityIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantityIncrease.ForeColor = System.Drawing.Color.White;
            this.btnQuantityIncrease.Location = new System.Drawing.Point(395, 339);
            this.btnQuantityIncrease.Name = "btnQuantityIncrease";
            this.btnQuantityIncrease.Size = new System.Drawing.Size(112, 64);
            this.btnQuantityIncrease.TabIndex = 34;
            this.btnQuantityIncrease.Text = "+";
            this.btnQuantityIncrease.UseVisualStyleBackColor = false;
            this.btnQuantityIncrease.Click += new System.EventHandler(this.btnQuantityIncrease_Click);
            // 
            // lblChooseQuantity
            // 
            this.lblChooseQuantity.AutoSize = true;
            this.lblChooseQuantity.Location = new System.Drawing.Point(315, 302);
            this.lblChooseQuantity.Name = "lblChooseQuantity";
            this.lblChooseQuantity.Size = new System.Drawing.Size(134, 17);
            this.lblChooseQuantity.TabIndex = 35;
            this.lblChooseQuantity.Text = "Choose the quantity";
            // 
            // lbOrderDetails
            // 
            this.lbOrderDetails.FormattingEnabled = true;
            this.lbOrderDetails.ItemHeight = 16;
            this.lbOrderDetails.Location = new System.Drawing.Point(1167, 97);
            this.lbOrderDetails.Name = "lbOrderDetails";
            this.lbOrderDetails.Size = new System.Drawing.Size(344, 404);
            this.lbOrderDetails.TabIndex = 36;
            this.lbOrderDetails.SelectedIndexChanged += new System.EventHandler(this.lbOrderDetails_SelectedIndexChanged);
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.BackColor = System.Drawing.Color.ForestGreen;
            this.btnProceedToPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedToPayment.ForeColor = System.Drawing.Color.White;
            this.btnProceedToPayment.Location = new System.Drawing.Point(874, 654);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(557, 79);
            this.btnProceedToPayment.TabIndex = 37;
            this.btnProceedToPayment.Text = "Proceed To Payment";
            this.btnProceedToPayment.UseVisualStyleBackColor = false;
            this.btnProceedToPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // lblScanBraceletMessage
            // 
            this.lblScanBraceletMessage.AutoSize = true;
            this.lblScanBraceletMessage.Location = new System.Drawing.Point(1097, 634);
            this.lblScanBraceletMessage.Name = "lblScanBraceletMessage";
            this.lblScanBraceletMessage.Size = new System.Drawing.Size(96, 17);
            this.lblScanBraceletMessage.TabIndex = 38;
            this.lblScanBraceletMessage.Text = "Scan Bracelet";
            // 
            // dbi410674DataSet1
            // 
            this.dbi410674DataSet1.DataSetName = "dbi410674DataSet";
            this.dbi410674DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlSelectShop
            // 
            this.pnlSelectShop.Controls.Add(this.rbShopTwo);
            this.pnlSelectShop.Controls.Add(this.rbShopOne);
            this.pnlSelectShop.Controls.Add(this.label1);
            this.pnlSelectShop.Location = new System.Drawing.Point(632, 442);
            this.pnlSelectShop.Name = "pnlSelectShop";
            this.pnlSelectShop.Size = new System.Drawing.Size(365, 133);
            this.pnlSelectShop.TabIndex = 39;
            // 
            // rbShopTwo
            // 
            this.rbShopTwo.AutoSize = true;
            this.rbShopTwo.Location = new System.Drawing.Point(198, 66);
            this.rbShopTwo.Name = "rbShopTwo";
            this.rbShopTwo.Size = new System.Drawing.Size(142, 21);
            this.rbShopTwo.TabIndex = 2;
            this.rbShopTwo.TabStop = true;
            this.rbShopTwo.Text = "L\'event Shop Two";
            this.rbShopTwo.UseVisualStyleBackColor = true;
            // 
            // rbShopOne
            // 
            this.rbShopOne.AutoSize = true;
            this.rbShopOne.Location = new System.Drawing.Point(31, 66);
            this.rbShopOne.Name = "rbShopOne";
            this.rbShopOne.Size = new System.Drawing.Size(143, 21);
            this.rbShopOne.TabIndex = 1;
            this.rbShopOne.TabStop = true;
            this.rbShopOne.Text = "L\'event Shop One";
            this.rbShopOne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the shop";
            // 
            // btnShowOrderLines
            // 
            this.btnShowOrderLines.BackColor = System.Drawing.Color.DarkBlue;
            this.btnShowOrderLines.ForeColor = System.Drawing.Color.White;
            this.btnShowOrderLines.Location = new System.Drawing.Point(1368, 12);
            this.btnShowOrderLines.Name = "btnShowOrderLines";
            this.btnShowOrderLines.Size = new System.Drawing.Size(143, 38);
            this.btnShowOrderLines.TabIndex = 40;
            this.btnShowOrderLines.Text = "Show Order Lines";
            this.btnShowOrderLines.UseVisualStyleBackColor = false;
            this.btnShowOrderLines.Click += new System.EventHandler(this.btnShowOrderLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1523, 861);
            this.Controls.Add(this.btnShowOrderLines);
            this.Controls.Add(this.pnlSelectShop);
            this.Controls.Add(this.lblScanBraceletMessage);
            this.Controls.Add(this.btnProceedToPayment);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblAmountOfProducts);
            this.Controls.Add(this.lbOrderDetails);
            this.Controls.Add(this.lblChooseQuantity);
            this.Controls.Add(this.btnQuantityIncrease);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnQuantityDecrease);
            this.Controls.Add(this.lblIceCream);
            this.Controls.Add(this.lblTiramisu);
            this.Controls.Add(this.lblCheeseCake);
            this.Controls.Add(this.lblKirRoyale);
            this.Controls.Add(this.lblMojito);
            this.Controls.Add(this.lblLeventBeer);
            this.Controls.Add(this.lblPepsi);
            this.Controls.Add(this.lblDrPepper);
            this.Controls.Add(this.lbl7Up);
            this.Controls.Add(this.lblSprite);
            this.Controls.Add(this.lblFanta);
            this.Controls.Add(this.lblCocaCola);
            this.Controls.Add(this.lblBigFries);
            this.Controls.Add(this.lblSmallFries);
            this.Controls.Add(this.lblTonno);
            this.Controls.Add(this.lblAmericana);
            this.Controls.Add(this.lblRomana);
            this.Controls.Add(this.lblDiavola);
            this.Controls.Add(this.lblProsciutto);
            this.Controls.Add(this.btnDesert);
            this.Controls.Add(this.lblVeggieBurger);
            this.Controls.Add(this.lblCheeseburger);
            this.Controls.Add(this.lblHamburger);
            this.Controls.Add(this.btnAlcoholicDrinks);
            this.Controls.Add(this.btnFries);
            this.Controls.Add(this.btnSoftDrinks);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.btnHamburger);
            this.Controls.Add(this.btnEatIn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dbi410674DataSet1)).EndInit();
            this.pnlSelectShop.ResumeLayout(false);
            this.pnlSelectShop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnHamburger;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnSoftDrinks;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblAmountOfProducts;
        private System.Windows.Forms.Button btnAlcoholicDrinks;
        private System.Windows.Forms.Label lblHamburger;
        private System.Windows.Forms.Label lblCheeseburger;
        private System.Windows.Forms.Label lblVeggieBurger;
        private System.Windows.Forms.Button btnDesert;
        private System.Windows.Forms.Label lblProsciutto;
        private System.Windows.Forms.Label lblDiavola;
        private System.Windows.Forms.Label lblRomana;
        private System.Windows.Forms.Label lblAmericana;
        private System.Windows.Forms.Label lblTonno;
        private System.Windows.Forms.Label lblSmallFries;
        private System.Windows.Forms.Label lblBigFries;
        private System.Windows.Forms.Label lblCocaCola;
        private System.Windows.Forms.Label lblFanta;
        private System.Windows.Forms.Label lblSprite;
        private System.Windows.Forms.Label lbl7Up;
        private System.Windows.Forms.Label lblDrPepper;
        private System.Windows.Forms.Label lblPepsi;
        private System.Windows.Forms.Label lblLeventBeer;
        private System.Windows.Forms.Label lblMojito;
        private System.Windows.Forms.Label lblKirRoyale;
        private System.Windows.Forms.Label lblCheeseCake;
        private System.Windows.Forms.Label lblTiramisu;
        private System.Windows.Forms.Label lblIceCream;
        private System.Windows.Forms.Button btnQuantityDecrease;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnQuantityIncrease;
        private System.Windows.Forms.Label lblChooseQuantity;
        private System.Windows.Forms.ListBox lbOrderDetails;
        private System.Windows.Forms.Button btnProceedToPayment;
        private System.Windows.Forms.Label lblScanBraceletMessage;
        private dbi410674DataSet dbi410674DataSet1;
        private System.Windows.Forms.Panel pnlSelectShop;
        private System.Windows.Forms.RadioButton rbShopTwo;
        private System.Windows.Forms.RadioButton rbShopOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowOrderLines;
    }
}

