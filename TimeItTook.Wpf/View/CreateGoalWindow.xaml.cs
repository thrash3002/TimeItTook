using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class CreateGoalWindow : Window
    {
        public CreateGoalWindow()
        {
            DataContext = new CreateGoalWindowViewModel();
            InitializeComponent();
        }
    }
}
