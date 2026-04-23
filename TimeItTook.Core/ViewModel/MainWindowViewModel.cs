using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TimeItTook.Core.Model;
using TimeItTook.Core.Service;
using TimeItTook.Core.Util;

namespace TimeItTook.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly IUserInteractionService interactionService;
        private readonly IAbstractFactory<AddNewTaskWindowViewModel> newTaskViewModelFactory;

        public MainWindowViewModel(
            IUserInteractionService userInteractionService,
            IAbstractFactory<AddNewTaskWindowViewModel> addNewTaskViewModelFactory)
        {
            interactionService = userInteractionService;
            newTaskViewModelFactory = addNewTaskViewModelFactory;
        }

        [RelayCommand]
        public void NewTask()
        {
            interactionService.RequestInteraction(newTaskViewModelFactory.Create());
        }

        public ObservableCollection<Core.Model.Task> Tasks { get; set; } = new ObservableCollection<Core.Model.Task>();
    }
}
