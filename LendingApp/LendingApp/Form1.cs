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
        private decimal selectedItemDeposit;

        private Item borrowedItem;

        private Item[] items;

        public LendingForm()
        {
            InitializeComponent();

            DBHelper.initialize();

            refreshItems();

            gbVisitorInfo.Hide();
            gbItemInfo.Hide();
            gbSelectedItem.Hide();
            btnLendItem.Hide();
            cmbItemCondition.SelectedIndex = 0;

            hideNoItemsLabel();
            lbBorrowedItems.Hide();
            btnReturnItem.Hide();

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

            showUserInfo(tag);
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
            lbBorrowedItems.Hide();
        }

        private void showUserInfo(string tag)
        {
            currentUser = DBHelper.getUser(tag);

            lblName.Text = currentUser.Name;
            lblDoB.Text = currentUser.DoB.ToString("dd-MM-yyyy");

            gbVisitorInfo.Show();

            rfidReader.Close();
            btnScan.Text = "Scan bracelet";
            btnScan.Enabled = true;

            if (selectedItem != null && !btnLendItem.Visible)
            {
                btnLendItem.Show();
            }

            showLoanedItems();
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
                    lbBorrowedItems.Items.Add(i);
                }
            }
        }

        private Item getItem(String name)
        {
            return DBHelper.getItem(name);
        }

        private void lendItem()
        {
            if (currentUser.Credit < selectedItemDeposit)
            {
                MessageBox.Show("User has insufficient funds for this transaction", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to lend this item?", "Hold up", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (DBHelper.borrowItem(selectedItem, currentUser) &&
                        DBHelper.borrowItemForUser(currentUser, selectedItemDeposit))
                    {
                        selectedItem.BorrowedDate = DateTime.Now;
                        lbBorrowedItems.Items.Add(selectedItem);
                        hideNoItemsLabel();
                        hideItemInfo();
                        refreshItems();
                    }
                }
            }      
        }

        private void hideItemInfo()
        {
            gbItemInfo.Hide();
            btnLendItem.Hide();
        }

        private void refreshItems()
        {
            items = new Item[4];

            items[0] = getItem(Constants.ADAPTER);
            items[1] = getItem(Constants.BATTERY);
            items[2] = getItem(Constants.FRIDGE_BOX);
            items[3] = getItem(Constants.POLAROID);
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            selectedItem = items[0];
            selectedItemDeposit = selectedItem.PricePerDay * 5;

            showInfo();
        }

        private void btnBaterry_Click(object sender, EventArgs e)
        {
            selectedItem = items[1];
            selectedItemDeposit = selectedItem.PricePerDay * 5;

            showInfo();
        }

        private void btnFridgeBox_Click(object sender, EventArgs e)
        {
            selectedItem = items[2];
            selectedItemDeposit = selectedItem.PricePerDay * 5;

            showInfo();
        }

        private void btnPolaroid_Click(object sender, EventArgs e)
        {
            selectedItem = items[3];
            selectedItemDeposit = selectedItem.PricePerDay * 5;

            showInfo();
        }

        private void showInfo()
        {
            lblHourPrice.Text       = selectedItem.PricePerHour.ToString();
            lblItemPricePerDay.Text = selectedItem.PricePerDay.ToString();
            lblItemDeposit.Text     = selectedItemDeposit.ToString();

            gbItemInfo.Show();

            if (currentUser != null)
            {
                btnLendItem.Show();
            }
        }

        private void showBorrowedItemInfo()
        {
            int hours = getHourCount();
            int days = getDayCount(hours);
            decimal price = getTotalPrice(days, hours, borrowedItem.PricePerDay, borrowedItem.PricePerHour);

            lblReturnDays.Text = "" + days;
            lblReturnHours.Text = "" + hours;
            lblTotalReturnPrice.Text = "" + Math.Round(price, 2);

            Console.WriteLine("Hours: " + hours);

            gbSelectedItem.Show();
        }

        private int getHourCount()
        {
            if (borrowedItem != null)
            {
                TimeSpan time;

                DateTime borrowedDate = borrowedItem.BorrowedDate;
                DateTime currentDate = DateTime.Now;
                time = currentDate.Subtract(borrowedDate);

                double hours =  time.TotalMinutes / 60;

                return (int) Math.Ceiling(hours);
            }

            return -1;
        }

        private int getDayCount(int hours)
        {
            return hours / 24;
        }

        private decimal getTotalPrice(int days, int hours, decimal pricePerDay, decimal pricePerHour)
        {
            decimal price;

            if (days >= 1)
            {
                int remainingHours = hours - (days * 24);

                price = (days * pricePerDay) + (remainingHours * pricePerHour);
            }
            else
            {
                price = hours * pricePerHour;
            }

            return price;
        }

        private void btnLendItem_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                lendItem();
            }
            else
            {
                MessageBox.Show("No item selected", "Info");
            }
        }

        private void lbBorrowedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBorrowedItems.SelectedItem != null)
            {
                borrowedItem = (Item) lbBorrowedItems.SelectedItem;

                showBorrowedItemInfo();
                btnReturnItem.Show();

                Console.WriteLine("Selected item ID: " + borrowedItem.ID);
            }
            else
            {
                gbSelectedItem.Hide();
            }
        }

        private bool returnItem()
        {
            String condition = cmbItemCondition.Text;

            if (condition.Equals("Good"))
            {
                if (!DBHelper.returnDeposit(currentUser, borrowedItem.PricePerDay * 5))
                {
                    return false;   
                }
                else
                {
                    Console.WriteLine("Successfully returned deposit");
                }
            }

            if (lbBorrowedItems.Items.Count <= 1)
            {
                if (!DBHelper.setUserNoLoanedItems(currentUser))
                {
                    return false;
                }
                else
                {
                    showNoItemsLabel(currentUser.Name);
                }
            }

            if (!DBHelper.returnItem(borrowedItem))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Successfully returned item");
            }

            if (!DBHelper.chargeUser(currentUser, decimal.Parse(lblTotalReturnPrice.Text)))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Successfully charged user");
            }

            return true;
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            String message = "";
            String title = "";

            if (!returnItem())
            {
                message = "An error occurred while returning item";
                title = "Error";
            }
            else
            {
                lbBorrowedItems.Items.Remove(borrowedItem);

                message = "Successfully returned item";
                title = "Success";
            }

            MessageBox.Show(message, title);
        }
    }
}
