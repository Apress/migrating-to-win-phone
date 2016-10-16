using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;
using System;


namespace ScheduledTaskAgent1
{
    public class ScheduledAgent : ScheduledTaskAgent
    {
        /// <summary>
        /// Agent that runs a scheduled task
        /// </summary>
        /// <param name="task">
        /// The invoked task
        /// </param>
        /// <remarks>
        /// This method is called when a periodic or resource intensive task is invoked
        /// </remarks>
        protected override void OnInvoke( ScheduledTask task )
        {
            string toastMessage = string.Empty;
            if ((task is PeriodicTask))
                toastMessage = "periodic task running...";
            else
                toastMessage = "Resource-intensive task is running...";

            ShellToast toast = new ShellToast();
            toast.Title = "Background Agent";
            toast.Content = toastMessage;
            toast.Show();

#if DEBUG_AGENT
            ScheduledActionService.LaunchForTest(task.Name, TimeSpan.FromSeconds(60));
#endif

            NotifyComplete();
        }
    }
}
