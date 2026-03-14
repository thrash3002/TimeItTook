namespace TimeItTook.Wpf.Test.ViewTest
{
    public class MainWindowTaskTabTest
    {
        [Fact]
        public void ClickingOnTaskTabShowsTaskPage()
        {

        }

        [Fact]
        public void ClickingAddTaskButtonShowsCreateTaskModal()
        {

        }

        [Fact]
        public void CanSeeSelectedTaskInActiveTaskSection()
        {

        }

        [Fact]
        public void SelectedTaskShowsAsSecondTaskInActiveTaskSectionIfOneTaskAlreadyRunning()
        {

        }

        [Fact]
        public void SelectedTaskShowsAsThirdTaskInActiveTaskSectionIfTwoTasksAlreadyRunning()
        {

        }

        [Fact]
        public void SelectedTaskReplacesPreviouslySelectedTaskInActiveTaskSection()
        {

        }

        [Fact]
        public void ClickingCopyTaskButtonShowsCreateTaskModalWithRelevantInfoCopied()
        {

        }

        [Fact]
        public void StartButtonGreyedOutIfTwoTasksAlreadyRunning()
        {

        }

        [Fact]
        public void StartButtonGreyedOutUnlessPrerequisiteTasksAreAllCompleted()
        {

        }

        [Fact]
        public void ClickingStartButtonTogglesItToPauseButton()
        {

        }

        [Fact]
        public void ClickingPauseButtonTogglesItToContinueButton()
        {

        }

        [Fact]
        public void MarkAsCompletedButtonGreyedOutUnlessStartTimeHasBeenSet()
        {

        }

        [Fact]
        public void MarkAsCompletedButtonGreyedOutUnlessPrerequisiteTasksAreAllCompleted()
        {

        }

        [Fact]
        public void EditButtonOpensEditTaskDialog()
        {

        }

        [Fact]
        public void DeleteButtonOpensAreYouSureConfirmationMessageBox()
        {

        }

        [Fact]
        public void CanSee20TasksInTaskList()
        {

        }

        [Fact]
        public void CompletedTasksHiddenInTaskListIfShowCompletedCheckBoxIsUnchecked()
        {

        }

        [Fact]
        public void IsCompletedColumnHiddenInTaskListIfShowCompletedCheckBoxIsUnchecked()
        {

        }

        [Fact]
        public void CompletedTasksShowInTaskListIfShowCompletedCheckBoxIsChecked()
        {

        }

        [Fact]
        public void IsCompletedColumnShowsInTaskListIfShowCompletedCheckBoxIsChecked()
        {

        }

        [Fact]
        public void TaskListCanBeFilteredToShowTodayOnly()
        {

        }

        [Fact]
        public void TaskListCanBeFilteredToShowWeekOnly()
        {

        }

        [Fact]
        public void TaskListCanBeFilteredToShowFortnightOnly()
        {

        }

        [Fact]
        public void TaskListCanBeFilteredToShowMonthOnly()
        {

        }

        [Fact]
        public void TaskListCanBeFilteredToShow10TasksOnly()
        {

        }

        [Fact]
        public void TaskListCanBeFilteredToShow25TasksOnly()
        {

        }

        [Fact]
        public void TaskListCanBeFilteredToShow50TasksOnly() // TODO: is this necessary?
        {

        }

        [Fact]
        public void TaskListShowsAllIncompleteTasksOnlyByDefault() // i.e. no other filters
        {

        }

        [Fact]
        public void TasksAreOrderedByDeadlineByDefault()
        {

        }

        [Fact]
        public void TasksAreOrderedByDeadlineAndThenPriorityByDefault()
        {

        }

        [Fact]
        public void ClickNameColumnHeaderToOrderByName()
        {

        }

        [Fact]
        public void ClickEstimateColumnHeaderToOrderByEstimate()
        {

        }

        [Fact]
        public void ClickDeadlineColumnHeaderToReturnToDefaultOrder()
        {

        }

        [Fact]
        public void ClickPriorityColumnHeaderToOrderByPriority()
        {

        }

        [Fact]
        public void ClickIsCompletedColumnHeaderToOrderByIsCompleted()
        {

        }
    }
}
