namespace TimeItTook.Core.Model
{
    public class DefaultTask : TaskBase
    {
        public TimeSpan? Deadline { get; set; }
        public TimeSpan? DeadlineApproachingHighlight { get; set; } // Chose not to put this in TaskBase since Deadline is not in TaskBase
        public IEnumerable<GoalType> GoalTypes { get; set; } = Enumerable.Empty<GoalType>();
    }
}
