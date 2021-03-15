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
        string appPath = @"C:\Users\yauch\OneDrive\Documents\GitHub\TheCubeSolver\images\";
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
            // Connect the Paint event of the PictureBox to the event handler method.
            pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
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
        string message = "File saved sucessfully:";
        private void btnSave_Click(object sender, EventArgs e)
        {
            pic.Image.Save(appPath+"SavedImage.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            MessageBox.Show(message + "SavedImage.bmp");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void pic_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Rectangle ee = new Rectangle(75, 75, 200, 200);
            using (Pen pen = new Pen(Color.Purple, 2))
            {
                e.Graphics.DrawRectangle(pen, ee);
            }

        }

    }
}
