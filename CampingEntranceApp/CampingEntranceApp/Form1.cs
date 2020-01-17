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

namespace CampingEntranceApp
{
    public partial class Form1 : Form
    {

        private RFID rfidReader;
        private User currentUser;
        private Ticket currentTicket;
        private Camping currentCamping;


        public Form1()
        {
            InitializeComponent();
            DBHelper.initialize();

            try
            {
                rfidReader = new RFID();
                rfidReader.Tag += new RFIDTagEventHandler(HandleTag);
            }
            catch (PhidgetException) { Console.WriteLine("error at start-up."); }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (currentTicket.TicketType == 3)
                {
                    if (currentUser.Camp_id == currentCamping.ID)
                    {
                        if (currentCamping.Availability > 0)
                        { MessageBox.Show("Visitor has a camping spot!"); }
                    }
                }
                else
                {
                    MessageBox.Show("This Visitor does not have a camping spot!");
                }
            
        }

        private void HandleTag(object sender, RFIDTagEventArgs e)
        {
            String tag = e.Tag;
            currentUser = DBHelper.getUser(tag);
            currentTicket = DBHelper.GetTicket(tag);
            currentCamping = DBHelper.GetCamping(tag);
        }
    }
}
