using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class AddNewDefaultTaskWindow : Window
    {
        public AddNewDefaultTaskWindow()
        {
            DataContext = new AddNewDefaultTaskWindowViewModel();
            InitializeComponent();
        }
    }
}
