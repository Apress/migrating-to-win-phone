﻿#pragma checksum "C:\Users\Jesse\Documents\My Dropbox\Migrating\Code For Chapters\Chapter 6\Launchers and Choosers\LaunchersAndChoosers\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "728461795543A8A05C814D33C76A2691"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace LaunchersAndChoosers {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.Pivot MainPivot;
        
        internal System.Windows.Controls.Canvas Directions;
        
        internal System.Windows.Controls.Canvas Maps;
        
        internal System.Windows.Controls.Canvas Email;
        
        internal System.Windows.Controls.Canvas MarketplaceDetail;
        
        internal System.Windows.Controls.Canvas MarketplaceHub;
        
        internal System.Windows.Controls.Canvas MarketplaceReview;
        
        internal System.Windows.Controls.Canvas MarketplaceSearch;
        
        internal System.Windows.Controls.Canvas MediaPlayer;
        
        internal System.Windows.Controls.Canvas PhoneCall;
        
        internal System.Windows.Controls.Canvas Search;
        
        internal System.Windows.Controls.Canvas SmsCompose;
        
        internal System.Windows.Controls.Canvas ShareLink;
        
        internal System.Windows.Controls.Canvas ShareStatus;
        
        internal System.Windows.Controls.Canvas WebBrowser;
        
        internal System.Windows.Controls.Canvas Address;
        
        internal System.Windows.Controls.Canvas CameraCapture;
        
        internal System.Windows.Controls.Canvas EmailAddress;
        
        internal System.Windows.Controls.Canvas GameInvite;
        
        internal System.Windows.Controls.Canvas PhoneNumber;
        
        internal System.Windows.Controls.Canvas Photo;
        
        internal System.Windows.Controls.Canvas SaveContact;
        
        internal System.Windows.Controls.Canvas SaveEmailAddress;
        
        internal System.Windows.Controls.Canvas SavePhoneNumber;
        
        internal System.Windows.Controls.Canvas SaveRingtone;
        
        internal System.Windows.Controls.Image ImagePreview;
        
        internal System.Windows.Controls.Canvas Contacts;
        
        internal System.Windows.Controls.Canvas Appointments;
        
        internal System.Windows.Controls.StackPanel contactPanel;
        
        internal System.Windows.Controls.TextBlock contactName;
        
        internal System.Windows.Controls.Canvas phoneCanvas;
        
        internal System.Windows.Controls.TextBlock contactPhone;
        
        internal System.Windows.Controls.Canvas emailCanvas;
        
        internal System.Windows.Controls.TextBlock contactEmail;
        
        internal System.Windows.Controls.Canvas addressCanvas;
        
        internal System.Windows.Controls.TextBlock contactAddress;
        
        internal System.Windows.Controls.Canvas appointmentPanel;
        
        internal System.Windows.Controls.TextBlock appointmentSubject;
        
        internal System.Windows.Controls.TextBlock appointmentStartDate;
        
        internal System.Windows.Controls.TextBlock appointmentStartTime;
        
        internal System.Windows.Controls.TextBlock appointmentDetails;
        
        internal System.Windows.Controls.Image nextAppointment;
        
        internal System.Windows.Controls.Image prevAppointment;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/LaunchersAndChoosers;component/MainPage.xaml", System.UriKind.Relative));
            this.MainPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("MainPivot")));
            this.Directions = ((System.Windows.Controls.Canvas)(this.FindName("Directions")));
            this.Maps = ((System.Windows.Controls.Canvas)(this.FindName("Maps")));
            this.Email = ((System.Windows.Controls.Canvas)(this.FindName("Email")));
            this.MarketplaceDetail = ((System.Windows.Controls.Canvas)(this.FindName("MarketplaceDetail")));
            this.MarketplaceHub = ((System.Windows.Controls.Canvas)(this.FindName("MarketplaceHub")));
            this.MarketplaceReview = ((System.Windows.Controls.Canvas)(this.FindName("MarketplaceReview")));
            this.MarketplaceSearch = ((System.Windows.Controls.Canvas)(this.FindName("MarketplaceSearch")));
            this.MediaPlayer = ((System.Windows.Controls.Canvas)(this.FindName("MediaPlayer")));
            this.PhoneCall = ((System.Windows.Controls.Canvas)(this.FindName("PhoneCall")));
            this.Search = ((System.Windows.Controls.Canvas)(this.FindName("Search")));
            this.SmsCompose = ((System.Windows.Controls.Canvas)(this.FindName("SmsCompose")));
            this.ShareLink = ((System.Windows.Controls.Canvas)(this.FindName("ShareLink")));
            this.ShareStatus = ((System.Windows.Controls.Canvas)(this.FindName("ShareStatus")));
            this.WebBrowser = ((System.Windows.Controls.Canvas)(this.FindName("WebBrowser")));
            this.Address = ((System.Windows.Controls.Canvas)(this.FindName("Address")));
            this.CameraCapture = ((System.Windows.Controls.Canvas)(this.FindName("CameraCapture")));
            this.EmailAddress = ((System.Windows.Controls.Canvas)(this.FindName("EmailAddress")));
            this.GameInvite = ((System.Windows.Controls.Canvas)(this.FindName("GameInvite")));
            this.PhoneNumber = ((System.Windows.Controls.Canvas)(this.FindName("PhoneNumber")));
            this.Photo = ((System.Windows.Controls.Canvas)(this.FindName("Photo")));
            this.SaveContact = ((System.Windows.Controls.Canvas)(this.FindName("SaveContact")));
            this.SaveEmailAddress = ((System.Windows.Controls.Canvas)(this.FindName("SaveEmailAddress")));
            this.SavePhoneNumber = ((System.Windows.Controls.Canvas)(this.FindName("SavePhoneNumber")));
            this.SaveRingtone = ((System.Windows.Controls.Canvas)(this.FindName("SaveRingtone")));
            this.ImagePreview = ((System.Windows.Controls.Image)(this.FindName("ImagePreview")));
            this.Contacts = ((System.Windows.Controls.Canvas)(this.FindName("Contacts")));
            this.Appointments = ((System.Windows.Controls.Canvas)(this.FindName("Appointments")));
            this.contactPanel = ((System.Windows.Controls.StackPanel)(this.FindName("contactPanel")));
            this.contactName = ((System.Windows.Controls.TextBlock)(this.FindName("contactName")));
            this.phoneCanvas = ((System.Windows.Controls.Canvas)(this.FindName("phoneCanvas")));
            this.contactPhone = ((System.Windows.Controls.TextBlock)(this.FindName("contactPhone")));
            this.emailCanvas = ((System.Windows.Controls.Canvas)(this.FindName("emailCanvas")));
            this.contactEmail = ((System.Windows.Controls.TextBlock)(this.FindName("contactEmail")));
            this.addressCanvas = ((System.Windows.Controls.Canvas)(this.FindName("addressCanvas")));
            this.contactAddress = ((System.Windows.Controls.TextBlock)(this.FindName("contactAddress")));
            this.appointmentPanel = ((System.Windows.Controls.Canvas)(this.FindName("appointmentPanel")));
            this.appointmentSubject = ((System.Windows.Controls.TextBlock)(this.FindName("appointmentSubject")));
            this.appointmentStartDate = ((System.Windows.Controls.TextBlock)(this.FindName("appointmentStartDate")));
            this.appointmentStartTime = ((System.Windows.Controls.TextBlock)(this.FindName("appointmentStartTime")));
            this.appointmentDetails = ((System.Windows.Controls.TextBlock)(this.FindName("appointmentDetails")));
            this.nextAppointment = ((System.Windows.Controls.Image)(this.FindName("nextAppointment")));
            this.prevAppointment = ((System.Windows.Controls.Image)(this.FindName("prevAppointment")));
        }
    }
}

