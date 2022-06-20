using System.Windows;

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Presenter myPresenter;

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Sum(sender, e);
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Sub(sender, e);
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Mul(sender, e);
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Div(sender, e);
        }

        public MainWindow()
        {
            InitializeComponent();
            myPresenter = new Presenter(this);

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            myPresenter.Res(sender, e);
        }
    }
}
