using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class CreateProjectTypeWindow : Window
    {
        public CreateProjectTypeWindow()
        {
            DataContext = new CreateProjectTypeWindowViewModel();
            InitializeComponent();
        }
    }
}
