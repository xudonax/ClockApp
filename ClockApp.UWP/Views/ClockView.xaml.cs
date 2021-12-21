using System;
using Windows.UI.Xaml.Controls;

namespace ClockApp.UWP.Views
{
    public sealed partial class ClockView : Page
    {
        public ClockView()
        {
            this.InitializeComponent();

            var updateTimer = new System.Timers.Timer(5 * 1000);
            updateTimer.Elapsed += UpdateTextBlocksWithCurrentTime;
            updateTimer.Start();

            UpdateTextBlocksWithCurrentTime(null, null);
        }

        private async void UpdateTextBlocksWithCurrentTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            await Dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal,
                () => {
                    var now = DateTime.Now;

                    TimeTextBlock.Text = now.ToShortTimeString();
                    DateTextBlock.Text = now.ToShortDateString();
                });
        }
    }
}
