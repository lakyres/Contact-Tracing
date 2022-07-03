using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.IO;

namespace contact_tracing
{
    public partial class qrcodescanner : Form
    {
        public qrcodescanner()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;

        private void qrcodescanner_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter_info in filter)
                webcam.Items.Add(filter_info.Name);
            webcam.SelectedIndex = 0;
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[webcam.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevie_NewFrame;
            captureDevice.Start();
            timer.Start();
        }

        private void CaptureDevie_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            camera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void qrcodescanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (camera.Image != null)
            {
                BarcodeReader QRcode = new BarcodeReader();
                Result result = QRcode.Decode((Bitmap)camera.Image);
                if (result != null)
                {
                    txt_display.Text = result.ToString();
                    timer.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\angel\source\repos\contact tracing legit totoo\records\" + date.Text + ".txt", true);
            file.WriteLine("");
            file.WriteLine("Personal Information");
            file.WriteLine(txt_display.Text);
            file.WriteLine("Date: " + date.Text);

            file.Close();

            MessageBox.Show("Thank you. Be careful and take care!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Stay Safe. Ingat!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
