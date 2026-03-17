using System.Windows;
//using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class MainWindow : Window
    {
        private int count = 0;

        public MainWindow()
        {
            //var viewModel = new MainWindowViewModel();
            //DataContext = viewModel;
            InitializeComponent();
        }

        private void ButtonIncrement_Click(object sender, RoutedEventArgs e)
        {
            count++;
            TextBoxOutput.Text = count.ToString();
        }

        private void ButtonDecrement_Click(object sender, RoutedEventArgs e)
        {
            count--;
            TextBoxOutput.Text = count.ToString();
        }
    }
}