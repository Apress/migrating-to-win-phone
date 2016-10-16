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

namespace MotionSample
{
    public partial class AccelerometerSensor : PhoneApplicationPage
    {
        Accelerometer accelerometer;
        
        public AccelerometerSensor()
        {
            InitializeComponent();

            accelerometer = new Accelerometer();
            accelerometer.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<AccelerometerReading>>(accelerometer_CurrentValueChanged);
            accelerometer.Start();
        }

        void accelerometer_CurrentValueChanged(object sender, SensorReadingEventArgs<AccelerometerReading> e)
        {
            Dispatcher.BeginInvoke(() => UpdateUI(e));
        }

        void UpdateUI(SensorReadingEventArgs<AccelerometerReading> e)
        {
            xValue.Text = e.SensorReading.Acceleration.X.ToString("0.000");
            yValue.Text = e.SensorReading.Acceleration.Y.ToString("0.000");
            zValue.Text = e.SensorReading.Acceleration.Z.ToString("0.000");
        }
    }
}