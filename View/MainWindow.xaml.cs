using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var viewModel = new MainWindowViewModel();
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}