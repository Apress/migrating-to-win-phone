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
using Microsoft.Phone.Shell;

namespace HomeInventory
{
    public partial class Categories : PhoneApplicationPage
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ApplicationBarIconButton button = sender as ApplicationBarIconButton; 
            button.IconUri = new Uri("icons/appbar.delete.rest.png", UriKind.Relative);
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}