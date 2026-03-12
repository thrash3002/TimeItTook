namespace TimeItTook.Core.Model
{
    public class DefaultTask : TaskBase
    {
        public TimeSpan? Deadline { get; set; }
        public IEnumerable<GoalType> GoalTypes { get; set; } = Enumerable.Empty<GoalType>();
    }
}
