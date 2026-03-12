namespace TimeItTook.Core.Model
{
    public class Project
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public ProjectType ProjectType { get; set; }
        public bool IsComplete { get; set; } = false;
        public IEnumerable<Task> Tasks { get; set; } = Enumerable.Empty<Task>();
    }
}
