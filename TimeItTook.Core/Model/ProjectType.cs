namespace TimeItTook.Core.Model
{
    public class ProjectType
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public IEnumerable<DefaultTask> DefaultTasks { get; set; }
    }
}
