using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Notification;
using System.Text;
using Microsoft.Phone.Shell;
using System.Linq;

namespace NotificationApp
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();

			HttpNotificationChannel pushChannel;
			string channelName = "myPushChannel";

			pushChannel = HttpNotificationChannel.Find(channelName);

			if (pushChannel == null)
			{
				pushChannel = new HttpNotificationChannel(channelName);
				pushChannel.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(pushChannel_ChannelUriUpdated);
				pushChannel.HttpNotificationReceived += new EventHandler<HttpNotificationEventArgs>(pushChannel_HttpNotificationReceived);
				pushChannel.Open();
				pushChannel.BindToShellToast();
				pushChannel.BindToShellTile();
			}
			else
			{
				pushChannel.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(pushChannel_ChannelUriUpdated);
			}
		}

		void pushChannel_HttpNotificationReceived(object sender, HttpNotificationEventArgs e)
		{
			string rawData;

			using (System.IO.StreamReader streamReader = new System.IO.StreamReader(e.Notification.Body))
			{
				rawData = streamReader.ReadToEnd();
			}
			
			Dispatcher.BeginInvoke(() =>
				MessageBox.Show(String.Format("New XML Data {0}:\n{1}",
					DateTime.Now.ToShortTimeString(), rawData))
					);

		}

		void pushChannel_ChannelUriUpdated(object sender, NotificationChannelUriEventArgs e)
		{
			Dispatcher.BeginInvoke(() =>
			{
				System.Diagnostics.Debug.WriteLine(e.ChannelUri.ToString());
			});
		}

		private void PrimaryButton_Click(object sender, RoutedEventArgs e)
		{

			ShellTile PrimaryTile = ShellTile.ActiveTiles.First();

			if (PrimaryTile != null)
			{
				StandardTileData TileUpdate = new StandardTileData
				{
					Title = "Yoda Tile",
					BackgroundImage = new Uri("", UriKind.Relative),
					Count = 1,
					BackTitle = "The Dark Side",
					BackBackgroundImage = new Uri("", UriKind.Relative),
					BackContent = "Beware, this side you should."
				};

				PrimaryTile.Update(TileUpdate);
			}
}

		private void SecondaryButton_Click(object sender, RoutedEventArgs e)
		{
			ShellTile SecondaryTile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("Tile=2"));

			if (SecondaryTile == null)
			{
				StandardTileData NewTile = new StandardTileData
				{
					BackgroundImage = new Uri("", UriKind.Relative),
					Title = "Cautionary Tile",
					Count = 42,
					BackTitle = "Baby Got Back",
					BackContent = "L.A. Face with an open data feed.",
					BackBackgroundImage = new Uri("", UriKind.Relative)
				};

				ShellTile.Create(new Uri("/AlternatePage.xaml?Tile=2", UriKind.Relative), NewTile);
			}

		}

		private void UpdateButton_Click(object sender, RoutedEventArgs e)
		{
			ShellTile UpdateTile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("Tile=2"));

			if (UpdateTile != null)
			{
				StandardTileData UpdateData = new StandardTileData
				{
					BackgroundImage = new Uri("", UriKind.Relative),
					Title = "Tile E. Coyote",
					Count = 8,
					BackTitle = "AC/DC",
					BackContent = "Back in Black",
					BackBackgroundImage = new Uri("", UriKind.Relative)
				};

				UpdateTile.Update(UpdateData);
			}
		}
	}
}