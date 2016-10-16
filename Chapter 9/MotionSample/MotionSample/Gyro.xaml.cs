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
using Microsoft.Xna.Framework;

namespace MotionSample
{
    public partial class Gyro : PhoneApplicationPage
    {
        Gyroscope g;
        
        public Gyro()
        {
            InitializeComponent();

            if (Gyroscope.IsSupported)
            {
                g = new Gyroscope();
                g.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20);
                g.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<GyroscopeReading>>(g_CurrentValueChanged);
                g.Start();
            }
        }

        void g_CurrentValueChanged(object sender, SensorReadingEventArgs<GyroscopeReading> e)
        {
            Dispatcher.BeginInvoke(() => UpdateUI(e.SensorReading));
        }

        private void UpdateUI(GyroscopeReading gyroscopeReading)
        {
            statusTextBlock.Text = "getting data";

            Vector3 rotationRate = gyroscopeReading.RotationRate;

            // Show the numeric values.
            xTextBlock.Text = "X: " + rotationRate.X.ToString("0.00");
            yTextBlock.Text = "Y: " + rotationRate.Y.ToString("0.00");
            zTextBlock.Text = "Z: " + rotationRate.Z.ToString("0.00");

            // Show the values graphically.
            xLine.X2 = xLine.X1 + rotationRate.X * 200;
            yLine.Y2 = yLine.Y1 - rotationRate.Y * 200;
            zLine.X2 = zLine.X1 - rotationRate.Z * 100;
            zLine.Y2 = zLine.Y1 + rotationRate.Z * 100;
        }
    }
}