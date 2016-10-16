using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace GetMoving
{
    public partial class PageOne : PhoneApplicationPage
    {
		public PageOne()
        {
            InitializeComponent();
        }

		protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);
			FlipOut.Completed += new EventHandler(FlipOut_Completed);
			FlipIn.Begin();
		}

        void FlipOut_Completed(object sender, EventArgs e)
        {
			NavigationService.Navigate(new Uri("/PageTwo.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
			FlipOut.Begin();
        }
    }
}