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
using System.Threading;

namespace GetMoving
{
	public partial class MainPage : PhoneApplicationPage
	{
        string[] textCollection = new string[5] {"First, we need some text.", "Second, we need to make sure it fades away.", "Third, we should rotate the array value.", "Fourth, we should write the string to the screen.", "Fifth, we should do it all over again."};
        int textCounter = 0;
        
        // Constructor
		public MainPage()
		{
			InitializeComponent();
            PageFlip.Begin();
			FadeOut.Completed += new EventHandler(FadeOut_Completed);
			FadeIn.Completed += new EventHandler(FadeIn_Completed);
			this.Loaded += new RoutedEventHandler(MainPage_Loaded);
		}

		void MainPage_Loaded(object sender, RoutedEventArgs e)
		{
			//StartRotation();
		}

		private void StartRotation()
		{
			FadeOut.Begin();
		}

		void FadeIn_Completed(object sender, EventArgs e)
		{
	        if (TextPause())
			{		
                StartRotation();
            }
		}

		private bool TextPause()
		{
			Thread.Sleep(4000);
			return true;
		}

		void FadeOut_Completed(object sender, EventArgs e)
		{
			ChangeText();
		}

		private void ChangeText()
		{
            if (textCounter == 5) textCounter = 0;
            TextRotator.Text = textCollection[textCounter];
            textCounter++;
			FadeIn.Begin();
		}

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SimpleAnimation.xaml", UriKind.Relative));
        }
	}
}