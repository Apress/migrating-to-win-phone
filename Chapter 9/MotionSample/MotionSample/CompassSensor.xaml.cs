using System;
using Microsoft.Phone.Controls;
using Microsoft.Devices.Sensors;
using Microsoft.Xna.Framework;

namespace MotionSample
{
    public partial class CompassSensor : PhoneApplicationPage
    {
        Compass compass;
        
        public CompassSensor()
        {
            InitializeComponent();

            if (Compass.IsSupported)
            {
                compass = new Compass();
                compass.TimeBetweenUpdates = TimeSpan.FromMilliseconds(1);
                compass.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<CompassReading>>(compass_CurrentValueChanged);
                compass.Start();
            }
        }

        void compass_CurrentValueChanged(object sender, SensorReadingEventArgs<CompassReading> e)
        {
            Dispatcher.BeginInvoke(() => UpdateUI(e.SensorReading));
        }

        private void UpdateUI(CompassReading compassReading)
        {
            // Show the numeric values.
            magneticValue.Text = compassReading.MagneticHeading.ToString("0.00");
            trueValue.Text = compassReading.TrueHeading.ToString("0.00");

            // Show the values graphically.
            magneticLine.X2 = magneticLine.X1 - (200 * Math.Sin(MathHelper.ToRadians((float)compassReading.MagneticHeading)));
            magneticLine.Y2 = magneticLine.Y1 - (200 * Math.Cos(MathHelper.ToRadians((float)compassReading.MagneticHeading)));

            xBlock.Text = "X: " + compassReading.MagnetometerReading.X.ToString("0.00");
            yBlock.Text = "Y: " + compassReading.MagnetometerReading.Y.ToString("0.00");
            zBlock.Text = "Z: " + compassReading.MagnetometerReading.Z.ToString("0.00");

            
        }
    }
}