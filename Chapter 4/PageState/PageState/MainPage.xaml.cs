using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace PageState
{
    public partial class MainPage : PhoneApplicationPage
    {
        private bool _newPage;
        public MainPage()
        {
            InitializeComponent();
            _newPage = true;
            GoToPage2.Click += new RoutedEventHandler( GoToPage2_Click );
        }

        void GoToPage2_Click( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(
                new Uri( "/Page2.xaml", UriKind.Relative ) );
        }

        protected override void OnNavigatedFrom(
            System.Windows.Navigation.NavigationEventArgs e )
        {
            base.OnNavigatedFrom( e );

            if ((e.NavigationMode !=
                System.Windows.Navigation.NavigationMode.Back))
            {
                State["PageData"] = PageData.Text;
            }

        }

        protected override void OnNavigatedTo(
                System.Windows.Navigation.NavigationEventArgs e )
        {
            base.OnNavigatedTo( e );
            if (_newPage)
            {
                if (String.IsNullOrEmpty( PageData.Text ))
                {
                    if (State.Count > 0)
                        PageData.Text = State["PageData"].ToString();
                }
            }
            _newPage = false;
        }


    }
}