using System;
using System.Windows;
using System.Windows.Threading;

namespace Task3
{
    internal class Presenter
    {
        private readonly Model model;
        private readonly MainWindow viewe;
        public event EventHandler Result = null;


        public void Reset(object sender, RoutedEventArgs e) { model.Stopwatch.Reset(); }

        public void Start(object sender, RoutedEventArgs e)
        {
            model.Stopwatch.Start();
            viewe.ContentRendered += UpDate;

            //todo: run update
        }

        public void Stop(object sender, RoutedEventArgs e)
        {
            model.Stopwatch.Stop();
            //todo: stop update
        }

        private void UpDate(object sender, EventArgs e)
        {
            viewe.Result.Text = model.GetTime();
        }
        public Presenter(MainWindow viewe)
        {
            this.viewe = viewe;
            this.model = new Model();
        }
    }
}