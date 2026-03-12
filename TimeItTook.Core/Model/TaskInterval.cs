namespace TimeItTook.Core.Model
{
    public class TaskInterval
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public Guid TaskID { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
