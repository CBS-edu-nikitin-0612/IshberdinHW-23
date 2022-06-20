using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;
using Task3;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Presenter myPresenter;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Start(sender, e);
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Stop(sender, e);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Reset(sender, e);
        }
        public MainWindow()
        {
            InitializeComponent();
            myPresenter = new Presenter(this);
        }
    }
}