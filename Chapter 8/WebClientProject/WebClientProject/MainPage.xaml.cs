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

namespace WebClientProject
{
    public partial class MainPage : PhoneApplicationPage
    {
        private WebClient wc = new WebClient();
        public MainPage()
        {
            InitializeComponent();
            FetchData.Click +=  FetchData_Click;
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadStringCompleted += wc_DownloadStringCompleted;
        }
        void FetchData_Click( object sender, RoutedEventArgs e )
        {
            wc.DownloadStringAsync( 
                new Uri( 
                    "http://feeds.feedburner.com/JesseLiberty-SilverlightGeek" ),
                    "rss" );
        }

        void wc_DownloadStringCompleted( 
            object sender, 
            DownloadStringCompletedEventArgs e )
        {
            if (e.UserState.ToString() == "rss")
            {
                Text.Text = e.Result;
            }

        }

        void wc_DownloadProgressChanged( 
            object sender, 
            DownloadProgressChangedEventArgs e )
        {
            if (e.UserState.ToString() == "rss")
            {
                Progress.Value = e.ProgressPercentage;
            }
        }

    }
}