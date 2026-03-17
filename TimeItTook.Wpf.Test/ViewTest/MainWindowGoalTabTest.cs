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
            using var rig = new TestRig(testRigConfig);
            Assert.NotNull(rig.MainWindow);
            var outputElement = rig.MainWindow?.FindFirstDescendant(cf => cf.ByAutomationId("TextBoxOutput")).AsTextBox();
            var incrementButton = rig.MainWindow?.FindFirstDescendant(cf => cf.ByAutomationId("ButtonIncrement")).AsButton();
            var decrementButton = rig.MainWindow?.FindFirstDescendant(cf => cf.ByAutomationId("ButtonDecrement")).AsButton();
            Assert.NotNull(outputElement);
            Assert.NotNull(incrementButton);
            Assert.NotNull(incrementButton);
            if (int.TryParse(outputElement?.Text, out int initialValue))
            {
                incrementButton?.Click();
                if (int.TryParse(outputElement?.Text, out int incrementValue))
                {
                    Assert.Equal(initialValue + 1, incrementValue);
                }
                else
                {
                    Assert.Fail("increment value is not an integer. Value was " + outputElement?.Text);
                }
                decrementButton?.Click();
                if (int.TryParse(outputElement?.Text, out int decrementValue))
                {
                    Assert.Equal(initialValue, decrementValue);
                }
                else
                {
                    Assert.Fail("decrement value is not an integer. Value was " + outputElement?.Text);
                }
                decrementButton?.Click();
                if (int.TryParse(outputElement?.Text, out decrementValue))
                {
                    Assert.Equal(initialValue - 1, decrementValue);
                }
                else
                {
                    Assert.Fail("second decrement value is not an integer. Value was " + outputElement?.Text);
                }
            }
            else
            {
                Assert.Fail("initial value is not an integer. Value was " + outputElement?.Text + ", output element is " + (outputElement is null ? "null" : "not null"));
            }
        }

        [Fact]
        public void AdHocGoalExistsByDefault()
        {

        }

        [Fact]
        public void ClickingAddGoalButtonShowsCreateGoalModal()
        {

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
