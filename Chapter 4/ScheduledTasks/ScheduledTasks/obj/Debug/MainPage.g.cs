﻿#pragma checksum "C:\Users\Jesse\Documents\My Dropbox\Migrating\Code For Chapters\Chapter 4\ScheduledTasks\ScheduledTasks\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "080CB2FD4F26C7EA1A59D597D8902D87"
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


namespace ScheduledTasks {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel PeriodicStackPanel;
        
        internal System.Windows.Controls.CheckBox PeriodicCheckBox;
        
        internal System.Windows.Controls.StackPanel ResourceIntensiveStackPanel;
        
        internal System.Windows.Controls.CheckBox ResourceIntensiveCheckBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ScheduledTasks;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PeriodicStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("PeriodicStackPanel")));
            this.PeriodicCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("PeriodicCheckBox")));
            this.ResourceIntensiveStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ResourceIntensiveStackPanel")));
            this.ResourceIntensiveCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("ResourceIntensiveCheckBox")));
        }
    }
}

