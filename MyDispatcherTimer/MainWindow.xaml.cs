using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MyDispatcherTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer scheduler;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the scheduler
            scheduler = new DispatcherTimer();
            scheduler.Interval = TimeSpan.FromSeconds(10);
            scheduler.Tick += Scheduler_Tick;

            // Start the scheduler
            scheduler.Start();
        }

        private void Scheduler_Tick(object sender, EventArgs e)
        {
            // This method will be called every 5 minutes
            // Add your code to run automatically here

            // For example, let's show a message box

            Task.Run(() =>
            {
                // MessageBox.Show("Scheduler triggered!");
                string s = "";
                for (int i = 0; i < 50; i++)
                {
                    s += i.ToString();
                }

                Dispatcher.Invoke(() =>
                {
                    button.Content = ((int.Parse(button.Content.ToString())) + 1).ToString();
                });

            });
        }

        private void f1_Click(object sender, RoutedEventArgs e)
        {
            var f = new Form1();
            f.Show();
         }

        private void f2_Click(object sender, RoutedEventArgs e)
        {
            var f = new Form1();
            f.Show();
        }
    }
}
