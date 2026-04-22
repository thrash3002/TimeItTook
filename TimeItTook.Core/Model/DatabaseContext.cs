using Microsoft.EntityFrameworkCore;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<TaskBase>();
            modelBuilder.Entity<DefaultTask>()
                .HasKey(dt => dt.ID);
            modelBuilder.Entity<DefaultTask>()
                .HasMany(dt => dt.GoalTypes)
                .WithMany(g => g.DefaultTasks);

            modelBuilder.Entity<Goal>()
                .HasKey(g => g.ID);
            modelBuilder.Entity<Goal>()
                .HasOne(g => g.GoalType)
                .WithMany()
                .HasForeignKey(g => g.GoalTypeID)
                .IsRequired(false);
            modelBuilder.Entity<Goal>()
                .HasMany(g => g.Tasks)
                .WithMany(t => t.Goals);

            modelBuilder.Entity<GoalType>()
                .HasKey(gt => gt.ID);

            modelBuilder.Entity<Task>()
                .HasKey(t => t.ID);
            modelBuilder.Entity<Task>()
                .HasMany(t => t.Intervals)
                .WithOne(ti => ti.Task)
                .HasForeignKey(ti => ti.TaskID);
            
            modelBuilder.Entity<TaskInterval>()
                .HasKey(g => g.ID);
        }
    }
}
