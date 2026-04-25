using FlaUI.Core.AutomationElements;

namespace TimeItTook.Wpf.Test.ViewTest
{
    public class MainWindowGoalTabTest : IClassFixture<TestRigConfig>
    {
        TestRigConfig testRigConfig;

        public MainWindowGoalTabTest(TestRigConfig config)
        {
            testRigConfig = config;
        }

        [Fact]
        public void ClickingOnGoalTabShowsGoalPage()
        {
            // Arrange
            using var testRig = new TestRig(testRigConfig);
            Assert.True(
                testRig.FindControlByName("TabSwitcher", out var tabControlElement));
            var tabControl = tabControlElement.AsTab();
            Assert.True(
                testRig.FindControlByName("TaskTab", out var taskTab));
            Assert.True(
                testRig.FindControlByName("GoalTab", out var goalTab));

            // Act
            taskTab!.AsTabItem().Click();
            goalTab!.AsTabItem().Click();

            // Assert
            Assert.Equal(tabControl?.SelectedTabItem?.AutomationId, goalTab?.AutomationId);
        }

        [Fact]
        public void AdHocGoalExistsByDefault()
        {

        }

        [Fact]
        public void ClickingAddGoalButtonShowsCreateGoalModal()
        {
            using var testRig = new TestRig(testRigConfig);
            // Arrange
            Assert.True(
                testRig.FindControlByName("GoalTab", out var goalTab));
            goalTab!.AsTabItem().Click();
            Assert.True(
                testRig.FindControlByName("NewGoal", out var newGoalButtonElement));

            // Act
            newGoalButtonElement!.AsButton().Click();

            // Assert
            Assert.Contains(testRig.GetAllTopLevelWindows(), window => window.AutomationId.Equals("Window_AddNewGoal"));
        }

        [Fact]
        public void CanSeeSelectedGoalInSelectedGoalSection()
        {

        }

        [Fact]
        public void SelectedGoalReplacesPreviouslySelectedGoalInSelectedGoalSection()
        {

        }

        [Fact]
        public void SelectedGoalSectionShowsNextFiveTasks()
        {

        }

        [Fact]
        public void ClickingCopyToGoalStructureButtonShowsCreateGoalTypeModalWithRelevantInfoCopied()
        {

        }

        [Fact]
        public void DoubleClickingTaskFromSelectedGoalSectionOpensTaskTabWithTaskShowingInActiveTaskSection()
        {

        }

        [Fact]
        public void EditButtonOpensEditGoalDialog()
        {

        }

        [Fact]
        public void DeleteTaskFromGoalButtonGreyedOutUnlessTaskSelected()
        {

        }

        [Fact]
        public void RemoveTaskFromGoalButtonGreyedOutUnlessTaskSelected()
        {

        }

        [Fact]
        public void DeleteTaskFromGoalButtonOpensAreYouSureConfirmationMessageBox()
        {

        }

        [Fact]
        public void RemoveTaskFromGoalButtonOpensAreYouSureConfirmationMessageBox()
        {

        }

        [Fact]
        public void DeleteButtonOpensAreYouSureConfirmationMessageBox()
        {

        }

        [Fact]
        public void CanSee20GoalsInGoalList()
        {

        }

        [Fact]
        public void CompletedGoalsHiddenInGoalListIfShowCompletedCheckBoxIsUnchecked()
        {

        }

        [Fact]
        public void IsCompletedColumnHiddenInGoalListIfShowCompletedCheckBoxIsUnchecked()
        {

        }

        [Fact]
        public void CompletedGoalsShowInGoalListIfShowCompletedCheckBoxIsChecked()
        {

        }

        [Fact]
        public void IsCompletedColumnShowsInGoalListIfShowCompletedCheckBoxIsChecked()
        {

        }

        [Fact]
        public void GoalListCanBeFilteredByGoalType()
        {

        }

        [Fact]
        public void GoalListCanBeFilteredToShow10GoalsOnly()
        {

        }

        [Fact]
        public void GoalListCanBeFilteredToShow25GoalsOnly()
        {

        }

        [Fact]
        public void GoalListCanBeFilteredToShow50GoalsOnly() // TODO: is this necessary?
        {

        }

        [Fact]
        public void GoalListShowsAllIncompleteGoalsOnlyByDefault() // i.e. no other filters
        {

        }

        [Fact]
        public void GoalsAreOrderedByDeadlineByDefault()
        {

        }

        [Fact]
        public void GoalsAreOrderedByDeadlineAndThenPriorityByDefault()
        {

        }

        [Fact]
        public void ClickNameColumnHeaderToOrderByName()
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
