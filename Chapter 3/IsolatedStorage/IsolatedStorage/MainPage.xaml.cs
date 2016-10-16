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
using System.IO.IsolatedStorage;

namespace IsolatedStorage
{




    public partial class MainPage : PhoneApplicationPage
    {
        private IsolatedStorageSettings _isoSettings;


       public MainPage()
        {
            InitializeComponent();
            _isoSettings = IsolatedStorageSettings.ApplicationSettings;
            Save.Click += new RoutedEventHandler( Save_Click );
            KeysAndValues.SelectionChanged += new SelectionChangedEventHandler( KeysAndValues_SelectionChanged );
        }

       void KeysAndValues_SelectionChanged( 
           object sender, 
           SelectionChangedEventArgs e )
       {
           if (e.AddedItems.Count < 1)
               return;
           string selected = e.AddedItems[0].ToString();
           string key = selected.Substring(
              0, selected.IndexOf( ":" ) );
           Key.Text = key;
           Value.Text = _isoSettings[key].ToString();

       }

       void Save_Click( object sender, RoutedEventArgs e )
       {
           if (
               String.IsNullOrEmpty( Key.Text ) ||
                 String.IsNullOrEmpty( Value.Text ))
           {
               return;
           }

           if (_isoSettings.Contains( Key.Text ))
           {
               _isoSettings[Key.Text] = Value.Text;
           }
           else
           {
               _isoSettings.Add( Key.Text, Value.Text );
           }
           RebindListBox();

       }

       private void RebindListBox()
       {
           Value.Text = Key.Text = String.Empty;
           KeysAndValues.Items.Clear();
           foreach (string key in _isoSettings.Keys)
           {
               ListBoxItem lbi = new ListBoxItem();
               string newKey = key + ": " + _isoSettings[key];
               KeysAndValues.Items.Add( newKey );
           }
       }
    }
}
