using TimeItTook.Core.Service;
using TimeItTook.Core.Util;
using TimeItTook.View;
using TimeItTook.ViewModel;

namespace TimeItTook.Wpf.Service
{
    public class UserInteractionService : IUserInteractionService
    {
        private readonly IAbstractFactory<AddNewTaskWindow> addNewTaskWindowFactory;

        public UserInteractionService(
            IAbstractFactory<AddNewTaskWindow> addNewTaskWindowFactory)
        {
            this.addNewTaskWindowFactory = addNewTaskWindowFactory;
        }
        public void RequestInteraction(object viewModel)
        {
            switch (viewModel)
            {
                case AddNewTaskWindowViewModel _:
                    var newTaskWindow = addNewTaskWindowFactory.Create();
                    newTaskWindow.ShowDialog();
                    break;
            }
        }
    }
}
