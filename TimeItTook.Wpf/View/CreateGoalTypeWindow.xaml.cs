using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class CreateGoalTypeWindow : Window
    {
        public CreateGoalTypeWindow()
        {
            DataContext = new CreateGoalTypeWindowViewModel();
            InitializeComponent();
        }
    }
}
