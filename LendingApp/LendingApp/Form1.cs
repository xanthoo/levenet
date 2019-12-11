using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace LendingApp
{
    public partial class LendingForm : Form
    {
        private RFID rfidReader;

        private User currentUser;

        private Item selectedItem;

        public LendingForm()
        {
            InitializeComponent();

            DBHelper.initialize();

            gbVisitorInfo.Hide();
            gbItemInfo.Hide();
            btnLendItem.Hide();
            cmbItemCondition.SelectedIndex = 0;

            hideNoItemsLabel();

            try
            {
                rfidReader = new RFID();
                rfidReader.Tag += new RFIDTagEventHandler(HandleTag);
            }
            catch (PhidgetException) { Console.WriteLine("error at start-up."); }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                rfidReader.Open(); //if successful, it will call the Attach-event.
                btnScan.Text = "Scanning...";
                btnScan.Enabled = false;
            }
            catch (PhidgetException) { MessageBox.Show("No RFID reader opened"); }
        }

        private void HandleTag(object sender, RFIDTagEventArgs e)
        {
            String tag = e.Tag;

            LoadVisitorInfo(tag);
        }

        private void hideNoItemsLabel()
        {
            lblNoItems.Hide();
            lbBorrowedItems.Show();
        }

        private void showNoItemsLabel(String name)
        {
            lblNoItems.Text = "No items borrowed by " + name;
            lblNoItems.Show();
        }

        private void LoadVisitorInfo(string tag)
        {
            currentUser = DBHelper.getUser(tag);

            lblName.Text = currentUser.Name;
            lblDoB.Text = currentUser.DoB.ToString("dd-MM-yyyy");

            gbVisitorInfo.Show();

            rfidReader.Close();
            btnScan.Text = "Scan bracelet";
            btnScan.Enabled = true;

            showLoanedItems();

            if (!btnLendItem.Visible)
            {
                btnLendItem.Show();
            }
        }

        private void showLoanedItems()
        {
            List<Item> items = DBHelper.getLoanedItems(currentUser.ID);

            if (items.Count == 0 || items == null)
            {
                showNoItemsLabel(currentUser.Name);
            }
            else
            {
                hideNoItemsLabel();
                lbBorrowedItems.Items.Clear();
                foreach (Item i in items)
                {
                    lbBorrowedItems.Items.Add(i.Name);
                }
            }
        }

        private Item getItem(String name)
        {
            return DBHelper.getItemInfo(name);
        }

        private void lendItem()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to lend this item?", "Hold up", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (DBHelper.borrowItem(selectedItem, currentUser) &&
                DBHelper.setHasLoanedItem(currentUser))
                {
                    lbBorrowedItems.Items.Add(selectedItem.Name);
                    hideNoItemsLabel();
                    hideItemInfo();
                }
            }   
        }

        private void hideItemInfo()
        {
            gbItemInfo.Hide();
            btnLendItem.Hide();
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            selectedItem = getItem(Constants.ADAPTER);

            showInfo();
        }

        private void btnBaterry_Click(object sender, EventArgs e)
        {
            selectedItem = getItem(Constants.BATTERY);

            showInfo();
        }

        private void btnFridgeBox_Click(object sender, EventArgs e)
        {
            selectedItem = getItem(Constants.FRIDGE_BOX);

            showInfo();
        }

        private void btnPolaroid_Click(object sender, EventArgs e)
        {
            selectedItem = getItem(Constants.POLAROID);

            showInfo();
        }

        private void showInfo()
        {
            lblHourPrice.Text = selectedItem.PricePerHour.ToString();
            lblItemPricePerDay.Text = selectedItem.PricePerDay.ToString();
            lblItemDeposit.Text = (selectedItem.PricePerDay * 5).ToString();

            gbItemInfo.Show();

            if (currentUser != null)
            {
                btnLendItem.Show();
            }
        }

        private void btnLendItem_Click(object sender, EventArgs e)
        {
            lendItem();
        }
    }
}
