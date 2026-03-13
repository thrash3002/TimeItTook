using System.Windows;
using TimeItTook.ViewModel;

namespace TimeItTook.View
{
    public partial class AddNewGoalTypeWindow : Window
    {
        public AddNewGoalTypeWindow()
        {
            DataContext = new AddNewGoalTypeWindowViewModel();
            InitializeComponent();
        }
    }
}
