using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Devices.Sensors;
using Microsoft.Devices;
using System.Windows.Media.Imaging;

namespace MotionSample
{
    public partial class RawCamera : PhoneApplicationPage
    {
        PhotoCamera photoCamera;
        
        public RawCamera()
        {
            InitializeComponent();
            photoCamera = new PhotoCamera();
            photoCamera.CaptureImageAvailable += new EventHandler<ContentReadyEventArgs>(photoCamera_CaptureImageAvailable);
            CameraSource.SetSource(photoCamera);
        }

        void photoCamera_CaptureImageAvailable(object sender, ContentReadyEventArgs e)
        {
            Dispatcher.BeginInvoke(() => CaptureImage(e));
        }

        void CaptureImage(ContentReadyEventArgs e)
        {
            BitmapImage image = new BitmapImage();
            image.SetSource(e.ImageStream);
            CameraCapture.Source = image;
            VideoBox.Visibility = Visibility.Collapsed;
        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            photoCamera.Focus();
        }

        private void PhotoButton_Click(object sender, EventArgs e)
        {
            photoCamera.CaptureImage();
        }

        private void CameraCapture_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            VideoBox.Visibility = Visibility.Visible;
        }
    }
}