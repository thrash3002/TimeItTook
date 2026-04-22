namespace TimeItTook.Core.Model
{
    public abstract class TaskBase
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "New Task";
        public TimeSpan? Estimate { get; set; }
        public TimeSpan? RepeatInterval { get; set; }
        public Priority Priority { get; set; } = Priority.Low;
        public string Notes { get; set; } = string.Empty;
        public IEnumerable<TaskBase> PreRequisites { get; set; } = Enumerable.Empty<TaskBase>();
    }
}
