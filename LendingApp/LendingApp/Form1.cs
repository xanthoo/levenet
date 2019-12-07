using System;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace LendingApp
{
    public partial class LendingForm : Form
    {
        private RFID rfidReader;

        private User currentUser;

        private Item item;

        public LendingForm()
        {
            InitializeComponent();

            DBHelper.initialize();

            gbVisitorInfo.Hide();
            gbItemInfo.Hide();
            btnLendItem.Hide();

            try
            {
                rfidReader         = new RFID();
                rfidReader.Tag    += new RFIDTagEventHandler(HandleTag);
            }
            catch (PhidgetException) { Console.WriteLine("error at start-up."); }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                rfidReader.Open(); //if successful, it will call the Attach-event.
            }
            catch (PhidgetException) { MessageBox.Show("No RFID reader opened"); }

        }

        private void HandleTag(object sender, RFIDTagEventArgs e)
        {
            String tag = e.Tag;

            //Console.WriteLine(tag);
            LoadVisitorInfo(tag);
        }

        private void LoadVisitorInfo(string tag)
        {
            currentUser = DBHelper.getUser(tag);

            lblName.Text = currentUser.Name;
            lblDoB.Text = currentUser.DoB.ToString("dd-MM-yyyy");

            gbVisitorInfo.Show();

            rfidReader.Close();
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            item = DBHelper.getItemInfo("adapter");

            lblHourPrice.Text = item.PricePerHour.ToString();
            lblItemPricePerDay.Text = item.PricePerDay.ToString();
            lblItemDeposit.Text = (item.PricePerDay * 5).ToString();

            gbItemInfo.Show();
            btnLendItem.Show();
        }

        private void btnBaterry_Click(object sender, EventArgs e)
        {
            item = DBHelper.getItemInfo("battery");

            lblHourPrice.Text = item.PricePerHour.ToString();
            lblItemPricePerDay.Text = item.PricePerDay.ToString();
            lblItemDeposit.Text = (item.PricePerDay * 5).ToString();

            gbItemInfo.Show();
            btnLendItem.Show();
        }

        private void btnFridgeBox_Click(object sender, EventArgs e)
        {
            item = DBHelper.getItemInfo("fridge_box");

            lblHourPrice.Text = item.PricePerHour.ToString();
            lblItemPricePerDay.Text = item.PricePerDay.ToString();
            lblItemDeposit.Text = (item.PricePerDay * 5).ToString();

            gbItemInfo.Show();
            btnLendItem.Show();
        }

        private void btnPolaroid_Click(object sender, EventArgs e)
        {
            item = DBHelper.getItemInfo("polaroid");

            lblHourPrice.Text = item.PricePerHour.ToString();
            lblItemPricePerDay.Text = item.PricePerDay.ToString();
            lblItemDeposit.Text = (item.PricePerDay * 5).ToString();

            gbItemInfo.Show();
            btnLendItem.Show();
        }

        private void btnLendItem_Click(object sender, EventArgs e)
        {

        }
    }
}
