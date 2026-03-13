using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class AddNewTaskWindow : Window
    {
        public AddNewTaskWindow()
        {
            DataContext = new AddNewTaskWindowViewModel();
            InitializeComponent();
        }
    }
}
