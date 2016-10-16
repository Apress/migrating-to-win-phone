#define DEBUG_AGENT


using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Scheduler;

namespace ScheduledTasks
{

    public partial class MainPage : PhoneApplicationPage
    {
        private PeriodicTask periodicTask;
        private ResourceIntensiveTask resourceIntensiveTask;

        private string periodicTaskName = "PeriodicAgent";
        private string resourceIntensiveTaskName = "ResourceIntensiveAgent";
        private bool ignoreCheckBoxEvents = false;


        
        public MainPage()
        {
            InitializeComponent();
        }

        private void StartPeriodicAgent()
        {
            periodicTask = ScheduledActionService.Find( periodicTaskName ) as PeriodicTask;

            // If the task already exists and the IsEnabled property is false, background
            // agents have been disabled by the user
            if (periodicTask != null && !periodicTask.IsEnabled)
            {
                MessageBox.Show( "Background agents for this application have been disabled by the user." );
                return;
            }

            // If the task already exists and background agents are enabled for the
            // application, you must remove the task and then add it again to update 
            // the schedule
            if (periodicTask != null && periodicTask.IsEnabled)
            {
                RemoveAgent( periodicTaskName );
            }

            periodicTask = new PeriodicTask( periodicTaskName );

            // The description is required for periodic agents. This is the string that the user
            // will see in the background services Settings page on the device.
            periodicTask.Description = "This demonstrates a periodic task.";
            ScheduledActionService.Add( periodicTask );

            PeriodicStackPanel.DataContext = periodicTask;

            // If debugging is enabled, use LaunchForTest to launch the agent in one minute.
#if(DEBUG_AGENT)
  ScheduledActionService.LaunchForTest(periodicTaskName, TimeSpan.FromSeconds(60));
#endif
        }


        private void StartResourceIntensiveAgent()
        {
            resourceIntensiveTask = ScheduledActionService.Find( resourceIntensiveTaskName ) as ResourceIntensiveTask;

            // If the task already exists and the IsEnabled property is false, background
            // agents have been disabled by the user
            if (resourceIntensiveTask != null && !resourceIntensiveTask.IsEnabled)
            {
                MessageBox.Show( "Background agents for this application have been disabled by the user." );
                return;
            }

            // If the task already exists and background agents are enabled for the
            // application, you must remove the task and then add it again to update 
            // the schedule
            if (resourceIntensiveTask != null && resourceIntensiveTask.IsEnabled)
            {
                RemoveAgent( resourceIntensiveTaskName );
            }

            resourceIntensiveTask = new ResourceIntensiveTask( resourceIntensiveTaskName );
            // The description is required for periodic agents. This is the string that the user
            // will see in the background services Settings page on the device.

            resourceIntensiveTask.Description = "This demonstrates a resource-intensive task.";
            ScheduledActionService.Add( resourceIntensiveTask );

            ResourceIntensiveStackPanel.DataContext = resourceIntensiveTask;

            // If debugging is enabled, use LaunchForTest to launch the agent in one minute.
#if(DEBUG_AGENT)
            ScheduledActionService.LaunchForTest( resourceIntensiveTaskName, TimeSpan.FromSeconds( 60 ) );
#endif
        }


        private void PeriodicCheckBox_Checked( object sender, RoutedEventArgs e )
        {
            if (ignoreCheckBoxEvents)
                return;
            StartPeriodicAgent();
        }
        private void PeriodicCheckBox_Unchecked( object sender, RoutedEventArgs e )
        {
            if (ignoreCheckBoxEvents)
                return;
            RemoveAgent( periodicTaskName );
        }
        private void ResourceIntensiveCheckBox_Checked( object sender, RoutedEventArgs e )
        {
            if (ignoreCheckBoxEvents)
                return;
            StartResourceIntensiveAgent();
        }
        private void ResourceIntensiveCheckBox_Unchecked( object sender, RoutedEventArgs e )
        {
            if (ignoreCheckBoxEvents)
                return;
            RemoveAgent( resourceIntensiveTaskName );
        }
        private void RemoveAgent( string name )
        {
            try
            {
                ScheduledActionService.Remove( name );
            }
            catch (Exception)
            {
            }
        }
        protected override void OnNavigatedTo( System.Windows.Navigation.NavigationEventArgs e )
        {
            ignoreCheckBoxEvents = true;

            periodicTask = ScheduledActionService.Find( periodicTaskName ) as PeriodicTask;

            if (periodicTask != null)
            {
                PeriodicStackPanel.DataContext = periodicTask;
            }

            resourceIntensiveTask = ScheduledActionService.Find( resourceIntensiveTaskName ) as ResourceIntensiveTask;
            if (resourceIntensiveTask != null)
            {
                ResourceIntensiveStackPanel.DataContext = resourceIntensiveTask;
            }

            ignoreCheckBoxEvents = false;

        }


    }
}