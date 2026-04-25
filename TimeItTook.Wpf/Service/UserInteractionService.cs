using TimeItTook.Core.Service;
using TimeItTook.Core.Util;
using TimeItTook.View;
using TimeItTook.ViewModel;
using TimeItTook.Wpf.View;

namespace TimeItTook.Wpf.Service
{
    public class UserInteractionService : IUserInteractionService
    {
        private readonly IAbstractFactory<AddNewTaskWindow> addNewTaskWindowFactory;
        private readonly IAbstractFactory<AddNewGoalWindow> addNewGoalWindowFactory;

        public UserInteractionService(
            IAbstractFactory<AddNewTaskWindow> addNewTaskWindowFactory,
            IAbstractFactory<AddNewGoalWindow> addNewGoalWindowFactory)
        {
            this.addNewTaskWindowFactory = addNewTaskWindowFactory;
            this.addNewGoalWindowFactory = addNewGoalWindowFactory;
        }
        public void RequestInteraction(object viewModel)
        {
            switch (viewModel)
            {
                case AddNewTaskWindowViewModel _:
                    var newTaskWindow = addNewTaskWindowFactory.Create();
                    newTaskWindow.ShowDialog();
                    break;
                case AddNewGoalWindowViewModel _:
                    var newGoalWindow = addNewGoalWindowFactory.Create();
                    newGoalWindow.ShowDialog();
                    break;
            }
        }
    }
}
