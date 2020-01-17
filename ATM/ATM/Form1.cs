using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ATM
{
    public partial class Form1 : Form
    {
        private DBHelper dbhelper;
        private List<Deposits> listOfDeposits;
        private string startDate;
        private string endDate;

        public Form1()
        {
            InitializeComponent();
            dbhelper = new DBHelper();
            this.Text = "ATM";
            listOfDeposits = new List<Deposits>();
            startDate = "";
            endDate = "";
            //lbQuickS.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lbQuickS.Items.Clear();
        
            //lbQuickS.Visible = true;
            //lbQuickS.Items.Add(deposit.GetInfo());      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Save DB Data To File
            OpenFileDialog();
            LoadDepositsToDb();
        }

        private void LoadDepositsToDb()
        {
            dbhelper.SaveDepositsData(listOfDeposits, startDate, endDate);
        }

        private void OpenFileDialog()
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //string path = @"C:/Users/Admin/Desktop/fff.txt";
                //string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
                fs = new FileStream(@"../../../deposits.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string lineCurrentlyRead = "";
                string bankAcc = sr.ReadLine();
                startDate = sr.ReadLine();
                endDate = sr.ReadLine();
                sr.ReadLine();

                while ((lineCurrentlyRead = sr.ReadLine()) != null)
                { 
                    string[] splitLines = lineCurrentlyRead.Split();
                    Deposits deposit = new Deposits(Convert.ToInt32(splitLines[0]), Convert.ToDecimal(splitLines[1]), bankAcc);
                    listOfDeposits.Add(deposit);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }

            private void button3_Click_1(object sender, EventArgs e)
        {
            //// Extract DB Data
            //listBox1.Items.Clear();
            //listOfDeposits = dbhelper.GetDepositData();
            //foreach (Deposits deposit in listOfDeposits)
            //{
            //    listBox1.Items.Add(deposit.GetInfo());
            //}
        }
    }
}
