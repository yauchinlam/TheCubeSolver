using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace CubeSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCapureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
            private void VideoCapureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
            {
                pic.Image = (Bitmap)eventArgs.Frame.Clone();
            }


             void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (videoCaptureDevice.IsRunning == true)
                    videoCaptureDevice.Stop();
            }
      
        private void Camera_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
    }
}