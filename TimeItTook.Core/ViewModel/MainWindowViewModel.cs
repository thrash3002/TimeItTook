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
        private readonly IAbstractFactory<AddNewGoalWindowViewModel> newGoalViewModelFactory;

        public MainWindowViewModel(
            IUserInteractionService userInteractionService,
            IAbstractFactory<AddNewTaskWindowViewModel> addNewTaskViewModelFactory,
            IAbstractFactory<AddNewGoalWindowViewModel> addNewGoalViewModelFactory)
        {
            interactionService = userInteractionService;
            newTaskViewModelFactory = addNewTaskViewModelFactory;
            newGoalViewModelFactory = addNewGoalViewModelFactory;
        }

        [RelayCommand]
        public void NewTask()
        {
            interactionService.RequestInteraction(newTaskViewModelFactory.Create());
        }

        [RelayCommand]
        public void NewGoal()
        {
            interactionService.RequestInteraction(newGoalViewModelFactory.Create());
        }

        public ObservableCollection<Core.Model.Task> Tasks { get; set; } = [];
        public ObservableCollection<Goal> Goals { get; set; } = [];
    }
}
