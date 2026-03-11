using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class CreateProjectWindow : Window
    {
        public CreateProjectWindow()
        {
            DataContext = new CreateProjectWindowViewModel();
            InitializeComponent();
        }
    }
}
