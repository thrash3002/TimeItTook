namespace TimeItTook.Core.Model
{
    public class GoalType
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public IEnumerable<DefaultTask> DefaultTasks { get; set; }
    }
}
