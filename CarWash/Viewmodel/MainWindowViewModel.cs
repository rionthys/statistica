using System;
using System.Windows;
using System.Windows.Threading;

namespace CarWash.Viewmodel
{
    class MainWindowViewModel : BaseViewModel
    {
        private string time;

        public MainWindowViewModel()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timertick;
            timer.Start();
        }
        public string Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged(nameof(time));
            }
        }
        void Timertick(object sender, EventArgs e)
        {
            Time = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}