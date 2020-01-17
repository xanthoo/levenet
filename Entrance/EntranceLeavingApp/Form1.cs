using System;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace EntranceLeavingApp
{
    public partial class Form1 : Form
    {
        CodeScanner CodeScanner = new CodeScanner();

        private RFID rfidReader;
        private User currentUser;
        private Ticket currentTicket;
        private string tag;

        public Form1()
        {
            InitializeComponent();
            DBHelper.Initialize();            


            this.gbVisitorInfo.Visible = false;
            this.radioButton1.Checked = true;
            this.btn_CheckIn.Visible = false;
            this.buttonChangeAgeTypeOfTheTicket.Visible = false;
            this.btnScan.Visible = false;
            this.lblNoItems.Visible = false;
            this.lblTicketId.Visible = false;

            try
            {
                rfidReader = new RFID();
                rfidReader.Tag += ScanBracelet_AssignToUser;
            }
            catch (PhidgetException) { Console.WriteLine("Error at start-up."); }

        } 
        
        private void buttonChangeTypeOfTheTicket_Click(object sender, EventArgs e)
        {
            buttonChangeAgeTypeOfTheTicket.Enabled = false;

            if (DBHelper.ChangeToMinor(currentTicket))
            {
                ShowUserInfo(tag);
            }

            MessageBox.Show("User is marked as a minor!");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                btnScan.Text = "Scanning...";
                btnScan.Enabled = false;
                rfidReader.Open();
            }
            catch (PhidgetException) { MessageBox.Show("No RFID reader opened"); }
        }

        //EXIT CHECKING
        private void showNoItemsLabel(String name)
        {
            lblNoItems.Text = "No items borrowed by " + name;
            lblNoItems.Show();
        }
        private void hideNoItemsLabel()
        {
            lblNoItems.Text = "VISITOR HAS LOANED ITEMS!";
        }
        private void entranceLoaningCheck(User user)
        {
            if (user.HasLoanedItem == true)
            {
                hideNoItemsLabel();
            }
            else
            {
                showNoItemsLabel(user.Name);
            }
        }

        //RADIOBUTTON LOGIC
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            grEntrance.Visible = true;
            grExit.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            grExit.Visible = true;
            grEntrance.Visible = false;
        }
        
        //QRCODE
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = CodeScanner.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.lblTicketId.Text = CodeScanner.qr_code_result.ToString();
                
                this.btnScan.Visible = true;
            }            
        }

        private void btn_assignToBracelet_Click(object sender, EventArgs e)
        {
            rfidReader.Open();
        }

        void ScanBracelet_AssignToUser(object sender_, RFIDTagEventArgs e_)
        {
            if (DBHelper.AssignTagToTicket(e_.Tag, CodeScanner.qr_code_result))
            {
                tag = e_.Tag;
                ShowUserInfo(tag);

                this.btn_CheckIn.Visible = true;
                this.buttonChangeAgeTypeOfTheTicket.Visible = true;
            }
            else
            {
                MessageBox.Show("You are already checked in!");
                rfidReader.Close();
            }
        }

        private void ShowUserInfo(String tag)
        {
            currentUser = DBHelper.GetUser(tag);
            currentTicket = DBHelper.TicketFromQR(CodeScanner.qr_code_result);

            lblName.Text = currentUser.Name;
            lblDoB.Text = currentUser.DoB.ToString("dd-MM-yyyy");
            lblcredit.Text = currentUser.Credit.ToString();
            lblage.Text = currentTicket.TicketAgeType;

            gbVisitorInfo.Show();

            rfidReader.Close();
            btnScan.Text = "Scan bracelet";
            btnScan.Enabled = true;
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            if (DBHelper.CheckInUser(currentUser)) MessageBox.Show("User checked in");
            else MessageBox.Show("Something went wrong.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DBHelper.CheckOutUser(currentUser)) MessageBox.Show("User checked out");
            else MessageBox.Show("Something went wrong.");
        }
    }
}
