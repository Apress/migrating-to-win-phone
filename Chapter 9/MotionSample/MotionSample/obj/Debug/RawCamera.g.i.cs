﻿#pragma checksum "C:\Users\jblankenburg\Dropbox\Migrating to Windows Phone 7\Code For Chapters\Chapter 9\MotionSample\MotionSample\RawCamera.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3659467FA9D43ECA3E1BBFD518AAAE68"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace MotionSample {
    
    
    public partial class RawCamera : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image CameraCapture;
        
        internal System.Windows.Shapes.Rectangle VideoBox;
        
        internal System.Windows.Media.VideoBrush CameraSource;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton PhotoButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MotionSample;component/RawCamera.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.CameraCapture = ((System.Windows.Controls.Image)(this.FindName("CameraCapture")));
            this.VideoBox = ((System.Windows.Shapes.Rectangle)(this.FindName("VideoBox")));
            this.CameraSource = ((System.Windows.Media.VideoBrush)(this.FindName("CameraSource")));
            this.PhotoButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("PhotoButton")));
        }
    }
}
