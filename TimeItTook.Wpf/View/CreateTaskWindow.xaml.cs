using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class CreateTaskWindow : Window
    {
        public CreateTaskWindow()
        {
            DataContext = new CreateTaskWindowViewModel();
            InitializeComponent();
        }
    }
}
