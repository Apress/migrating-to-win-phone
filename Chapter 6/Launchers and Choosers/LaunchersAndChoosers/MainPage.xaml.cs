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
using Microsoft.Phone.Tasks;
using System.Device.Location;
using System.Windows.Media.Imaging;
using Microsoft.Phone.UserData;

namespace LaunchersAndChoosers
{
    public partial class MainPage : PhoneApplicationPage
    {
        AddressChooserTask act;
        CameraCaptureTask cct;
        EmailAddressChooserTask eact;
        GameInviteTask git;
        PhoneNumberChooserTask pnct;
        PhotoChooserTask pct;
        SaveEmailAddressTask seat;
        SavePhoneNumberTask spnt;
        SaveRingtoneTask srt;
        int appointmentSkipCount = 0;
        
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            act = new AddressChooserTask();
            act.Completed += new EventHandler<AddressResult>(act_Completed);

            cct = new CameraCaptureTask();
            cct.Completed += new EventHandler<PhotoResult>(cct_Completed);

            eact = new EmailAddressChooserTask();
            eact.Completed += new EventHandler<EmailResult>(eact_Completed);

            git = new GameInviteTask();
            git.Completed += new EventHandler<TaskEventArgs>(git_Completed);

            pct = new PhotoChooserTask();
            pct.Completed += new EventHandler<PhotoResult>(pct_Completed);

            pnct = new PhoneNumberChooserTask();
            pnct.Completed += new EventHandler<PhoneNumberResult>(pnct_Completed);

            seat = new SaveEmailAddressTask();
            seat.Completed += new EventHandler<TaskEventArgs>(seat_Completed);

            srt = new SaveRingtoneTask();
            srt.Completed += new EventHandler<TaskEventArgs>(srt_Completed);

            spnt = new SavePhoneNumberTask();
            spnt.Completed += new EventHandler<TaskEventArgs>(spnt_Completed);
        }

        private void SaveEmailAddress_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            seat.Email = "windowsphone@jeffblankenburg.com";
            seat.Show();
        }

        void seat_Completed(object sender, TaskEventArgs e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Save was successful!
            }
        }

        private void SavePhoneNumber_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            spnt.PhoneNumber = "(614) 327-5066";
            spnt.Show();
        }

        void spnt_Completed(object sender, TaskEventArgs e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Save was successful!
            }
        }

        void pct_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                string imagename = e.OriginalFileName;
                BitmapImage image = new BitmapImage();
                image.SetSource(e.ChosenPhoto);
                ImagePreview.Source = image;
                ImagePreview.Visibility = Visibility.Visible;
                var msgbox = MessageBox.Show(imagename, "Image Location", MessageBoxButton.OK);
            }
        }

        private void Photo_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pct.ShowCamera = true;
            pct.PixelWidth = 100;
            pct.PixelHeight = 100;
            pct.Show();
        }

        void pnct_Completed(object sender, PhoneNumberResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                var result = MessageBox.Show(e.PhoneNumber, e.DisplayName, MessageBoxButton.OK);
            }
        }

        private void PhoneNumber_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pnct.Show();
        }

        

        void srt_Completed(object sender, TaskEventArgs e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                var result = MessageBox.Show("Ringtone saved successfully.");
            }
        }

        void git_Completed(object sender, TaskEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void GameInvite_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            git.Show();
        }
        
        void eact_Completed(object sender, EmailResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                var msgbox = MessageBox.Show(e.Email, e.DisplayName, MessageBoxButton.OK);
            }
        }

        private void EmailAddress_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            eact.Show();
        }

        void cct_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                string imagename = e.OriginalFileName;
                BitmapImage image = new BitmapImage();
                image.SetSource(e.ChosenPhoto);
                ImagePreview.Source = image;
                ImagePreview.Visibility = Visibility.Visible;
                var msgbox = MessageBox.Show(imagename, "Image Location", MessageBoxButton.OK);
            }
        }

        private void CameraCapture_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            cct.Show();
        }

        void act_Completed(object sender, AddressResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                string address = e.Address;
                string name = e.DisplayName;
                var msgbox = MessageBox.Show(address, name, MessageBoxButton.OK);
            }
        }

        private void Address_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            act.Show();
        }

        private void Directions_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            BingMapsDirectionsTask bmdt = new BingMapsDirectionsTask();
            bmdt.Start = new LabeledMapLocation("8800 Lyra Ave, Columbus, OH  43240", new GeoCoordinate());
            bmdt.End = new LabeledMapLocation("Thurman's Cafe, Columbus, OH", new GeoCoordinate());
            bmdt.Show();            
        }

        private void Maps_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            BingMapsTask bmt = new BingMapsTask();
            bmt.Center = new GeoCoordinate(41.42322600, -81.920683);
            bmt.ZoomLevel = 20;
            bmt.Show();
        }

        private void Email_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            EmailComposeTask ect = new EmailComposeTask();
            ect.Subject = "This is a test message";
            ect.Body = "I am sending you a message from the Launchers and Choosers application.";
            ect.To = "windowsphone@jeffblankenburg.com";
            ect.Cc = "windowsphone@jesseliberty.com";
            ect.Bcc = "blindcopy@jeffblankenburg.com";
            ect.Show();
        }

        private void ShareStatus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //ShareStatusTask sst = new ShareStatusTask();
        }

        private void MarketplaceDetail_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MarketplaceDetailTask mdt = new MarketplaceDetailTask();
            mdt.ContentIdentifier = "f08521cd-1cff-df11-9264-00237de2db9e";
            mdt.Show();
        }

        private void MarketplaceHub_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MarketplaceHubTask mht = new MarketplaceHubTask();
            mht.ContentType = MarketplaceContentType.Applications;
            mht.Show();
        }

        private void MarketplaceReview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MarketplaceReviewTask mrt = new MarketplaceReviewTask();
            mrt.Show();
        }

        private void MarketplaceSearch_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MarketplaceSearchTask mst = new MarketplaceSearchTask();
            mst.ContentType = MarketplaceContentType.Music;
            mst.SearchTerms = "Code Monkey Coulton";
            mst.Show();
        }

        private void MediaPlayer_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MediaPlayerLauncher mpl = new MediaPlayerLauncher();
            mpl.Controls = MediaPlaybackControls.All;
            mpl.Location = MediaLocationType.Install;
            mpl.Media = new Uri("video/DramaticChipmunk.mp4", UriKind.Relative);
            mpl.Show();
        }

        private void PhoneCall_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PhoneCallTask pct = new PhoneCallTask();
            pct.DisplayName = "Rick Astley";
            pct.PhoneNumber = "(772) 257-4501";
            pct.Show();
        }

        private void WebBrowser_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WebBrowserTask wbt = new WebBrowserTask();
            wbt.Uri = new Uri("http://jeffblankenburg.com");
            wbt.Show();
        }

        private void Search_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SearchTask st = new SearchTask();
            st.SearchQuery = "31 Days of Windows Phone";
            st.Show();
        }

        private void SmsCompose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SmsComposeTask sct = new SmsComposeTask();
            sct.To = "40404";
            sct.Body = "Sign me up for Twitter!";
            sct.Show();
        }

        private void ShareLink_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //ShareLinkTask
        }

        private void ImagePreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ImagePreview.Visibility = Visibility.Collapsed;
        }

        private void SaveContact_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void SaveRingtone_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //srt.DisplayName = "Scotch";
            //srt.IsShareable = true;
            //srt.IsoStorePath = new Uri("audio/Scotch.mp3", UriKind.Relative);
            //srt.Show();
        }

        void c_SearchCompleted(object sender, ContactsSearchEventArgs e)
        {
            Contact c = e.Results.FirstOrDefault();
            if (c.DisplayName != null)
                contactName.Text = c.DisplayName;

            if (c.EmailAddresses.FirstOrDefault() != null)
            {
                contactEmail.Text = c.EmailAddresses.FirstOrDefault().EmailAddress;
                emailCanvas.Visibility = Visibility.Visible;
            }
            else emailCanvas.Visibility = Visibility.Collapsed;

            if (c.PhoneNumbers.FirstOrDefault() != null)
            {
                contactPhone.Text = c.PhoneNumbers.FirstOrDefault().PhoneNumber;
                phoneCanvas.Visibility = Visibility.Visible;
            }
            else phoneCanvas.Visibility = Visibility.Collapsed;

            if (c.Addresses.FirstOrDefault() != null)
            {
                contactAddress.Text = c.Addresses.FirstOrDefault().PhysicalAddress.AddressLine1 + "\n" + c.Addresses.FirstOrDefault().PhysicalAddress.City + ", " + c.Addresses.FirstOrDefault().PhysicalAddress.StateProvince + "  " + c.Addresses.FirstOrDefault().PhysicalAddress.PostalCode;
                addressCanvas.Visibility = Visibility.Visible;
            }
            else phoneCanvas.Visibility = Visibility.Collapsed;
            
            contactPanel.Visibility = Visibility.Visible;
        }

        private void Contacts_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            EmailAddressChooserTask emailAddressChooserTask = new EmailAddressChooserTask();
            emailAddressChooserTask.Completed += new EventHandler<EmailResult>(emailAddressChooserTask_Completed);
            emailAddressChooserTask.Show();            
        }

        void emailAddressChooserTask_Completed(object sender, EmailResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                Contacts c = new Contacts();
                c.SearchCompleted += new EventHandler<ContactsSearchEventArgs>(c_SearchCompleted);
                c.SearchAsync(e.DisplayName, FilterKind.DisplayName, null);
            }
        }

        private void UserDataItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            
        }

        private void contactPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            contactPanel.Visibility = Visibility.Collapsed;
        }

        private void Appointments_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            getAppointments();
        }

        private void getAppointments()
        {
            Appointments a = new Appointments();
            a.SearchCompleted += new EventHandler<AppointmentsSearchEventArgs>(a_SearchCompleted);
            a.SearchAsync(DateTime.Now, DateTime.Now.AddDays(7), null);
        }

        void a_SearchCompleted(object sender, AppointmentsSearchEventArgs e)
        {
            Appointment a = e.Results.Skip(appointmentSkipCount).FirstOrDefault();
            appointmentStartDate.Text = a.StartTime.ToLongDateString();
            appointmentStartTime.Text = a.StartTime.ToShortTimeString();
            appointmentSubject.Text = a.Subject;
            appointmentDetails.Text = a.Details;
            appointmentPanel.Visibility = Visibility.Visible;
        }

        private void UserDataPhone_MouseLeftButtonup(object sender, MouseButtonEventArgs e)
        {
            PhoneCallTask p = new PhoneCallTask();
            p.DisplayName = contactName.Text;
            p.PhoneNumber = contactPhone.Text;
            p.Show();
        }

        private void UserDataEmail_MouseLeftButtonup(object sender, MouseButtonEventArgs e)
        {
            EmailComposeTask ec = new EmailComposeTask();
            ec.To = contactEmail.Text;
            ec.Show();
        }

        private void appointmentPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            appointmentPanel.Visibility = Visibility.Collapsed;
        }

        private void nextAppointment_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            appointmentSkipCount++;
            getAppointments();
        }

        private void prevAppointment_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            appointmentSkipCount--;
            if (appointmentSkipCount < 0)
                appointmentSkipCount = 0;
            getAppointments();
        }
    }
}