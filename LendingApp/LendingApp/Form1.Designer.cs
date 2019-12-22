namespace LendingApp
{
    partial class LendingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendingForm));
            this.btnLendItem = new System.Windows.Forms.Button();
            this.gbSelectedItem = new System.Windows.Forms.GroupBox();
            this.cmbItemCondition = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblReturnHours = new System.Windows.Forms.Label();
            this.lblTotalReturnPrice = new System.Windows.Forms.Label();
            this.lblReturnDays = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.gbItemInfo = new System.Windows.Forms.GroupBox();
            this.lblItemDeposit = new System.Windows.Forms.Label();
            this.lblItemPricePerDay = new System.Windows.Forms.Label();
            this.lblHourPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.gbVisitorInfo = new System.Windows.Forms.GroupBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPolaroid = new System.Windows.Forms.Button();
            this.btnFridgeBox = new System.Windows.Forms.Button();
            this.btnBaterry = new System.Windows.Forms.Button();
            this.btnAdapter = new System.Windows.Forms.Button();
            this.lbBorrowedItems = new System.Windows.Forms.ListBox();
            this.lblNoItems = new System.Windows.Forms.Label();
            this.gbSelectedItem.SuspendLayout();
            this.gbItemInfo.SuspendLayout();
            this.gbVisitorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLendItem
            // 
            this.btnLendItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLendItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLendItem.ForeColor = System.Drawing.Color.Black;
            this.btnLendItem.Location = new System.Drawing.Point(526, 354);
            this.btnLendItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLendItem.Name = "btnLendItem";
            this.btnLendItem.Size = new System.Drawing.Size(118, 38);
            this.btnLendItem.TabIndex = 18;
            this.btnLendItem.Text = "Lend item";
            this.btnLendItem.UseVisualStyleBackColor = true;
            this.btnLendItem.Click += new System.EventHandler(this.btnLendItem_Click);
            // 
            // gbSelectedItem
            // 
            this.gbSelectedItem.Controls.Add(this.cmbItemCondition);
            this.gbSelectedItem.Controls.Add(this.label21);
            this.gbSelectedItem.Controls.Add(this.lblReturnHours);
            this.gbSelectedItem.Controls.Add(this.lblTotalReturnPrice);
            this.gbSelectedItem.Controls.Add(this.lblReturnDays);
            this.gbSelectedItem.Controls.Add(this.label18);
            this.gbSelectedItem.Controls.Add(this.label19);
            this.gbSelectedItem.Controls.Add(this.label20);
            this.gbSelectedItem.Location = new System.Drawing.Point(469, 426);
            this.gbSelectedItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSelectedItem.Name = "gbSelectedItem";
            this.gbSelectedItem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSelectedItem.Size = new System.Drawing.Size(225, 147);
            this.gbSelectedItem.TabIndex = 16;
            this.gbSelectedItem.TabStop = false;
            this.gbSelectedItem.Text = "Selected Item";
            // 
            // cmbItemCondition
            // 
            this.cmbItemCondition.BackColor = System.Drawing.Color.White;
            this.cmbItemCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCondition.FormattingEnabled = true;
            this.cmbItemCondition.Items.AddRange(new object[] {
            "Good",
            "Damaged"});
            this.cmbItemCondition.Location = new System.Drawing.Point(97, 118);
            this.cmbItemCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbItemCondition.Name = "cmbItemCondition";
            this.cmbItemCondition.Size = new System.Drawing.Size(80, 21);
            this.cmbItemCondition.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Condition";
            // 
            // lblReturnHours
            // 
            this.lblReturnHours.Location = new System.Drawing.Point(94, 31);
            this.lblReturnHours.Name = "lblReturnHours";
            this.lblReturnHours.Size = new System.Drawing.Size(87, 13);
            this.lblReturnHours.TabIndex = 7;
            this.lblReturnHours.Text = "4";
            // 
            // lblTotalReturnPrice
            // 
            this.lblTotalReturnPrice.Location = new System.Drawing.Point(94, 90);
            this.lblTotalReturnPrice.Name = "lblTotalReturnPrice";
            this.lblTotalReturnPrice.Size = new System.Drawing.Size(87, 13);
            this.lblTotalReturnPrice.TabIndex = 6;
            this.lblTotalReturnPrice.Text = "69";
            // 
            // lblReturnDays
            // 
            this.lblReturnDays.Location = new System.Drawing.Point(94, 59);
            this.lblReturnDays.Name = "lblReturnDays";
            this.lblReturnDays.Size = new System.Drawing.Size(87, 13);
            this.lblReturnDays.TabIndex = 5;
            this.lblReturnDays.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total price";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Days";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Hours";
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReturnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnItem.ForeColor = System.Drawing.Color.Black;
            this.btnReturnItem.Location = new System.Drawing.Point(526, 600);
            this.btnReturnItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(118, 38);
            this.btnReturnItem.TabIndex = 17;
            this.btnReturnItem.Text = "Return item";
            this.btnReturnItem.UseVisualStyleBackColor = true;
            this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
            // 
            // gbItemInfo
            // 
            this.gbItemInfo.Controls.Add(this.lblItemDeposit);
            this.gbItemInfo.Controls.Add(this.lblItemPricePerDay);
            this.gbItemInfo.Controls.Add(this.lblHourPrice);
            this.gbItemInfo.Controls.Add(this.label14);
            this.gbItemInfo.Controls.Add(this.label15);
            this.gbItemInfo.Controls.Add(this.label16);
            this.gbItemInfo.Location = new System.Drawing.Point(469, 218);
            this.gbItemInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbItemInfo.Name = "gbItemInfo";
            this.gbItemInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbItemInfo.Size = new System.Drawing.Size(225, 116);
            this.gbItemInfo.TabIndex = 14;
            this.gbItemInfo.TabStop = false;
            this.gbItemInfo.Text = "Item info";
            // 
            // lblItemDeposit
            // 
            this.lblItemDeposit.Location = new System.Drawing.Point(94, 90);
            this.lblItemDeposit.Name = "lblItemDeposit";
            this.lblItemDeposit.Size = new System.Drawing.Size(79, 13);
            this.lblItemDeposit.TabIndex = 6;
            this.lblItemDeposit.Text = "225";
            // 
            // lblItemPricePerDay
            // 
            this.lblItemPricePerDay.Location = new System.Drawing.Point(94, 59);
            this.lblItemPricePerDay.Name = "lblItemPricePerDay";
            this.lblItemPricePerDay.Size = new System.Drawing.Size(79, 13);
            this.lblItemPricePerDay.TabIndex = 5;
            this.lblItemPricePerDay.Text = "45";
            // 
            // lblHourPrice
            // 
            this.lblHourPrice.Location = new System.Drawing.Point(94, 31);
            this.lblHourPrice.Name = "lblHourPrice";
            this.lblHourPrice.Size = new System.Drawing.Size(79, 13);
            this.lblHourPrice.TabIndex = 4;
            this.lblHourPrice.Text = "15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Deposit";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Price per day";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Price per hour";
            // 
            // btnScan
            // 
            this.btnScan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.ForeColor = System.Drawing.Color.Black;
            this.btnScan.Location = new System.Drawing.Point(526, 28);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(118, 38);
            this.btnScan.TabIndex = 13;
            this.btnScan.Text = "Scan bracelet";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // gbVisitorInfo
            // 
            this.gbVisitorInfo.Controls.Add(this.lblDoB);
            this.gbVisitorInfo.Controls.Add(this.lblName);
            this.gbVisitorInfo.Controls.Add(this.label2);
            this.gbVisitorInfo.Controls.Add(this.label1);
            this.gbVisitorInfo.Location = new System.Drawing.Point(469, 109);
            this.gbVisitorInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVisitorInfo.Name = "gbVisitorInfo";
            this.gbVisitorInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVisitorInfo.Size = new System.Drawing.Size(225, 89);
            this.gbVisitorInfo.TabIndex = 12;
            this.gbVisitorInfo.TabStop = false;
            this.gbVisitorInfo.Text = "Visitor info";
            // 
            // lblDoB
            // 
            this.lblDoB.Location = new System.Drawing.Point(86, 59);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(133, 13);
            this.lblDoB.TabIndex = 5;
            this.lblDoB.Text = "4.20.1969";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(86, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Eftim4o";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of birth";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnPolaroid
            // 
            this.btnPolaroid.BackgroundImage = global::LendingApp.Properties.Resources.polaroid;
            this.btnPolaroid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolaroid.Location = new System.Drawing.Point(249, 218);
            this.btnPolaroid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPolaroid.Name = "btnPolaroid";
            this.btnPolaroid.Size = new System.Drawing.Size(192, 174);
            this.btnPolaroid.TabIndex = 22;
            this.btnPolaroid.UseVisualStyleBackColor = true;
            this.btnPolaroid.Click += new System.EventHandler(this.btnPolaroid_Click);
            // 
            // btnFridgeBox
            // 
            this.btnFridgeBox.BackgroundImage = global::LendingApp.Properties.Resources.fridgeBox;
            this.btnFridgeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFridgeBox.Location = new System.Drawing.Point(25, 218);
            this.btnFridgeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFridgeBox.Name = "btnFridgeBox";
            this.btnFridgeBox.Size = new System.Drawing.Size(193, 174);
            this.btnFridgeBox.TabIndex = 21;
            this.btnFridgeBox.UseVisualStyleBackColor = true;
            this.btnFridgeBox.Click += new System.EventHandler(this.btnFridgeBox_Click);
            // 
            // btnBaterry
            // 
            this.btnBaterry.BackgroundImage = global::LendingApp.Properties.Resources.externalBaterry;
            this.btnBaterry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaterry.Location = new System.Drawing.Point(249, 28);
            this.btnBaterry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaterry.Name = "btnBaterry";
            this.btnBaterry.Size = new System.Drawing.Size(192, 170);
            this.btnBaterry.TabIndex = 20;
            this.btnBaterry.UseVisualStyleBackColor = true;
            this.btnBaterry.Click += new System.EventHandler(this.btnBaterry_Click);
            // 
            // btnAdapter
            // 
            this.btnAdapter.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdapter.BackgroundImage = global::LendingApp.Properties.Resources.adapter;
            this.btnAdapter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdapter.Location = new System.Drawing.Point(25, 28);
            this.btnAdapter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.Size = new System.Drawing.Size(193, 170);
            this.btnAdapter.TabIndex = 19;
            this.btnAdapter.UseVisualStyleBackColor = false;
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // lbBorrowedItems
            // 
            this.lbBorrowedItems.FormattingEnabled = true;
            this.lbBorrowedItems.Location = new System.Drawing.Point(25, 426);
            this.lbBorrowedItems.Name = "lbBorrowedItems";
            this.lbBorrowedItems.Size = new System.Drawing.Size(416, 212);
            this.lbBorrowedItems.TabIndex = 23;
            this.lbBorrowedItems.SelectedIndexChanged += new System.EventHandler(this.lbBorrowedItems_SelectedIndexChanged);
            // 
            // lblNoItems
            // 
            this.lblNoItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoItems.Location = new System.Drawing.Point(22, 426);
            this.lblNoItems.Name = "lblNoItems";
            this.lblNoItems.Size = new System.Drawing.Size(419, 212);
            this.lblNoItems.TabIndex = 24;
            this.lblNoItems.Text = "No items borrowed";
            this.lblNoItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(736, 657);
            this.Controls.Add(this.btnPolaroid);
            this.Controls.Add(this.btnFridgeBox);
            this.Controls.Add(this.btnBaterry);
            this.Controls.Add(this.btnAdapter);
            this.Controls.Add(this.btnLendItem);
            this.Controls.Add(this.gbSelectedItem);
            this.Controls.Add(this.btnReturnItem);
            this.Controls.Add(this.gbItemInfo);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.gbVisitorInfo);
            this.Controls.Add(this.lbBorrowedItems);
            this.Controls.Add(this.lblNoItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LendingForm";
            this.Text = "Event";
            this.gbSelectedItem.ResumeLayout(false);
            this.gbSelectedItem.PerformLayout();
            this.gbItemInfo.ResumeLayout(false);
            this.gbItemInfo.PerformLayout();
            this.gbVisitorInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSelectedItem;
        private System.Windows.Forms.ComboBox cmbItemCondition;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblReturnHours;
        private System.Windows.Forms.Label lblTotalReturnPrice;
        private System.Windows.Forms.Label lblReturnDays;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gbItemInfo;
        private System.Windows.Forms.Label lblItemDeposit;
        private System.Windows.Forms.Label lblItemPricePerDay;
        private System.Windows.Forms.Label lblHourPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbVisitorInfo;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPolaroid;
        private System.Windows.Forms.Button btnFridgeBox;
        private System.Windows.Forms.Button btnBaterry;
        private System.Windows.Forms.Button btnAdapter;
        private System.Windows.Forms.ListBox lbBorrowedItems;
        private System.Windows.Forms.Button btnLendItem;
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblNoItems;
    }
}

