namespace TimeItTook.Wpf.Test.ViewTest
{
    public class AddNewTaskWindowTest
    {
        [Fact]
        public void CanSetTimeStartTimeInThePastOnly()
        {

        }

        [Fact]
        public void CanSetDurationForTaskIfStartTimeSetOnly()
        {

        }

        [Fact]
        public void DurationSetCannotExceedNowMinusStartTime()
        {

        }

        // Note:  I thought about adding a test to check that duration set
        // cannot exceed "now-minus-start time plus any task intervals in
        // between", but this does not make sense if two tasks can be run at the
        // same time.  It would have to be "now-minus-start time plus any task
        // intervals in between but not if the task was also running", but this
        // is a bit nonsensical.  I may revisit this later.

        [Fact]
        public void GoalFieldDefaultsToAdHocGoal()
        {

        }

        [Fact]
        public void CanEnableAutoPauseOnScreenLock()
        {

        }
    }
}
