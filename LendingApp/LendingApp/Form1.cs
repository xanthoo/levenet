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

        public LendingForm()
        {
            InitializeComponent();

            DBHelper.initialize();

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
                rfidReader.Open(); //if successfully, it will call the Attach-event.
            }
            catch (PhidgetException) { Console.WriteLine("No RFID reader opened"); }
        }

        private void HandleTag(object sender, RFIDTagEventArgs e)
        {
            String tag = e.Tag;

            Console.WriteLine(tag);

            LoadVisitorInfo(tag);
        }

        private void LoadVisitorInfo(string tag)
        {
            currentUser = DBHelper.getUser(tag);

            lblName.Text = currentUser.Name;
            lblDoB.Text = currentUser.DoB.ToString("dd-MM-yyyy");
        }
    }
}
