using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace YourLibraryName
{
    public partial class SchedulerService : ServiceBase
    {
        private Timer timer;

        public SchedulerService()
        {
           // InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1 * 60 * 1000; // 5 minutes in milliseconds
            timer.Elapsed += TimerElapsed;

            // Start the timer
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // This method will be called every 5 minutes
            // Add your code to run automatically here

            // For example, let's write to the event log
            EventLog.WriteEntry("SchedulerService", "Scheduler service triggered!");
        }

        protected override void OnStop()
        {
            // Stop the timer
            timer?.Stop();
        }
    }
}
