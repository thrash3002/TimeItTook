namespace TimeItTook.Core.Model
{
    public class Goal
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public GoalType? GoalType { get; set; }
        public Priority Priority { get; set; } = Priority.Low;
        public DateTime? Deadline { get; set; }
        public TimeSpan? DeadlineApproachingHighlight { get; set; }
        public string Notes { get; set; }
        public bool IsComplete { get; set; } = false;
        public IEnumerable<Task> Tasks { get; set; } = Enumerable.Empty<Task>();
    }
}
