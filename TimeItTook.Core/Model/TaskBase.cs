namespace TimeItTook.Core.Model
{
    public abstract class TaskBase
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public TimeSpan? Estimate { get; set; }
        public TimeSpan? RepeatInterval { get; set; }
    }
}
