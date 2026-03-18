using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}