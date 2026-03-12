using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class CreateDefaultTaskWindow : Window
    {
        public CreateDefaultTaskWindow()
        {
            DataContext = new CreateDefaultTaskWindowViewModel();
            InitializeComponent();
        }
    }
}
