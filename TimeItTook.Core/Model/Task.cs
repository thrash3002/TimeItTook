namespace TimeItTook.Core.Model
{
    public class Task : TaskBase
    {
        public DateTime? Deadline { get; set; }
        public bool IsComplete { get; set; } = false;

        public IEnumerable<TaskInterval> Intervals { get; set; } = Enumerable.Empty<TaskInterval>();

        public IEnumerable<Goal> Goals { get; set; } = Enumerable.Empty<Goal>();
    }
}
