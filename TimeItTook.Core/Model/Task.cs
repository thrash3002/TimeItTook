namespace TimeItTook.Core.Model
{
    public class Task : TaskBase
    {
        public DateTime? Deadline { get; set; }
        public TimeSpan? DeadlineApproachingHighlight { get; set; } // Chose not to put this in TaskBase since Deadline is not in TaskBase
        public bool IsCompleted { get; set; } = false;
        public IEnumerable<TaskInterval> Intervals { get; set; } = Enumerable.Empty<TaskInterval>();
        public IEnumerable<Goal> Goals { get; set; } = Enumerable.Empty<Goal>();
    }
}
