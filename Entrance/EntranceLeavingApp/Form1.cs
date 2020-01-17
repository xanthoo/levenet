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

namespace EntranceLeavingApp
{
    public partial class Form1 : Form
    {
       
        CodeScanner CodeScanner = new CodeScanner();
        

        private RFID rfidReader;
        private User currentUser;
        private Ticket currentTicket;
        
        


        public Form1()
        {
            InitializeComponent();
            DBHelper.initialize();
            

            labelStatusOfChecking.Text = "Entry checking";
            gbVisitorInfo.Visible = false;
            radioButton1.Checked = true;


            
            try
            {
                rfidReader = new RFID();
                //rfidReader.Tag += new RFIDTagEventHandler(HandleTag);
                rfidReader.Tag += ScanThenAssign;
            }
            catch (PhidgetException) { Console.WriteLine("error at start-up."); }

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
            currentTicket = DBHelper.TicketFromQR(CodeScanner.qr_code_result);
            if (currentTicket!=null && currentUser!=null)
            {
                lblName.Text = currentUser.Name;
                lblDoB.Text = currentUser.DoB.ToString("dd-MM-yyyy");
                lblcredit.Text = currentUser.Credit.ToString();
                //lblage.Text = currentTicket.TicketAgeType.ToString();
            }
            else { MessageBox.Show("Something went wrong"); }
            
            
            gbVisitorInfo.Show();

            rfidReader.Close();
            btnScan.Text = "Scan bracelet";
            btnScan.Enabled = true;
            
        }
        
        private void buttonChangeTypeOfTheTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket is changen to underaged!");
            buttonChangeAgeTypeOfTheTicket.Enabled = false;
            this.currentTicket.TicketAgeType = "minor";

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                rfidReader.Open();
                btnScan.Text = "Scanning...";
                btnScan.Enabled = false;
                gbVisitorInfo.Show();
                //DELETE THIS LATER (ONLY FOR TESTING!!!
                label5.Text = CodeScanner.qr_code_result.ToString();
                //
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
        //

        //RADIOBUTTON LOGIC
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelStatusOfChecking.Text = "Entry checking";
            grEntrance.Visible = true;
            grExit.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelStatusOfChecking.Text = "Exit checking";
            grExit.Visible = true;
            grEntrance.Visible = false;
        }

        
        //QRCODE
        private void button1_Click(object sender, EventArgs e)
        {
            CodeScanner.Show();
        }

        private void btn_assignToBracelet_Click(object sender, EventArgs e)
        {
            rfidReader.Open();
        }

        void ScanThenAssign(object sender_, RFIDTagEventArgs e_)
        {
            bool result = true;

            try
            {
                DBHelper.insertRFIDcodetoDB(e_.Tag, CodeScanner.qr_code_result);
                result= DBHelper.insertRFIDcodetoDB(e_.Tag, CodeScanner.qr_code_result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (result)
            {
                MessageBox.Show("Success!");
                rfidReader.Close();
                //if (checkIn(currentUser))
                //{

                //}
            }
            else
            {
                MessageBox.Show("You are already checked in!");
                rfidReader.Close();
            }
        }

    }
}
