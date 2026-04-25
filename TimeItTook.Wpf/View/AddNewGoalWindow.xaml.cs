using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class AddNewGoalWindow : Window
    {
        public AddNewGoalWindow(AddNewGoalWindowViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
