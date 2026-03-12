namespace TimeItTook.Core.Model
{
    public class DefaultTask : TaskBase
    {
        public TimeSpan? Deadline { get; set; }
        public IEnumerable<ProjectType> ProjectTypes { get; set; } = Enumerable.Empty<ProjectType>();
    }
}
