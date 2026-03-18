using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TimeItTook.Core.Model
{
    public class DatabaseContext : DbContext
    {
        public string DatabasePath { get; }

        public DbSet<DefaultTask> DefaultTasks { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalType> GoalTypes { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskInterval> TaskIntervals { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Directory.CreateDirectory(Path.Join(Directory.GetCurrentDirectory(), "Data"));
            DatabasePath = Path.Join(Directory.GetCurrentDirectory(), "Data", "TimeItTook.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DatabasePath}");
        }
    }
}
