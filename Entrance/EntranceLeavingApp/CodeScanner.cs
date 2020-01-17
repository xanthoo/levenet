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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace EntranceLeavingApp
{
    public partial class CodeScanner : Form
    {

        public static int qr_code_result = 0;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public Ticket currentTicket;


        public CodeScanner()
        {
            InitializeComponent();
        }

       

        private void CodeScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CodeScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(captureDevice!=null)
            //{
            if (captureDevice.IsRunning)
            { captureDevice.Stop();
            }
            //}

           //Hide();
           //e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox.Image!=null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                if(result!=null)
                {
                    txtQRcode.Text = result.ToString();
                    qr_code_result = Convert.ToInt32(txtQRcode.Text);
                    this.Hide();
                }
            }
        }
        
    }
}
