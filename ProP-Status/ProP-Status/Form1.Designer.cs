namespace ProP_Status
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chFoodQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowFoodQuantity = new System.Windows.Forms.Button();
            this.rbBurgers = new System.Windows.Forms.RadioButton();
            this.rbPizzas = new System.Windows.Forms.RadioButton();
            this.rbFries = new System.Windows.Forms.RadioButton();
            this.rbSoftDrinks = new System.Windows.Forms.RadioButton();
            this.rbAlcoholicDrinks = new System.Windows.Forms.RadioButton();
            this.rbDeserts = new System.Windows.Forms.RadioButton();
            this.chMoneyPerShop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMoneyPerShop = new System.Windows.Forms.Button();
            this.btnCampingSpots = new System.Windows.Forms.Button();
            this.chCampingSpots = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblUsersCheckedIn = new System.Windows.Forms.Label();
            this.btnUsersOverview = new System.Windows.Forms.Button();
            this.lblAllUsers = new System.Windows.Forms.Label();
            this.chUsersMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chFoodQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chMoneyPerShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCampingSpots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chUsersMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // chFoodQuantity
            // 
            chartArea1.Name = "ChartArea1";
            this.chFoodQuantity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chFoodQuantity.Legends.Add(legend1);
            this.chFoodQuantity.Location = new System.Drawing.Point(12, 812);
            this.chFoodQuantity.Name = "chFoodQuantity";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chFoodQuantity.Series.Add(series1);
            this.chFoodQuantity.Size = new System.Drawing.Size(355, 222);
            this.chFoodQuantity.TabIndex = 0;
            this.chFoodQuantity.Text = "chart1";
            // 
            // btnShowFoodQuantity
            // 
            this.btnShowFoodQuantity.BackColor = System.Drawing.Color.DarkBlue;
            this.btnShowFoodQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFoodQuantity.ForeColor = System.Drawing.Color.White;
            this.btnShowFoodQuantity.Location = new System.Drawing.Point(76, 29);
            this.btnShowFoodQuantity.Name = "btnShowFoodQuantity";
            this.btnShowFoodQuantity.Size = new System.Drawing.Size(167, 54);
            this.btnShowFoodQuantity.TabIndex = 1;
            this.btnShowFoodQuantity.Text = "Show Food Quantity";
            this.btnShowFoodQuantity.UseVisualStyleBackColor = false;
            this.btnShowFoodQuantity.Click += new System.EventHandler(this.btnShowFoodQuantity_Click);
            // 
            // rbBurgers
            // 
            this.rbBurgers.AutoSize = true;
            this.rbBurgers.Location = new System.Drawing.Point(12, 785);
            this.rbBurgers.Name = "rbBurgers";
            this.rbBurgers.Size = new System.Drawing.Size(79, 21);
            this.rbBurgers.TabIndex = 2;
            this.rbBurgers.TabStop = true;
            this.rbBurgers.Text = "Burgers";
            this.rbBurgers.UseVisualStyleBackColor = true;
            this.rbBurgers.CheckedChanged += new System.EventHandler(this.rbBurgers_CheckedChanged);
            // 
            // rbPizzas
            // 
            this.rbPizzas.AutoSize = true;
            this.rbPizzas.Location = new System.Drawing.Point(87, 785);
            this.rbPizzas.Name = "rbPizzas";
            this.rbPizzas.Size = new System.Drawing.Size(70, 21);
            this.rbPizzas.TabIndex = 3;
            this.rbPizzas.TabStop = true;
            this.rbPizzas.Text = "Pizzas";
            this.rbPizzas.UseVisualStyleBackColor = true;
            this.rbPizzas.CheckedChanged += new System.EventHandler(this.rbPizzas_CheckedChanged);
            // 
            // rbFries
            // 
            this.rbFries.AutoSize = true;
            this.rbFries.Location = new System.Drawing.Point(154, 785);
            this.rbFries.Name = "rbFries";
            this.rbFries.Size = new System.Drawing.Size(60, 21);
            this.rbFries.TabIndex = 4;
            this.rbFries.TabStop = true;
            this.rbFries.Text = "Fries";
            this.rbFries.UseVisualStyleBackColor = true;
            this.rbFries.CheckedChanged += new System.EventHandler(this.rbFries_CheckedChanged);
            // 
            // rbSoftDrinks
            // 
            this.rbSoftDrinks.AutoSize = true;
            this.rbSoftDrinks.Location = new System.Drawing.Point(210, 785);
            this.rbSoftDrinks.Name = "rbSoftDrinks";
            this.rbSoftDrinks.Size = new System.Drawing.Size(98, 21);
            this.rbSoftDrinks.TabIndex = 5;
            this.rbSoftDrinks.TabStop = true;
            this.rbSoftDrinks.Text = "Soft Drinks";
            this.rbSoftDrinks.UseVisualStyleBackColor = true;
            this.rbSoftDrinks.CheckedChanged += new System.EventHandler(this.rbSoftDrinks_CheckedChanged);
            // 
            // rbAlcoholicDrinks
            // 
            this.rbAlcoholicDrinks.AutoSize = true;
            this.rbAlcoholicDrinks.Location = new System.Drawing.Point(12, 758);
            this.rbAlcoholicDrinks.Name = "rbAlcoholicDrinks";
            this.rbAlcoholicDrinks.Size = new System.Drawing.Size(129, 21);
            this.rbAlcoholicDrinks.TabIndex = 6;
            this.rbAlcoholicDrinks.TabStop = true;
            this.rbAlcoholicDrinks.Text = "Alcoholic Drinks";
            this.rbAlcoholicDrinks.UseVisualStyleBackColor = true;
            this.rbAlcoholicDrinks.CheckedChanged += new System.EventHandler(this.rbAlcoholicDrinks_CheckedChanged);
            // 
            // rbDeserts
            // 
            this.rbDeserts.AutoSize = true;
            this.rbDeserts.Location = new System.Drawing.Point(136, 758);
            this.rbDeserts.Name = "rbDeserts";
            this.rbDeserts.Size = new System.Drawing.Size(78, 21);
            this.rbDeserts.TabIndex = 7;
            this.rbDeserts.TabStop = true;
            this.rbDeserts.Text = "Deserts";
            this.rbDeserts.UseVisualStyleBackColor = true;
            this.rbDeserts.CheckedChanged += new System.EventHandler(this.rbDeserts_CheckedChanged);
            // 
            // chMoneyPerShop
            // 
            chartArea2.Name = "ChartArea1";
            this.chMoneyPerShop.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chMoneyPerShop.Legends.Add(legend2);
            this.chMoneyPerShop.Location = new System.Drawing.Point(398, 812);
            this.chMoneyPerShop.Name = "chMoneyPerShop";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Money";
            this.chMoneyPerShop.Series.Add(series2);
            this.chMoneyPerShop.Size = new System.Drawing.Size(359, 222);
            this.chMoneyPerShop.TabIndex = 8;
            this.chMoneyPerShop.Text = "chart1";
            // 
            // btnMoneyPerShop
            // 
            this.btnMoneyPerShop.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMoneyPerShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneyPerShop.ForeColor = System.Drawing.Color.White;
            this.btnMoneyPerShop.Location = new System.Drawing.Point(249, 29);
            this.btnMoneyPerShop.Name = "btnMoneyPerShop";
            this.btnMoneyPerShop.Size = new System.Drawing.Size(167, 54);
            this.btnMoneyPerShop.TabIndex = 9;
            this.btnMoneyPerShop.Text = "Money Per Shop";
            this.btnMoneyPerShop.UseVisualStyleBackColor = false;
            this.btnMoneyPerShop.Click += new System.EventHandler(this.btnMoneyPerShop_Click);
            // 
            // btnCampingSpots
            // 
            this.btnCampingSpots.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCampingSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampingSpots.ForeColor = System.Drawing.Color.White;
            this.btnCampingSpots.Location = new System.Drawing.Point(422, 29);
            this.btnCampingSpots.Name = "btnCampingSpots";
            this.btnCampingSpots.Size = new System.Drawing.Size(167, 54);
            this.btnCampingSpots.TabIndex = 10;
            this.btnCampingSpots.Text = "Camping Spots";
            this.btnCampingSpots.UseVisualStyleBackColor = false;
            this.btnCampingSpots.Click += new System.EventHandler(this.btnCampingSpots_Click);
            // 
            // chCampingSpots
            // 
            chartArea3.Name = "ChartArea1";
            this.chCampingSpots.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chCampingSpots.Legends.Add(legend3);
            this.chCampingSpots.Location = new System.Drawing.Point(792, 812);
            this.chCampingSpots.Name = "chCampingSpots";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Availability";
            series3.XValueMember = "1";
            this.chCampingSpots.Series.Add(series3);
            this.chCampingSpots.Size = new System.Drawing.Size(359, 222);
            this.chCampingSpots.TabIndex = 11;
            this.chCampingSpots.Text = "chart1";
            // 
            // lblUsersCheckedIn
            // 
            this.lblUsersCheckedIn.AutoSize = true;
            this.lblUsersCheckedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCheckedIn.Location = new System.Drawing.Point(94, 169);
            this.lblUsersCheckedIn.Name = "lblUsersCheckedIn";
            this.lblUsersCheckedIn.Size = new System.Drawing.Size(168, 24);
            this.lblUsersCheckedIn.TabIndex = 12;
            this.lblUsersCheckedIn.Text = "lblUsersCheckedIn";
            // 
            // btnUsersOverview
            // 
            this.btnUsersOverview.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUsersOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersOverview.ForeColor = System.Drawing.Color.White;
            this.btnUsersOverview.Location = new System.Drawing.Point(595, 29);
            this.btnUsersOverview.Name = "btnUsersOverview";
            this.btnUsersOverview.Size = new System.Drawing.Size(167, 54);
            this.btnUsersOverview.TabIndex = 13;
            this.btnUsersOverview.Text = "Users Overview";
            this.btnUsersOverview.UseVisualStyleBackColor = false;
            this.btnUsersOverview.Click += new System.EventHandler(this.btnUsersOverview_Click);
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllUsers.Location = new System.Drawing.Point(94, 207);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(60, 24);
            this.lblAllUsers.TabIndex = 14;
            this.lblAllUsers.Text = "label1";
            // 
            // chUsersMoney
            // 
            chartArea4.Name = "ChartArea1";
            this.chUsersMoney.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chUsersMoney.Legends.Add(legend4);
            this.chUsersMoney.Location = new System.Drawing.Point(87, 253);
            this.chUsersMoney.Name = "chUsersMoney";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Money";
            this.chUsersMoney.Series.Add(series4);
            this.chUsersMoney.Size = new System.Drawing.Size(300, 300);
            this.chUsersMoney.TabIndex = 15;
            this.chUsersMoney.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1046);
            this.Controls.Add(this.chUsersMoney);
            this.Controls.Add(this.lblAllUsers);
            this.Controls.Add(this.btnUsersOverview);
            this.Controls.Add(this.lblUsersCheckedIn);
            this.Controls.Add(this.chCampingSpots);
            this.Controls.Add(this.btnCampingSpots);
            this.Controls.Add(this.btnMoneyPerShop);
            this.Controls.Add(this.chMoneyPerShop);
            this.Controls.Add(this.rbDeserts);
            this.Controls.Add(this.rbAlcoholicDrinks);
            this.Controls.Add(this.rbSoftDrinks);
            this.Controls.Add(this.rbFries);
            this.Controls.Add(this.rbPizzas);
            this.Controls.Add(this.rbBurgers);
            this.Controls.Add(this.btnShowFoodQuantity);
            this.Controls.Add(this.chFoodQuantity);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chFoodQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chMoneyPerShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCampingSpots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chUsersMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chFoodQuantity;
        private System.Windows.Forms.Button btnShowFoodQuantity;
        private System.Windows.Forms.RadioButton rbBurgers;
        private System.Windows.Forms.RadioButton rbPizzas;
        private System.Windows.Forms.RadioButton rbFries;
        private System.Windows.Forms.RadioButton rbSoftDrinks;
        private System.Windows.Forms.RadioButton rbAlcoholicDrinks;
        private System.Windows.Forms.RadioButton rbDeserts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMoneyPerShop;
        private System.Windows.Forms.Button btnMoneyPerShop;
        private System.Windows.Forms.Button btnCampingSpots;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCampingSpots;
        private System.Windows.Forms.Label lblUsersCheckedIn;
        private System.Windows.Forms.Button btnUsersOverview;
        private System.Windows.Forms.Label lblAllUsers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chUsersMoney;
    }
}

