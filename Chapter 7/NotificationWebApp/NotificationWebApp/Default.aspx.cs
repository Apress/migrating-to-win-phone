using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.IO;

namespace NotificationWebApp
{
	public partial class Default : System.Web.UI.Page
	{
		string channelURI = "http://sn1.notify.live.net/throttledthirdparty/01.00/AAHQUKuwpAE3TJJZovqOE4ykAgAAAAADAQAAAAQUZm52OjIzOEQ2NDJDRkI5MEVFMEQ";

		
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ToastButton_Click(object sender, EventArgs e)
		{
			
			HttpWebRequest notification = (HttpWebRequest)WebRequest.Create(channelURI);
			notification.Method = "POST";

			string toast = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
			"<wp:Notification xmlns:wp=\"WPNotification\">" +
				"<wp:Toast>" +
					"<wp:Text1>Houston...</wp:Text1>" +
					"<wp:Text2>The eagle has landed.</wp:Text2>" +
				"</wp:Toast> " +
			"</wp:Notification>";

			byte[] notificationByteArray = Encoding.Default.GetBytes(toast);

			notification.ContentLength = notificationByteArray.Length;
			notification.ContentType = "text/xml";
			notification.Headers.Add("X-WindowsPhone-Target", "toast");
			notification.Headers.Add("X-NotificationClass", "2");
			notification.Headers.Add("X-MessageID", "b1711c5a-a6c1-4998-b160-c24ffd79ddc1");


			using (Stream requestStream = notification.GetRequestStream())
			{
				requestStream.Write(notificationByteArray, 0, notificationByteArray.Length);
			}

			HttpWebResponse response = (HttpWebResponse)notification.GetResponse();
			string notificationStatus = response.Headers["X-NotificationStatus"];
			string subscriptionStatus = response.Headers["X-SubscriptionStatus"];
			string deviceConnectionStatus = response.Headers["X-DeviceConnectionStatus"];
			string messageID = response.Headers["X-MessageID"];

			System.Diagnostics.Debug.WriteLine("NOTIFICATION STATUS:" + notificationStatus);
			System.Diagnostics.Debug.WriteLine("DEVICE CONNECTION STATUS:" + deviceConnectionStatus);
			System.Diagnostics.Debug.WriteLine("SUBSCRIPTION STATUS:" + subscriptionStatus);
			System.Diagnostics.Debug.WriteLine("MESSAGE ID:" + messageID);
		}

		protected void TileButton_Click(object sender, EventArgs e)
		{
			HttpWebRequest notification = (HttpWebRequest)WebRequest.Create(channelURI);
			notification.Method = "POST";

			string tile = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
			"<wp:Notification xmlns:wp=\"WPNotification\">" +
				"<wp:Tile>" +
					"<wp:BackgroundImage></wp:BackgroundImage>" +
					"<wp:Count>123</wp:Count>" +
					"<wp:Title>Notify!</wp:Title>" +
					"<wp:BackBackgroundImage></wp:BackBackgroundImage>" +
					"<wp:BackTitle>!Yfiton</wp:BackTitle>" +
					"<wp:BackContent>Back that tile up.</wp:BackContent>" +
				"</wp:Tile> " +
			"</wp:Notification>";

			byte[] notificationByteArray = Encoding.Default.GetBytes(tile);

			notification.ContentLength = notificationByteArray.Length;
			notification.ContentType = "text/xml";
			notification.Headers.Add("X-WindowsPhone-Target", "token");
			notification.Headers.Add("X-NotificationClass", "1");


			using (Stream requestStream = notification.GetRequestStream())
			{
				requestStream.Write(notificationByteArray, 0, notificationByteArray.Length);
			}

			HttpWebResponse response = (HttpWebResponse)notification.GetResponse();
			string notificationStatus = response.Headers["X-NotificationStatus"];
			string subscriptionStatus = response.Headers["X-SubscriptionStatus"];
			string deviceConnectionStatus = response.Headers["X-DeviceConnectionStatus"];
			string messageID = response.Headers["X-MessageID"];

			System.Diagnostics.Debug.WriteLine("NOTIFICATION STATUS:" + notificationStatus);
			System.Diagnostics.Debug.WriteLine("DEVICE CONNECTION STATUS:" + deviceConnectionStatus);
			System.Diagnostics.Debug.WriteLine("SUBSCRIPTION STATUS:" + subscriptionStatus);
			System.Diagnostics.Debug.WriteLine("MESSAGE ID:" + messageID);
		}

		protected void RawButton_Click(object sender, EventArgs e)
		{
			HttpWebRequest notification = (HttpWebRequest)WebRequest.Create(channelURI);
			notification.Method = "POST";

			string raw = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
			"<root>" +
				"<FirstName>Jeff</FirstName>" +
				"<LastName>Blankenburg</LastName>" +
			"</root>";

			byte[] notificationByteArray = Encoding.Default.GetBytes(raw);

			notification.ContentLength = notificationByteArray.Length;
			notification.ContentType = "text/xml";
			notification.Headers.Add("X-NotificationClass", "3");
			notification.Headers.Add("X-MessageID", "b1711c5a-a6c1-4998-b160-c24ffd79ddc1");


			using (Stream requestStream = notification.GetRequestStream())
			{
				requestStream.Write(notificationByteArray, 0, notificationByteArray.Length);
			}

			HttpWebResponse response = (HttpWebResponse)notification.GetResponse();
			string notificationStatus = response.Headers["X-NotificationStatus"];
			string subscriptionStatus = response.Headers["X-SubscriptionStatus"];
			string deviceConnectionStatus = response.Headers["X-DeviceConnectionStatus"];
			string messageID = response.Headers["X-MessageID"];

			System.Diagnostics.Debug.WriteLine("NOTIFICATION STATUS:" + notificationStatus);
			System.Diagnostics.Debug.WriteLine("DEVICE CONNECTION STATUS:" + deviceConnectionStatus);
			System.Diagnostics.Debug.WriteLine("SUBSCRIPTION STATUS:" + subscriptionStatus);
			System.Diagnostics.Debug.WriteLine("MESSAGE ID:" + messageID);
		}
	}
}