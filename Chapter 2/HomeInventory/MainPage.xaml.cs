﻿using System;
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

namespace HomeInventory
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void CategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Categories.xaml", UriKind.Relative));
        }

		private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new Uri("/Photos.xaml", UriKind.Relative));
		}
    }
}