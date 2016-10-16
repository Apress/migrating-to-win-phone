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
using System.Device.Location;

namespace MotionSample
{
    public partial class Location : PhoneApplicationPage
    {
        GeoCoordinateWatcher gcw = new GeoCoordinateWatcher();
        
        public Location()
        {
            InitializeComponent();

            gcw.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(gcw_StatusChanged);
            gcw.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(gcw_PositionChanged);
            gcw.Start();
        }

        void gcw_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            string Latitude = e.Position.Location.Latitude.ToString();
            string Longitude = e.Position.Location.Longitude.ToString();
            string Accuracy = e.Position.Location.HorizontalAccuracy.ToString();
        }

        void gcw_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            string Status = e.Status.ToString();
        }
    }
}